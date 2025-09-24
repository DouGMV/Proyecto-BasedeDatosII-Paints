namespace UI
{
    public partial class FormEmpleados : Form
    {
        private EmpleadoBLL empleado = new EmpleadoBLL();
        private List<EmpleadoDTO> lista;
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            lista = empleado.Listar();
            dataGridViewEmpleados.DataSource = lista;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = new EmpleadoDTO
                {
                    IdEmpleado = string.IsNullOrEmpty(textBoxId.Text) ? 0 : int.Parse(textBoxId.Text),
                    Nombre = textBoxNombre.Text.Trim(),
                    Apellido = textBoxApellido.Text.Trim(),
                    Dpi = textBoxDpi.Text.Trim(),
                    Direccion = textBoxDireccion.Text.Trim(),
                    Telefono = textBoxTelefono.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    FechaNacimiento = dateTimePickerNacimiento.Value,
                    FechaContratacion = dateTimePickerContratacion.Value,
                    Sueldo = decimal.Parse(textBoxSueldo.Text)
                };

                empleado.Guardar(emp);
                MessageBox.Show("Empleado guardado correctamente");
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.CurrentRow == null) return;
            int id = (int)dataGridViewEmpleados.CurrentRow.Cells["IdEmpleado"].Value;
            if (MessageBox.Show("¿Eliminar empleado?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                empleado.Eliminar(id);
                CargarEmpleados();
            }
        }

        private void dataGridViewEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.CurrentRow == null) return;
            var id = (int)dataGridViewEmpleados.CurrentRow.Cells["IdEmpleado"].Value;
            var emp = lista.FirstOrDefault(x => x.IdEmpleado == id);
            if (emp != null)
            {
                textBoxId.Text = emp.IdEmpleado.ToString();
                textBoxNombre.Text = emp.Nombre;
                textBoxApellido.Text = emp.Apellido;
                textBoxDpi.Text = emp.Dpi;
                textBoxDireccion.Text = emp.Direccion;
                textBoxTelefono.Text = emp.Telefono;
                textBoxEmail.Text = emp.Email;
                dateTimePickerNacimiento.Value = emp.FechaNacimiento ?? DateTime.Now;
                dateTimePickerContratacion.Value = emp.FechaContratacion ?? DateTime.Now;
                textBoxSueldo.Text = emp.Sueldo?.ToString("0.00") ?? "0.00";
            }
        }

        private void Limpiar()
        {
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDpi.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
            dateTimePickerNacimiento.Value = DateTime.Now;
            dateTimePickerContratacion.Value = DateTime.Now;
            textBoxSueldo.Text = "";
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
    }
}
