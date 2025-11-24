using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace UI
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            this.Load += FormReportes_Load;
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            // Llenar tipos de reporte al cargar la pantalla
            comboBoxTipoReporte.Items.Clear();
            comboBoxTipoReporte.Items.Add("Facturas por fecha");
            comboBoxTipoReporte.Items.Add("Facturas anuladas");
            comboBoxTipoReporte.Items.Add("Productos más vendidos");
            comboBoxTipoReporte.SelectedIndex = 0;

            dateTimePickerInicio.Value = DateTime.Today.AddDays(-7);
            dateTimePickerFin.Value = DateTime.Today;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoReporte.SelectedItem == null) return;

            string tipo = comboBoxTipoReporte.SelectedItem.ToString();
            DataTable dt = null;

            try
            {
                switch (tipo)
                {
                    case "Facturas por fecha":
                        dt = ReporteFacturasPorFecha();
                        break;

                    case "Facturas anuladas":
                        dt = ReporteFacturasAnuladas();
                        break;

                    case "Productos más vendidos":
                        dt = ReporteProductosMasVendidos();
                        break;
                }

                dataGridViewReportes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message);
            }
        }

        // Reporte: Facturas por rango de fecha
        private DataTable ReporteFacturasPorFecha()
        {
            DateTime inicio = dateTimePickerInicio.Value.Date;
            DateTime fin = dateTimePickerFin.Value.Date;

            return DbHelper.EjecutarSpTabla("ReporteFacturasPorFecha",
                new SqlParameter("@inicio", inicio),
                new SqlParameter("@fin", fin));
        }

        // Reporte: Facturas anuladas
        private DataTable ReporteFacturasAnuladas()
        {
            return DbHelper.EjecutarSpTabla("ReporteFacturasAnuladas");
        }

        // Reporte: Productos más vendidos
        private DataTable ReporteProductosMasVendidos()
        {
            return DbHelper.EjecutarSpTabla("ReporteProductosMasVendidos");
        }
    }
}
