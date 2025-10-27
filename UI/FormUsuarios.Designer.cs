namespace UI
{
    partial class FormUsuarios
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
            dataGridViewUsuarios = new DataGridView();
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            labelUsuario = new Label();
            labelContrasena = new Label();
            comboBoxRol = new ComboBox();
            labelRol = new Label();
            checkBoxActivo = new CheckBox();
            buttonNuevo = new Button();
            buttonEliminar = new Button();
            buttonGuardar = new Button();
            buttonRefrescar = new Button();
            labelId = new Label();
            textBoxId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(319, 21);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.Size = new Size(455, 207);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(151, 86);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(151, 27);
            textBoxUsuario.TabIndex = 1;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(151, 141);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.Size = new Size(151, 27);
            textBoxContrasena.TabIndex = 2;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(38, 93);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(62, 20);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario:";
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Location = new Point(38, 148);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(86, 20);
            labelContrasena.TabIndex = 4;
            labelContrasena.Text = "Contraseña:";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(151, 195);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(151, 28);
            comboBoxRol.TabIndex = 5;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Location = new Point(38, 210);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(34, 20);
            labelRol.TabIndex = 6;
            labelRol.Text = "Rol:";
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(151, 261);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(73, 24);
            checkBoxActivo.TabIndex = 7;
            checkBoxActivo.Text = "Activo";
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(391, 267);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 29);
            buttonNuevo.TabIndex = 8;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(539, 267);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(94, 29);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(391, 328);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(539, 328);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(94, 29);
            buttonRefrescar.TabIndex = 11;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(38, 43);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 13;
            labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(151, 36);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(151, 27);
            textBoxId.TabIndex = 12;
            // 
            // FromUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonNuevo);
            Controls.Add(checkBoxActivo);
            Controls.Add(labelRol);
            Controls.Add(comboBoxRol);
            Controls.Add(labelContrasena);
            Controls.Add(labelUsuario);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxUsuario);
            Controls.Add(dataGridViewUsuarios);
            Name = "FromUsuarios";
            Text = "FromUsuarios";
            Load += FromUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsuarios;
        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private Label labelUsuario;
        private Label labelContrasena;
        private ComboBox comboBoxRol;
        private Label labelRol;
        private CheckBox checkBoxActivo;
        private Button buttonNuevo;
        private Button buttonEliminar;
        private Button buttonGuardar;
        private Button buttonRefrescar;
        private Label labelId;
        private TextBox textBoxId;
    }
}