using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class FormUsuarios : Form
    {
        private UsuarioBLL usuarioBll = new UsuarioBLL();
        private List<UsuarioDTO> lista = new();

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var u = new UsuarioDTO
                {
                    IdUsuario = string.IsNullOrEmpty(textBoxId.Text) ? 0 : int.Parse(textBoxId.Text),
                    Usuario = textBoxUsuario.Text.Trim(),
                    Contrasena = textBoxContrasena.Text,
                    EstadoUsuario = checkBoxActivo.Checked,
                    IdRol = (int)comboBoxRol.SelectedValue
                };

                usuarioBll.Guardar(u);
                MessageBox.Show("Usuario guardado correctamente");
                CargarUsuarios();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridViewUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.CurrentRow == null) return;

            var u = (UsuarioDTO)dataGridViewUsuarios.CurrentRow.DataBoundItem;
            textBoxId.Text = u.IdUsuario.ToString();
            textBoxUsuario.Text = u.Usuario;
            checkBoxActivo.Checked = u.EstadoUsuario;
            comboBoxRol.SelectedValue = u.IdRol;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text)) return;
            int id = int.Parse(textBoxId.Text);

            if (MessageBox.Show("¿Eliminar usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usuarioBll.Eliminar(id);
                CargarUsuarios();
                Limpiar();
            }
        }

        private void FromUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarUsuarios();
        }

        private void CargarRoles()
        {
            var dt = DbHelper.EjecutarSpTabla("ListarRoles");
            comboBoxRol.DataSource = dt;
            comboBoxRol.DisplayMember = "rol";
            comboBoxRol.ValueMember = "idRol";
        }

        private void CargarUsuarios()
        {
            lista = usuarioBll.Listar();
            dataGridViewUsuarios.DataSource = lista;
        }

        private void Limpiar()
        {
            textBoxId.Text = "";
            textBoxUsuario.Text = "";
            textBoxContrasena.Text = "";
            checkBoxActivo.Checked = true;
            comboBoxRol.SelectedIndex = 0;
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
        }
    }
}
