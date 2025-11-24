namespace UI
{
    partial class FormAnulacionFactura
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
            textBoxNumeroFactura = new TextBox();
            buttonBuscar = new Button();
            buttonAnular = new Button();
            labelInfo = new Label();
            labelNumeroFactura = new Label();
            SuspendLayout();
            // 
            // textBoxNumeroFactura
            // 
            textBoxNumeroFactura.Location = new Point(41, 89);
            textBoxNumeroFactura.Name = "textBoxNumeroFactura";
            textBoxNumeroFactura.Size = new Size(155, 27);
            textBoxNumeroFactura.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(64, 134);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAnular
            // 
            buttonAnular.Location = new Point(64, 190);
            buttonAnular.Name = "buttonAnular";
            buttonAnular.Size = new Size(94, 29);
            buttonAnular.TabIndex = 2;
            buttonAnular.Text = "Anular";
            buttonAnular.UseVisualStyleBackColor = true;
            buttonAnular.Click += buttonAnular_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(276, 48);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(89, 20);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "Informacion";
            // 
            // labelNumeroFactura
            // 
            labelNumeroFactura.AutoSize = true;
            labelNumeroFactura.Location = new Point(64, 48);
            labelNumeroFactura.Name = "labelNumeroFactura";
            labelNumeroFactura.Size = new Size(114, 20);
            labelNumeroFactura.TabIndex = 4;
            labelNumeroFactura.Text = "Numero Factura";
            // 
            // FormAnulacionFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 279);
            Controls.Add(labelNumeroFactura);
            Controls.Add(labelInfo);
            Controls.Add(buttonAnular);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxNumeroFactura);
            Name = "FormAnulacionFactura";
            Text = "FormAnulacionFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumeroFactura;
        private Button buttonBuscar;
        private Button buttonAnular;
        private Label labelInfo;
        private Label labelNumeroFactura;
    }
}