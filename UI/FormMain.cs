namespace UI
{
    public partial class FormMain : Form
    {
        private UsuarioDTO usuariodto;
        public FormMain(UsuarioDTO usuario)
        {
            InitializeComponent();
            usuariodto = usuario;
            AplicarPermisos();
            labelUsuario.Text = $"{usuario.Usuario} - Rol: {usuario.IdRol}";
        }

        private void AplicarPermisos()
        {
            // Ejemplo simple: 1 Digitador, 2 Cajero, 3 Gerente
            if (usuariodto.IdRol == 1) // Digitador
            {
                // Digitador no debe cobrar o ver reportes
                reportesToolStripMenuItem.Visible = false;
                // etc
            }
            else if (usuariodto.IdRol == 2) // Cajero
            {
                // Cajero solo cobrar
                mantenimientosToolStripMenuItem.Visible = false;
            }
            // Gerente todo visible
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormClientes();
            formulario.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormProductos();
            formulario.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormEmpleados();
            formulario.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormUsuarios();
            formulario.ShowDialog();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormFacturacion();
            formulario.ShowDialog();
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormAnulacionFactura();
            formulario.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormReportes();
            formulario.ShowDialog();
        }
    }
}
