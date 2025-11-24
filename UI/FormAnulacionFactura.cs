using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace UI
{
    public partial class FormAnulacionFactura : Form
    {
        // Capa de negocio para facturas
        private FacturaBLL facturaBLL = new FacturaBLL();

        public FormAnulacionFactura()
        {
            InitializeComponent();
        }

        // Botón para buscar información de la factura
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string numero = textBoxNumeroFactura.Text.Trim();
            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Ingrese un número de factura.");
                return;
            }

            try
            {
                // Consulta directa para mostrar datos de la factura
                var dt = DbHelper.EjecutarConsulta(
                    $"SELECT numeroFactura, fechaEmision, total, estadoFactura " +
                    $"FROM Factura WHERE numeroFactura = '{numero}'");

                if (dt.Rows.Count == 0)
                {
                    labelInfo.Text = "Factura no encontrada.";
                    return;
                }

                var r = dt.Rows[0];
                bool activa = Convert.ToBoolean(r["estadoFactura"]);

                labelInfo.Text =
                    $"Factura: {r["numeroFactura"]}\n" +
                    $"Fecha: {r["fechaEmision"]}\n" +
                    $"Total: Q{r["total"]}\n" +
                    $"Estado: {(activa ? "Activa" : "Anulada")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar factura: " + ex.Message);
            }
        }

        // Botón para anular la factura
        private void buttonAnular_Click(object sender, EventArgs e)
        {
            string numero = textBoxNumeroFactura.Text.Trim();
            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Ingrese un número de factura.");
                return;
            }

            if (MessageBox.Show("¿Está seguro de anular esta factura?",
                                "Confirmar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                facturaBLL.AnularFactura(numero);
                MessageBox.Show("Factura anulada correctamente.");
                labelInfo.Text = "Factura anulada. Total = 0 y stock devuelto.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular factura: " + ex.Message);
            }
        }
    }
}
