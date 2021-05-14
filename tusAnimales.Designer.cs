
namespace EjemploTabs_2021
{
    partial class tusAnimales
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.raza = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.nombreAmo = new System.Windows.Forms.Label();
            this.nombreMascota = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botonMascota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EjemploTabs_2021.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1041, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // raza
            // 
            this.raza.BackColor = System.Drawing.Color.Lime;
            this.raza.Location = new System.Drawing.Point(795, 351);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(190, 37);
            this.raza.TabIndex = 20;
            this.raza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Lime;
            this.especie.Location = new System.Drawing.Point(795, 178);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(190, 37);
            this.especie.TabIndex = 19;
            this.especie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreAmo
            // 
            this.nombreAmo.BackColor = System.Drawing.Color.Lime;
            this.nombreAmo.Location = new System.Drawing.Point(795, 295);
            this.nombreAmo.Name = "nombreAmo";
            this.nombreAmo.Size = new System.Drawing.Size(190, 37);
            this.nombreAmo.TabIndex = 18;
            this.nombreAmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreMascota
            // 
            this.nombreMascota.BackColor = System.Drawing.Color.Lime;
            this.nombreMascota.Location = new System.Drawing.Point(795, 237);
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Size = new System.Drawing.Size(190, 37);
            this.nombreMascota.TabIndex = 17;
            this.nombreMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(783, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 237);
            this.label17.TabIndex = 16;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(291, 273);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 22);
            this.textBox6.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Chip de la mascota";
            // 
            // botonMascota
            // 
            this.botonMascota.BackColor = System.Drawing.Color.Transparent;
            this.botonMascota.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMascota.Location = new System.Drawing.Point(500, 245);
            this.botonMascota.Name = "botonMascota";
            this.botonMascota.Size = new System.Drawing.Size(238, 68);
            this.botonMascota.TabIndex = 13;
            this.botonMascota.Text = "Buscar mascota";
            this.botonMascota.UseVisualStyleBackColor = false;
            this.botonMascota.Click += new System.EventHandler(this.botonMascota_Click);
            // 
            // tusAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.raza);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.nombreAmo);
            this.Controls.Add(this.nombreMascota);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.botonMascota);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tusAnimales";
            this.Text = "tusAnimales";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label raza;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label nombreAmo;
        private System.Windows.Forms.Label nombreMascota;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonMascota;
    }
}