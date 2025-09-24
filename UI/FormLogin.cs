namespace UI
{
    public partial class FormLogin : Form
    {
        private Autenticacion autenticacion = new Autenticacion();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = textBoxUsuario.Text.Trim();
                var contrasena = textBoxContrasena.Text;
                var resultado = autenticacion.Login(usuario, contrasena);
                if (!resultado.Success)
                {
                    MessageBox.Show(resultado.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Abrir main pasando usuario
                var main = new FormMain(resultado.Usuario);
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en login: " + ex.Message);
            }
        }
    }
}
