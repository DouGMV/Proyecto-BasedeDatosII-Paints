using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormClientes : Form
    {
        private ClienteBLL cliente = new ClienteBLL();
        private List<ClienteDTO> lista;

        public FormClientes()
        {
            InitializeComponent();
            dataGridViewClientes.SelectionChanged += dataGridViewClientes_SelectionChanged;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            lista = cliente.Listar();
            dataGridViewClientes.DataSource = lista;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var c = new ClienteDTO
                {
                    IdCliente = textBoxId.Text == "" ? 0 : Convert.ToInt32(textBoxId.Text),
                    Nombre = textBoxNombre.Text.Trim(),
                    Apellido = textBoxApellido.Text.Trim(),
                    Dpi = textBoxDpi.Text.Trim(),
                    Nit = textBoxNit.Text.Trim(),
                    Direccion = textBoxDireccion.Text.Trim(),
                    Telefono = textBoxTelefono.Text.Trim(),
                    Email = textBoxEmail.Text.Trim()
                };

                var id = cliente.Guardar(c);
                MessageBox.Show("Guardado. Id: " + id);

                CargarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["IdCliente"].Value);
            if (MessageBox.Show("Eliminar registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cliente.Eliminar(id);
                CargarClientes();
                LimpiarCampos();
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void LimpiarCampos()
        {
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDpi.Text = "";
            textBoxNit.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
        }

        private void dataGridViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow == null) return;

            var id = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["IdCliente"].Value);
            var c = lista.FirstOrDefault(x => x.IdCliente == id);

            if (c != null)
            {
                textBoxId.Text = c.IdCliente.ToString();
                textBoxNombre.Text = c.Nombre;
                textBoxApellido.Text = c.Apellido;
                textBoxDpi.Text = c.Dpi;
                textBoxNit.Text = c.Nit;
                textBoxDireccion.Text = c.Direccion;
                textBoxTelefono.Text = c.Telefono;
                textBoxEmail.Text = c.Email;
            }
        }
    }
}
