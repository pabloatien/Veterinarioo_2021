﻿namespace EjemploTabs_2021
{
    partial class Login
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
            this.botonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonLogin
            // 
            this.botonLogin.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.botonLogin.Location = new System.Drawing.Point(12, 406);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(303, 48);
            this.botonLogin.TabIndex = 0;
            this.botonLogin.Text = "ENTRAR";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(108, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(12, 92);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(303, 26);
            this.usuario.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(12, 194);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '•';
            this.pass.Size = new System.Drawing.Size(303, 26);
            this.pass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(87, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(327, 498);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonLogin);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
    }
}