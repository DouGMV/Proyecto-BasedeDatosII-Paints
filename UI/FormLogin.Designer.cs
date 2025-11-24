namespace UI
{
    partial class FormLogin
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
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            buttonLogin = new Button();
            labelMensaje = new Label();
            labelUsuario = new Label();
            labelContrasena = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(150, 62);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(125, 27);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(150, 127);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PasswordChar = '*';
            textBoxContrasena.Size = new Size(125, 27);
            textBoxContrasena.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(163, 187);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.Location = new Point(179, 270);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(64, 20);
            labelMensaje.TabIndex = 3;
            labelMensaje.Text = "Mensaje";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(42, 65);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(62, 20);
            labelUsuario.TabIndex = 4;
            labelUsuario.Text = "Usuario:";
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Location = new Point(42, 134);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(86, 20);
            labelContrasena.TabIndex = 5;
            labelContrasena.Text = "Contraseña:";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 324);
            Controls.Add(labelContrasena);
            Controls.Add(labelUsuario);
            Controls.Add(labelMensaje);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxUsuario);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private Button buttonLogin;
        private Label labelMensaje;
        private Label labelUsuario;
        private Label labelContrasena;
    }
}