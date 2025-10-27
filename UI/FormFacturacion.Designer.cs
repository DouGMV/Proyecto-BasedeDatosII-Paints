namespace UI
{
    partial class FormFacturacion
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
            comboBoxClientes = new ComboBox();
            comboBoxMediosDePago = new ComboBox();
            comboBoxEmpleados = new ComboBox();
            labelClientes = new Label();
            label2 = new Label();
            labelEmpleado = new Label();
            dataGridViewDetalle = new DataGridView();
            textBoxSubtotal = new TextBox();
            textBoxDescuento = new TextBox();
            textBoxImpuestos = new TextBox();
            textBoxTotal = new TextBox();
            labelSubtotal = new Label();
            labelDescuento = new Label();
            labelImpuestos = new Label();
            labelTotal = new Label();
            buttonAgregarProductos = new Button();
            buttonEliminarProducto = new Button();
            buttonGuardarFactura = new Button();
            buttonImprimir = new Button();
            labelProducto = new Label();
            comboBoxProductos = new ComboBox();
            numericUpDownCantidad = new NumericUpDown();
            labelCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            SuspendLayout();
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(187, 37);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(151, 28);
            comboBoxClientes.TabIndex = 0;
            // 
            // comboBoxMediosDePago
            // 
            comboBoxMediosDePago.FormattingEnabled = true;
            comboBoxMediosDePago.Location = new Point(187, 88);
            comboBoxMediosDePago.Name = "comboBoxMediosDePago";
            comboBoxMediosDePago.Size = new Size(151, 28);
            comboBoxMediosDePago.TabIndex = 1;
            // 
            // comboBoxEmpleados
            // 
            comboBoxEmpleados.FormattingEnabled = true;
            comboBoxEmpleados.Location = new Point(187, 135);
            comboBoxEmpleados.Name = "comboBoxEmpleados";
            comboBoxEmpleados.Size = new Size(151, 28);
            comboBoxEmpleados.TabIndex = 2;
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Location = new Point(42, 45);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(58, 20);
            labelClientes.TabIndex = 3;
            labelClientes.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 96);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 4;
            label2.Text = "Medio de Pago:";
            // 
            // labelEmpleado
            // 
            labelEmpleado.AutoSize = true;
            labelEmpleado.Location = new Point(42, 143);
            labelEmpleado.Name = "labelEmpleado";
            labelEmpleado.Size = new Size(80, 20);
            labelEmpleado.TabIndex = 5;
            labelEmpleado.Text = "Empleado:";
            // 
            // dataGridViewDetalle
            // 
            dataGridViewDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalle.Location = new Point(369, 37);
            dataGridViewDetalle.Name = "dataGridViewDetalle";
            dataGridViewDetalle.RowHeadersWidth = 51;
            dataGridViewDetalle.Size = new Size(408, 197);
            dataGridViewDetalle.TabIndex = 6;
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Location = new Point(187, 272);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.Size = new Size(151, 27);
            textBoxSubtotal.TabIndex = 7;
            // 
            // textBoxDescuento
            // 
            textBoxDescuento.Location = new Point(187, 319);
            textBoxDescuento.Name = "textBoxDescuento";
            textBoxDescuento.Size = new Size(151, 27);
            textBoxDescuento.TabIndex = 8;
            // 
            // textBoxImpuestos
            // 
            textBoxImpuestos.Location = new Point(187, 364);
            textBoxImpuestos.Name = "textBoxImpuestos";
            textBoxImpuestos.Size = new Size(151, 27);
            textBoxImpuestos.TabIndex = 9;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(187, 410);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(151, 27);
            textBoxTotal.TabIndex = 10;
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(42, 279);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(68, 20);
            labelSubtotal.TabIndex = 11;
            labelSubtotal.Text = "Subtotal:";
            // 
            // labelDescuento
            // 
            labelDescuento.AutoSize = true;
            labelDescuento.Location = new Point(42, 326);
            labelDescuento.Name = "labelDescuento";
            labelDescuento.Size = new Size(82, 20);
            labelDescuento.TabIndex = 12;
            labelDescuento.Text = "Descuento:";
            // 
            // labelImpuestos
            // 
            labelImpuestos.AutoSize = true;
            labelImpuestos.Location = new Point(42, 371);
            labelImpuestos.Name = "labelImpuestos";
            labelImpuestos.Size = new Size(80, 20);
            labelImpuestos.TabIndex = 13;
            labelImpuestos.Text = "Impuestos:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(42, 417);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(45, 20);
            labelTotal.TabIndex = 14;
            labelTotal.Text = "Total:";
            // 
            // buttonAgregarProductos
            // 
            buttonAgregarProductos.Location = new Point(438, 272);
            buttonAgregarProductos.Name = "buttonAgregarProductos";
            buttonAgregarProductos.Size = new Size(113, 49);
            buttonAgregarProductos.TabIndex = 15;
            buttonAgregarProductos.Text = "Agregar Producto";
            buttonAgregarProductos.UseVisualStyleBackColor = true;
            buttonAgregarProductos.Click += buttonAgregarProductos_Click;
            // 
            // buttonEliminarProducto
            // 
            buttonEliminarProducto.Location = new Point(603, 272);
            buttonEliminarProducto.Name = "buttonEliminarProducto";
            buttonEliminarProducto.Size = new Size(109, 49);
            buttonEliminarProducto.TabIndex = 16;
            buttonEliminarProducto.Text = "Eliminar Producto";
            buttonEliminarProducto.UseVisualStyleBackColor = true;
            buttonEliminarProducto.Click += buttonEliminarProducto_Click;
            // 
            // buttonGuardarFactura
            // 
            buttonGuardarFactura.Location = new Point(438, 332);
            buttonGuardarFactura.Name = "buttonGuardarFactura";
            buttonGuardarFactura.Size = new Size(113, 55);
            buttonGuardarFactura.TabIndex = 17;
            buttonGuardarFactura.Text = "Guardar Factura";
            buttonGuardarFactura.UseVisualStyleBackColor = true;
            buttonGuardarFactura.Click += buttonGuardarFactura_Click;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Location = new Point(603, 332);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(109, 55);
            buttonImprimir.TabIndex = 18;
            buttonImprimir.Text = "Imprimir";
            buttonImprimir.UseVisualStyleBackColor = true;
            buttonImprimir.Click += buttonImprimir_Click;
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Location = new Point(42, 185);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(72, 20);
            labelProducto.TabIndex = 20;
            labelProducto.Text = "Producto:";
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(187, 177);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(151, 28);
            comboBoxProductos.TabIndex = 19;
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(188, 226);
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(150, 27);
            numericUpDownCantidad.TabIndex = 21;
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Location = new Point(42, 233);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(72, 20);
            labelCantidad.TabIndex = 22;
            labelCantidad.Text = "Cantidad:";
            // 
            // FormFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCantidad);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(labelProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(buttonImprimir);
            Controls.Add(buttonGuardarFactura);
            Controls.Add(buttonEliminarProducto);
            Controls.Add(buttonAgregarProductos);
            Controls.Add(labelTotal);
            Controls.Add(labelImpuestos);
            Controls.Add(labelDescuento);
            Controls.Add(labelSubtotal);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxImpuestos);
            Controls.Add(textBoxDescuento);
            Controls.Add(textBoxSubtotal);
            Controls.Add(dataGridViewDetalle);
            Controls.Add(labelEmpleado);
            Controls.Add(label2);
            Controls.Add(labelClientes);
            Controls.Add(comboBoxEmpleados);
            Controls.Add(comboBoxMediosDePago);
            Controls.Add(comboBoxClientes);
            Name = "FormFacturacion";
            Text = "FormFacturacion";
            Load += FormFacturacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClientes;
        private ComboBox comboBoxMediosDePago;
        private ComboBox comboBoxEmpleados;
        private Label labelClientes;
        private Label label2;
        private Label labelEmpleado;
        private DataGridView dataGridViewDetalle;
        private TextBox textBoxSubtotal;
        private TextBox textBoxDescuento;
        private TextBox textBoxImpuestos;
        private TextBox textBoxTotal;
        private Label labelSubtotal;
        private Label labelDescuento;
        private Label labelImpuestos;
        private Label labelTotal;
        private Button buttonAgregarProductos;
        private Button buttonEliminarProducto;
        private Button buttonGuardarFactura;
        private Button buttonImprimir;
        private Label labelProducto;
        private ComboBox comboBoxProductos;
        private NumericUpDown numericUpDownCantidad;
        private Label labelCantidad;
    }
}