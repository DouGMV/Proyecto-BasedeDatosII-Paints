namespace UI
{
    partial class FormReportes
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
            comboBoxTipoReporte = new ComboBox();
            labelFechaInicio = new Label();
            dateTimePickerInicio = new DateTimePicker();
            labelFechaFin = new Label();
            dateTimePickerFin = new DateTimePicker();
            buttonBuscar = new Button();
            dataGridViewReportes = new DataGridView();
            labelTipoReporte = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTipoReporte
            // 
            comboBoxTipoReporte.FormattingEnabled = true;
            comboBoxTipoReporte.Location = new Point(142, 45);
            comboBoxTipoReporte.Name = "comboBoxTipoReporte";
            comboBoxTipoReporte.Size = new Size(289, 28);
            comboBoxTipoReporte.TabIndex = 0;
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Location = new Point(29, 108);
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(90, 20);
            labelFechaInicio.TabIndex = 1;
            labelFechaInicio.Text = "Fecha inicio:";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(142, 101);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(289, 27);
            dateTimePickerInicio.TabIndex = 2;
            // 
            // labelFechaFin
            // 
            labelFechaFin.AutoSize = true;
            labelFechaFin.Location = new Point(29, 154);
            labelFechaFin.Name = "labelFechaFin";
            labelFechaFin.Size = new Size(71, 20);
            labelFechaFin.TabIndex = 3;
            labelFechaFin.Text = "Fecha fin:";
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(142, 154);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(289, 27);
            dateTimePickerFin.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(236, 215);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridViewReportes
            // 
            dataGridViewReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReportes.Location = new Point(456, 45);
            dataGridViewReportes.Name = "dataGridViewReportes";
            dataGridViewReportes.RowHeadersWidth = 51;
            dataGridViewReportes.Size = new Size(426, 224);
            dataGridViewReportes.TabIndex = 6;
            // 
            // labelTipoReporte
            // 
            labelTipoReporte.AutoSize = true;
            labelTipoReporte.Location = new Point(29, 53);
            labelTipoReporte.Name = "labelTipoReporte";
            labelTipoReporte.Size = new Size(99, 20);
            labelTipoReporte.TabIndex = 7;
            labelTipoReporte.Text = "Tipo Reporte:";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 299);
            Controls.Add(labelTipoReporte);
            Controls.Add(dataGridViewReportes);
            Controls.Add(buttonBuscar);
            Controls.Add(dateTimePickerFin);
            Controls.Add(labelFechaFin);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(labelFechaInicio);
            Controls.Add(comboBoxTipoReporte);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipoReporte;
        private Label labelFechaInicio;
        private DateTimePicker dateTimePickerInicio;
        private Label labelFechaFin;
        private DateTimePicker dateTimePickerFin;
        private Button buttonBuscar;
        private DataGridView dataGridViewReportes;
        private Label labelTipoReporte;
    }
}