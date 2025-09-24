namespace UI
{
    partial class FormProductos
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
            dataGridViewProductos = new DataGridView();
            textBoxId = new TextBox();
            textBoxNombre = new TextBox();
            textBoxMarca = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxPrecio = new TextBox();
            labelId = new Label();
            labelNombre = new Label();
            labelMarca = new Label();
            labelDescripcion = new Label();
            labelPrecio = new Label();
            comboBoxCategoria = new ComboBox();
            comboBoxUnidad = new ComboBox();
            labelCategoria = new Label();
            labelUnidad = new Label();
            checkBoxActivo = new CheckBox();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonEliminar = new Button();
            buttonRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(364, 12);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(424, 205);
            dataGridViewProductos.TabIndex = 0;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(199, 12);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(199, 62);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(199, 115);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(125, 27);
            textBoxMarca.TabIndex = 3;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(199, 164);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(125, 27);
            textBoxDescripcion.TabIndex = 4;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(199, 209);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(125, 27);
            textBoxPrecio.TabIndex = 5;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(92, 19);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 6;
            labelId.Text = "ID:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(92, 69);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 7;
            labelNombre.Text = "Nombre:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(92, 122);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(53, 20);
            labelMarca.TabIndex = 8;
            labelMarca.Text = "Marca:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(92, 171);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(90, 20);
            labelDescripcion.TabIndex = 9;
            labelDescripcion.Text = "Descripcion:";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(92, 216);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(53, 20);
            labelPrecio.TabIndex = 10;
            labelPrecio.Text = "Precio:";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(199, 258);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(125, 28);
            comboBoxCategoria.TabIndex = 11;
            // 
            // comboBoxUnidad
            // 
            comboBoxUnidad.FormattingEnabled = true;
            comboBoxUnidad.Location = new Point(199, 308);
            comboBoxUnidad.Name = "comboBoxUnidad";
            comboBoxUnidad.Size = new Size(125, 28);
            comboBoxUnidad.TabIndex = 12;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(92, 266);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(77, 20);
            labelCategoria.TabIndex = 13;
            labelCategoria.Text = "Categoria:";
            // 
            // labelUnidad
            // 
            labelUnidad.AutoSize = true;
            labelUnidad.Location = new Point(92, 316);
            labelUnidad.Name = "labelUnidad";
            labelUnidad.Size = new Size(60, 20);
            labelUnidad.TabIndex = 14;
            labelUnidad.Text = "Unidad:";
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(199, 358);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(73, 24);
            checkBoxActivo.TabIndex = 15;
            checkBoxActivo.Text = "Activo";
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(437, 245);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 29);
            buttonNuevo.TabIndex = 16;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(620, 245);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 17;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(437, 312);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(94, 29);
            buttonEliminar.TabIndex = 18;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(620, 307);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(94, 29);
            buttonRefrescar.TabIndex = 19;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(checkBoxActivo);
            Controls.Add(labelUnidad);
            Controls.Add(labelCategoria);
            Controls.Add(comboBoxUnidad);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelPrecio);
            Controls.Add(labelDescripcion);
            Controls.Add(labelMarca);
            Controls.Add(labelNombre);
            Controls.Add(labelId);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxId);
            Controls.Add(dataGridViewProductos);
            Name = "FormProductos";
            Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private TextBox textBoxId;
        private TextBox textBoxNombre;
        private TextBox textBoxMarca;
        private TextBox textBoxDescripcion;
        private TextBox textBoxPrecio;
        private Label labelId;
        private Label labelNombre;
        private Label labelMarca;
        private Label labelDescripcion;
        private Label labelPrecio;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxUnidad;
        private Label labelCategoria;
        private Label labelUnidad;
        private CheckBox checkBoxActivo;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonEliminar;
        private Button buttonRefrescar;
    }
}