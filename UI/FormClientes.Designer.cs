namespace UI
{
    partial class FormClientes
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
            dataGridViewClientes = new DataGridView();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDpi = new TextBox();
            textBoxNit = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxEmail = new TextBox();
            labelNombre = new Label();
            labelApellido = new Label();
            labelDPI = new Label();
            labelNit = new Label();
            labelDireccion = new Label();
            labelTelefono = new Label();
            labelEmail = new Label();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonEliminar = new Button();
            labelId = new Label();
            textBoxId = new TextBox();
            buttonRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(469, 29);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.Size = new Size(473, 188);
            dataGridViewClientes.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(263, 79);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(136, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(263, 136);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(136, 27);
            textBoxApellido.TabIndex = 2;
            // 
            // textBoxDpi
            // 
            textBoxDpi.Location = new Point(263, 190);
            textBoxDpi.Name = "textBoxDpi";
            textBoxDpi.Size = new Size(136, 27);
            textBoxDpi.TabIndex = 3;
            // 
            // textBoxNit
            // 
            textBoxNit.Location = new Point(263, 244);
            textBoxNit.Name = "textBoxNit";
            textBoxNit.Size = new Size(136, 27);
            textBoxNit.TabIndex = 4;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(263, 294);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(136, 27);
            textBoxDireccion.TabIndex = 5;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(263, 349);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(136, 27);
            textBoxTelefono.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(263, 399);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(136, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(169, 86);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 8;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(169, 143);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(69, 20);
            labelApellido.TabIndex = 9;
            labelApellido.Text = "Apellido:";
            // 
            // labelDPI
            // 
            labelDPI.AutoSize = true;
            labelDPI.Location = new Point(169, 197);
            labelDPI.Name = "labelDPI";
            labelDPI.Size = new Size(35, 20);
            labelDPI.TabIndex = 10;
            labelDPI.Text = "DPI:";
            // 
            // labelNit
            // 
            labelNit.AutoSize = true;
            labelNit.Location = new Point(169, 251);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(35, 20);
            labelNit.TabIndex = 11;
            labelNit.Text = "NIT:";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(169, 297);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(75, 20);
            labelDireccion.TabIndex = 12;
            labelDireccion.Text = "Direccion:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(169, 349);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(70, 20);
            labelTelefono.TabIndex = 13;
            labelTelefono.Text = "Telefono:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(169, 406);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email:";
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(581, 251);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 29);
            buttonNuevo.TabIndex = 15;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(739, 251);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 16;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(581, 304);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(94, 29);
            buttonEliminar.TabIndex = 17;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(169, 36);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 20;
            labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(263, 29);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(136, 27);
            textBoxId.TabIndex = 19;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(739, 304);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(94, 29);
            buttonRefrescar.TabIndex = 21;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(buttonRefrescar);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefono);
            Controls.Add(labelDireccion);
            Controls.Add(labelNit);
            Controls.Add(labelDPI);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxNit);
            Controls.Add(textBoxDpi);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(dataGridViewClientes);
            Name = "FormClientes";
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDpi;
        private TextBox textBoxNit;
        private TextBox textBoxDireccion;
        private TextBox textBoxTelefono;
        private TextBox textBoxEmail;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelDPI;
        private Label labelNit;
        private Label labelDireccion;
        private Label labelTelefono;
        private Label labelEmail;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonEliminar;
        private Label labelId;
        private TextBox textBoxId;
        private Button buttonRefrescar;
    }
}