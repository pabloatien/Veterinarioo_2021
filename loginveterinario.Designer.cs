
namespace EjemploTabs_2021
{
    partial class loginveterinario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Comprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(119, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ususario veterinario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(119, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(103, 123);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(199, 20);
            this.usuario.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(103, 282);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(199, 20);
            this.pass.TabIndex = 3;
            // 
            // Comprobar
            // 
            this.Comprobar.Location = new System.Drawing.Point(122, 376);
            this.Comprobar.Name = "Comprobar";
            this.Comprobar.Size = new System.Drawing.Size(147, 80);
            this.Comprobar.TabIndex = 4;
            this.Comprobar.Text = "¡ENTRA!";
            this.Comprobar.UseVisualStyleBackColor = true;
            this.Comprobar.Click += new System.EventHandler(this.Comprobar_Click);
            // 
            // loginveterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 595);
            this.Controls.Add(this.Comprobar);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginveterinario";
            this.Text = "loginveterinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button Comprobar;
    }
}