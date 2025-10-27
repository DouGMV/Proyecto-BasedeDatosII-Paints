using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace UI
{
    public partial class FormFacturacion : Form
    {
        private FacturaBLL facturaBLL = new FacturaBLL();
        private List<ProductoDTO> productos = new List<ProductoDTO>();
        private List<DetalleFacturaDTO> detalles = new List<DetalleFacturaDTO>();
        public FormFacturacion()
        {
            InitializeComponent();
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarEmpleados();
            CargarProductos();
            CargarMediosPago();
        }

        private void CargarClientes()
        {
            var dt = DbHelper.EjecutarSpTabla("ListarClientes");
            comboBoxClientes.DataSource = dt;
            comboBoxClientes.DisplayMember = "nombre";
            comboBoxClientes.ValueMember = "idCliente";
        }

        private void CargarEmpleados()
        {
            var dt = DbHelper.EjecutarSpTabla("ListarEmpleados");
            comboBoxEmpleados.DataSource = dt;
            comboBoxEmpleados.DisplayMember = "nombre";
            comboBoxEmpleados.ValueMember = "idEmpleado";
        }

        private void CargarProductos()
        {
            var dt = DbHelper.EjecutarSpTabla("ListarProductos");
            productos = (from DataRow r in dt.Rows
                         select new ProductoDTO
                         {
                             IdProducto = Convert.ToInt32(r["idProducto"]),
                             Nombre = r["nombre"].ToString(),
                             PrecioVenta = Convert.ToDecimal(r["precioVenta"])
                         }).ToList();

            comboBoxProductos.DataSource = productos;
            comboBoxProductos.DisplayMember = "Nombre";
            comboBoxProductos.ValueMember = "IdProducto";
        }

        private void CargarMediosPago()
        {
            var dt = DbHelper.EjecutarSpTabla("ListarMediosPago");
            comboBoxMediosDePago.DataSource = dt;
            comboBoxMediosDePago.DisplayMember = "tipoPago";
            comboBoxMediosDePago.ValueMember = "idMedioPago";
        }

        private void buttonAgregarProductos_Click(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedValue == null) return;

            var producto = productos.First(p => p.IdProducto == (int)comboBoxProductos.SelectedValue);
            int cantidad = (int)numericUpDownCantidad.Value;

            var subtotal = producto.PrecioVenta * cantidad;
            var detalle = new DetalleFacturaDTO
            {
                IdProducto = producto.IdProducto,
                Cantidad = cantidad,
                PrecioUnidad = producto.PrecioVenta,
                Subtotal = subtotal,
                Descuento = 0,
                Impuestos = subtotal * 0.12m // IVA 12%
            };

            detalles.Add(detalle);
            ActualizarTabla();
        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetalle.CurrentRow != null)
            {
                int index = dataGridViewDetalle.CurrentRow.Index;
                detalles.RemoveAt(index);
                ActualizarTabla();
            }
        }

        private void buttonGuardarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (detalles.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto.");
                    return;
                }

                var factura = new FacturaDTO
                {
                    NumeroFactura = Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                    IdCliente = (int)comboBoxClientes.SelectedValue,
                    IdEmpleado = (int)comboBoxEmpleados.SelectedValue,
                    IdMedioPago = (int)comboBoxMediosDePago.SelectedValue,
                    Total = decimal.Parse(textBoxTotal.Text),
                    Detalles = detalles
                };

                int idFactura = facturaBLL.GuardarFactura(factura);

                MessageBox.Show($"Factura {factura.NumeroFactura} creada correctamente (ID: {idFactura})");

                GenerarPDF(factura);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar factura: " + ex.Message);
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if (detalles.Count == 0)
            {
                MessageBox.Show("No hay detalles para imprimir.");
                return;
            }

            var factura = new FacturaDTO
            {
                NumeroFactura = "TEMP_" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                IdCliente = (int)comboBoxClientes.SelectedValue,
                IdEmpleado = (int)comboBoxEmpleados.SelectedValue,
                IdMedioPago = (int)comboBoxMediosDePago.SelectedValue,
                Total = decimal.Parse(textBoxTotal.Text),
                Detalles = detalles
            };

            GenerarPDF(factura);
        }

        private void ActualizarTabla()
        {
            dataGridViewDetalle.DataSource = null;
            dataGridViewDetalle.DataSource = detalles.Select(d => new
            {
                Producto = productos.First(p => p.IdProducto == d.IdProducto).Nombre,
                d.Cantidad,
                d.PrecioUnidad,
                d.Subtotal,
                d.Impuestos
            }).ToList();

            CalcularTotales();
        }

        private void CalcularTotales()
        {
            decimal subtotal = detalles.Sum(d => d.Subtotal);
            decimal impuestos = detalles.Sum(d => d.Impuestos);
            decimal total = subtotal + impuestos;

            textBoxSubtotal.Text = subtotal.ToString("0.00");
            textBoxImpuestos.Text = impuestos.ToString("0.00");
            textBoxTotal.Text = total.ToString("0.00");
        }

        private void GenerarPDF(FacturaDTO factura)
        {
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FacturasPDF");
            Directory.CreateDirectory(carpeta);
            string ruta = Path.Combine(carpeta, $"Factura_{factura.NumeroFactura}.pdf");

            using (FileStream fs = new FileStream(ruta, FileMode.Create, FileAccess.Write))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                var titulo = new Paragraph("PAINTS - FACTURA", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20))
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(titulo);
                doc.Add(new Paragraph($"Fecha: {DateTime.Now}"));
                doc.Add(new Paragraph($"Cliente: {comboBoxClientes.Text}"));
                doc.Add(new Paragraph($"Medio de Pago: {comboBoxMediosDePago.Text}"));
                doc.Add(new Paragraph(" "));
                PdfPTable tabla = new PdfPTable(5);
                tabla.AddCell("Producto");
                tabla.AddCell("Cantidad");
                tabla.AddCell("Precio");
                tabla.AddCell("Subtotal");
                tabla.AddCell("IVA");

                foreach (var d in detalles)
                {
                    var p = productos.First(p => p.IdProducto == d.IdProducto);
                    tabla.AddCell(p.Nombre);
                    tabla.AddCell(d.Cantidad.ToString());
                    tabla.AddCell(d.PrecioUnidad.ToString("0.00"));
                    tabla.AddCell(d.Subtotal.ToString("0.00"));
                    tabla.AddCell(d.Impuestos.ToString("0.00"));
                }

                doc.Add(tabla);
                doc.Add(new Paragraph($"Total a pagar: Q{factura.Total:0.00}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
                doc.Close();
            }

            MessageBox.Show($"Factura PDF generada en: {ruta}");
        }

        private void LimpiarFormulario()
        {
            detalles.Clear();
            ActualizarTabla();
            textBoxSubtotal.Clear();
            textBoxImpuestos.Clear();
            textBoxTotal.Clear();
            numericUpDownCantidad.Value = 1;
        }
    }
}
