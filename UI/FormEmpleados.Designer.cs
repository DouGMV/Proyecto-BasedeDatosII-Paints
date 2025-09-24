namespace UI
{
    partial class FormEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewEmpleados = new DataGridView();
            textBoxId = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDpi = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxEmail = new TextBox();
            labelId = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            labelDpi = new Label();
            labelDireccion = new Label();
            labelTelefono = new Label();
            labelEmail = new Label();
            textBoxSueldo = new TextBox();
            labelSueldo = new Label();
            dateTimePickerNacimiento = new DateTimePicker();
            dateTimePickerContratacion = new DateTimePicker();
            labelFechaNacimiento = new Label();
            labelFechaContratacion = new Label();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonEliminar = new Button();
            buttonRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Location = new Point(389, 23);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.RowHeadersWidth = 51;
            dataGridViewEmpleados.Size = new Size(399, 187);
            dataGridViewEmpleados.TabIndex = 0;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(203, 23);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(145, 27);
            textBoxId.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(203, 70);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(145, 27);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(203, 115);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(145, 27);
            textBoxApellido.TabIndex = 3;
            // 
            // textBoxDpi
            // 
            textBoxDpi.Location = new Point(203, 159);
            textBoxDpi.Name = "textBoxDpi";
            textBoxDpi.Size = new Size(145, 27);
            textBoxDpi.TabIndex = 4;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(203, 203);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(145, 27);
            textBoxDireccion.TabIndex = 5;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(203, 246);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(145, 27);
            textBoxTelefono.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(203, 292);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(145, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(41, 30);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 8;
            labelId.Text = "ID:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(41, 77);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 9;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(41, 122);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(69, 20);
            labelApellido.TabIndex = 10;
            labelApellido.Text = "Apellido:";
            // 
            // labelDpi
            // 
            labelDpi.AutoSize = true;
            labelDpi.Location = new Point(41, 166);
            labelDpi.Name = "labelDpi";
            labelDpi.Size = new Size(35, 20);
            labelDpi.TabIndex = 11;
            labelDpi.Text = "DPI:";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(41, 210);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(75, 20);
            labelDireccion.TabIndex = 12;
            labelDireccion.Text = "Direccion:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(41, 253);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(70, 20);
            labelTelefono.TabIndex = 13;
            labelTelefono.Text = "Telefono:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(41, 299);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email:";
            // 
            // textBoxSueldo
            // 
            textBoxSueldo.Location = new Point(203, 337);
            textBoxSueldo.Name = "textBoxSueldo";
            textBoxSueldo.Size = new Size(145, 27);
            textBoxSueldo.TabIndex = 15;
            // 
            // labelSueldo
            // 
            labelSueldo.AutoSize = true;
            labelSueldo.Location = new Point(41, 344);
            labelSueldo.Name = "labelSueldo";
            labelSueldo.Size = new Size(58, 20);
            labelSueldo.TabIndex = 16;
            labelSueldo.Text = "Sueldo:";
            // 
            // dateTimePickerNacimiento
            // 
            dateTimePickerNacimiento.Location = new Point(203, 381);
            dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            dateTimePickerNacimiento.Size = new Size(145, 27);
            dateTimePickerNacimiento.TabIndex = 17;
            // 
            // dateTimePickerContratacion
            // 
            dateTimePickerContratacion.Location = new Point(203, 426);
            dateTimePickerContratacion.Name = "dateTimePickerContratacion";
            dateTimePickerContratacion.Size = new Size(145, 27);
            dateTimePickerContratacion.TabIndex = 18;
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(41, 388);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(131, 20);
            labelFechaNacimiento.TabIndex = 19;
            labelFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // labelFechaContratacion
            // 
            labelFechaContratacion.AutoSize = true;
            labelFechaContratacion.Location = new Point(41, 433);
            labelFechaContratacion.Name = "labelFechaContratacion";
            labelFechaContratacion.Size = new Size(139, 20);
            labelFechaContratacion.TabIndex = 20;
            labelFechaContratacion.Text = "Fecha Contratacion:";
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(435, 243);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(83, 30);
            buttonNuevo.TabIndex = 21;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(626, 243);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(83, 30);
            buttonGuardar.TabIndex = 22;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(435, 312);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(83, 30);
            buttonEliminar.TabIndex = 23;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(626, 314);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(83, 28);
            buttonRefrescar.TabIndex = 24;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(labelFechaContratacion);
            Controls.Add(labelFechaNacimiento);
            Controls.Add(dateTimePickerContratacion);
            Controls.Add(dateTimePickerNacimiento);
            Controls.Add(labelSueldo);
            Controls.Add(textBoxSueldo);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefono);
            Controls.Add(labelDireccion);
            Controls.Add(labelDpi);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(labelId);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxDpi);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxId);
            Controls.Add(dataGridViewEmpleados);
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmpleados;
        private TextBox textBoxId;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDpi;
        private TextBox textBoxDireccion;
        private TextBox textBoxTelefono;
        private TextBox textBoxEmail;
        private Label labelId;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelDpi;
        private Label labelDireccion;
        private Label labelTelefono;
        private Label labelEmail;
        private TextBox textBoxSueldo;
        private Label labelSueldo;
        private DateTimePicker dateTimePickerNacimiento;
        private DateTimePicker dateTimePickerContratacion;
        private Label labelFechaNacimiento;
        private Label labelFechaContratacion;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonEliminar;
        private Button buttonRefrescar;
    }
}