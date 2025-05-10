namespace Capa_Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            txt_contrasena = new TextBox();
            txt_usuario = new TextBox();
            lbl_usuario = new Label();
            lbl_contrasena = new Label();
            SuspendLayout();
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(210, 299);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(94, 29);
            btn_aceptar.TabIndex = 0;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(463, 299);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txt_contrasena
            // 
            txt_contrasena.Location = new Point(432, 204);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(125, 27);
            txt_contrasena.TabIndex = 2;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(432, 150);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(125, 27);
            txt_usuario.TabIndex = 3;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(357, 150);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(59, 20);
            lbl_usuario.TabIndex = 4;
            lbl_usuario.Text = "Usuario";
            lbl_usuario.Click += label1_Click;
            // 
            // lbl_contrasena
            // 
            lbl_contrasena.AutoSize = true;
            lbl_contrasena.Location = new Point(357, 211);
            lbl_contrasena.Name = "lbl_contrasena";
            lbl_contrasena.Size = new Size(83, 20);
            lbl_contrasena.TabIndex = 5;
            lbl_contrasena.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_contrasena);
            Controls.Add(lbl_usuario);
            Controls.Add(txt_usuario);
            Controls.Add(txt_contrasena);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_aceptar;
        private Button btn_cancelar;
        private TextBox txt_contrasena;
        private TextBox txt_usuario;
        private Label lbl_usuario;
        private Label lbl_contrasena;
    }
}
