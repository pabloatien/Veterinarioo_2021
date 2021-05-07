
namespace EjemploTabs_2021
{
    partial class AltaMascotas
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
            this.nombreMascota = new System.Windows.Forms.Label();
            this.textNombreMAS = new System.Windows.Forms.TextBox();
            this.textBoxChip = new System.Windows.Forms.TextBox();
            this.chipMascota = new System.Windows.Forms.Label();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.razaMascota = new System.Windows.Forms.Label();
            this.textBoxEspecie = new System.Windows.Forms.TextBox();
            this.especieMascota = new System.Windows.Forms.Label();
            this.textBoxDNIDueño = new System.Windows.Forms.TextBox();
            this.DNIDueño = new System.Windows.Forms.Label();
            this.Insertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreMascota
            // 
            this.nombreMascota.Location = new System.Drawing.Point(12, 33);
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Size = new System.Drawing.Size(109, 37);
            this.nombreMascota.TabIndex = 0;
            this.nombreMascota.Text = "Nombre";
            this.nombreMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNombreMAS
            // 
            this.textNombreMAS.Location = new System.Drawing.Point(142, 42);
            this.textNombreMAS.Name = "textNombreMAS";
            this.textNombreMAS.Size = new System.Drawing.Size(331, 20);
            this.textNombreMAS.TabIndex = 1;
            // 
            // textBoxChip
            // 
            this.textBoxChip.Location = new System.Drawing.Point(142, 131);
            this.textBoxChip.Name = "textBoxChip";
            this.textBoxChip.Size = new System.Drawing.Size(331, 20);
            this.textBoxChip.TabIndex = 3;
            // 
            // chipMascota
            // 
            this.chipMascota.Location = new System.Drawing.Point(12, 122);
            this.chipMascota.Name = "chipMascota";
            this.chipMascota.Size = new System.Drawing.Size(109, 37);
            this.chipMascota.TabIndex = 2;
            this.chipMascota.Text = "Chip";
            this.chipMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(142, 353);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(331, 20);
            this.textBoxRaza.TabIndex = 7;
            // 
            // razaMascota
            // 
            this.razaMascota.Location = new System.Drawing.Point(12, 344);
            this.razaMascota.Name = "razaMascota";
            this.razaMascota.Size = new System.Drawing.Size(109, 37);
            this.razaMascota.TabIndex = 6;
            this.razaMascota.Text = "Raza";
            this.razaMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEspecie
            // 
            this.textBoxEspecie.Location = new System.Drawing.Point(142, 245);
            this.textBoxEspecie.Name = "textBoxEspecie";
            this.textBoxEspecie.Size = new System.Drawing.Size(331, 20);
            this.textBoxEspecie.TabIndex = 5;
            // 
            // especieMascota
            // 
            this.especieMascota.Location = new System.Drawing.Point(12, 236);
            this.especieMascota.Name = "especieMascota";
            this.especieMascota.Size = new System.Drawing.Size(109, 37);
            this.especieMascota.TabIndex = 4;
            this.especieMascota.Text = "Especie";
            this.especieMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDNIDueño
            // 
            this.textBoxDNIDueño.Location = new System.Drawing.Point(142, 470);
            this.textBoxDNIDueño.Name = "textBoxDNIDueño";
            this.textBoxDNIDueño.Size = new System.Drawing.Size(331, 20);
            this.textBoxDNIDueño.TabIndex = 9;
            // 
            // DNIDueño
            // 
            this.DNIDueño.Location = new System.Drawing.Point(12, 461);
            this.DNIDueño.Name = "DNIDueño";
            this.DNIDueño.Size = new System.Drawing.Size(109, 37);
            this.DNIDueño.TabIndex = 8;
            this.DNIDueño.Text = "DNI Dueño";
            this.DNIDueño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Insertar
            // 
            this.Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertar.Location = new System.Drawing.Point(606, 122);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(198, 251);
            this.Insertar.TabIndex = 10;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // AltaMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 571);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.textBoxDNIDueño);
            this.Controls.Add(this.DNIDueño);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.razaMascota);
            this.Controls.Add(this.textBoxEspecie);
            this.Controls.Add(this.especieMascota);
            this.Controls.Add(this.textBoxChip);
            this.Controls.Add(this.chipMascota);
            this.Controls.Add(this.textNombreMAS);
            this.Controls.Add(this.nombreMascota);
            this.Name = "AltaMascotas";
            this.Text = "AltaMAscotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreMascota;
        private System.Windows.Forms.TextBox textNombreMAS;
        private System.Windows.Forms.TextBox textBoxChip;
        private System.Windows.Forms.Label chipMascota;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.Label razaMascota;
        private System.Windows.Forms.TextBox textBoxEspecie;
        private System.Windows.Forms.Label especieMascota;
        private System.Windows.Forms.TextBox textBoxDNIDueño;
        private System.Windows.Forms.Label DNIDueño;
        private System.Windows.Forms.Button Insertar;
    }
}