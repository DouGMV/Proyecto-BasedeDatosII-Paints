using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormProductos : Form
    {
        private ProductoBLL producto = new ProductoBLL();
        private List<ProductoDTO> lista = new List<ProductoDTO>();

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarUnidades();
            CargarProductos();
        }

        private void CargarProductos()
        {
            lista = producto.Listar();
            dataGridViewProductos.DataSource = lista;
        }

        private void CargarUnidades()
        {
            try
            {
                var dt = DbHelper.EjecutarSpTabla("ListarUnidades");

                if (dt != null && dt.Rows.Count > 0)
                {
                    comboBoxUnidad.DataSource = dt;
                    comboBoxUnidad.DisplayMember = "unidadMedida";
                    comboBoxUnidad.ValueMember = "idUnidadProducto";
                }
                else
                {
                    comboBoxUnidad.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar unidades: " + ex.Message);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                comboBoxCategoria.SelectedIndexChanged -= comboBoxCategoria_SelectedIndexChanged;

                var dt = DbHelper.EjecutarSpTabla("ListarCategorias");

                if (dt != null && dt.Rows.Count > 0)
                {
                    comboBoxCategoria.DataSource = dt;
                    comboBoxCategoria.DisplayMember = "categoria";
                    comboBoxCategoria.ValueMember = "idCategoriaProducto";
                }
                else
                {
                    comboBoxCategoria.DataSource = null;
                }

                comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void comboBoxCategoria_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                if (comboBoxCategoria.SelectedValue == null || comboBoxCategoria.SelectedValue == DBNull.Value)
                    return;

                string categoria = comboBoxCategoria.Text ?? "";

                // Traemos todas las unidades desde el SP
                var dt = DbHelper.EjecutarSpTabla("ListarUnidades");
                DataTable dtFiltrado = dt.Clone();

                foreach (DataRow row in dt.Rows)
                {
                    string unidad = row["unidadMedida"]?.ToString() ?? "";

                    if (categoria == "Accesorios" && unidad == "Unidad")
                        dtFiltrado.ImportRow(row);
                    else if ((categoria == "Solventes" || categoria == "Barnices") && unidad.Contains("galón"))
                        dtFiltrado.ImportRow(row);
                    else if (categoria == "Pinturas" && unidad != "Unidad")
                        dtFiltrado.ImportRow(row);
                }

                comboBoxUnidad.DataSource = dtFiltrado.Rows.Count > 0 ? dtFiltrado : null;
                comboBoxUnidad.DisplayMember = "unidadMedida";
                comboBoxUnidad.ValueMember = "idUnidadProducto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar unidades: " + ex.Message);
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(textBoxPrecio.Text, out decimal precioVenta))
                {
                    MessageBox.Show("El precio ingresado no es válido.");
                    return;
                }

                var p = new ProductoDTO
                {
                    IdProducto = string.IsNullOrEmpty(textBoxId.Text) ? 0 : int.Parse(textBoxId.Text),
                    Nombre = textBoxNombre.Text.Trim(),
                    Marca = string.IsNullOrWhiteSpace(textBoxMarca.Text) ? null : textBoxMarca.Text.Trim(),
                    Descripcion = string.IsNullOrWhiteSpace(textBoxDescripcion.Text) ? null : textBoxDescripcion.Text.Trim(),
                    PrecioVenta = precioVenta,
                    EstadoProducto = checkBoxActivo.Checked,
                    IdCategoriaProducto = (int)comboBoxCategoria.SelectedValue,
                    IdUnidadProducto = (int)comboBoxUnidad.SelectedValue
                };

                producto.Guardar(p);
                MessageBox.Show("Producto guardado correctamente");
                CargarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow?.Cells["IdProducto"]?.Value == null) return;

            int id = Convert.ToInt32(dataGridViewProductos.CurrentRow.Cells["IdProducto"].Value);

            if (MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                producto.Eliminar(id);
                CargarProductos();
            }
        }

        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow?.Cells["IdProducto"]?.Value == null) return;

            int id = Convert.ToInt32(dataGridViewProductos.CurrentRow.Cells["IdProducto"].Value);
            var p = lista.FirstOrDefault(x => x.IdProducto == id);

            if (p != null)
            {
                textBoxId.Text = p.IdProducto.ToString();
                textBoxNombre.Text = p.Nombre;
                textBoxMarca.Text = p.Marca;
                textBoxDescripcion.Text = p.Descripcion;
                textBoxPrecio.Text = p.PrecioVenta.ToString("0.00");
                checkBoxActivo.Checked = p.EstadoProducto;

                comboBoxCategoria.SelectedValue = p.IdCategoriaProducto;
                comboBoxUnidad.SelectedValue = p.IdUnidadProducto;
            }
        }

        private void Limpiar()
        {
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxMarca.Text = "";
            textBoxDescripcion.Text = "";
            textBoxPrecio.Text = "";
            checkBoxActivo.Checked = true;
            comboBoxCategoria.SelectedIndex = 0;
            comboBoxUnidad.SelectedIndex = 0;
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarUnidades();
            CargarProductos();
        }
    }
}
