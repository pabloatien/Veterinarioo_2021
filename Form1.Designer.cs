namespace EjemploTabs_2021
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mascotaNueva = new System.Windows.Forms.Button();
            this.usuarioNuevo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCod_Ingreso = new System.Windows.Forms.TextBox();
            this.textBoxEnfermedad = new System.Windows.Forms.TextBox();
            this.textBoxChip = new System.Windows.Forms.TextBox();
            this.checkBoxVacunas = new System.Windows.Forms.CheckBox();
            this.checkBoxEsterilizado = new System.Windows.Forms.CheckBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.textBoxCoste = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 582);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mascotaNueva);
            this.tabPage1.Controls.Add(this.usuarioNuevo);
            this.tabPage1.ImageIndex = 13;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pagina 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mascotaNueva
            // 
            this.mascotaNueva.Location = new System.Drawing.Point(8, 135);
            this.mascotaNueva.Name = "mascotaNueva";
            this.mascotaNueva.Size = new System.Drawing.Size(563, 86);
            this.mascotaNueva.TabIndex = 1;
            this.mascotaNueva.Text = "MASCOTA NUEVO";
            this.mascotaNueva.UseVisualStyleBackColor = true;
            this.mascotaNueva.Click += new System.EventHandler(this.mascotaNueva_Click);
            // 
            // usuarioNuevo
            // 
            this.usuarioNuevo.Location = new System.Drawing.Point(8, 43);
            this.usuarioNuevo.Name = "usuarioNuevo";
            this.usuarioNuevo.Size = new System.Drawing.Size(563, 86);
            this.usuarioNuevo.TabIndex = 0;
            this.usuarioNuevo.Text = "USUARIO NUEVO";
            this.usuarioNuevo.UseVisualStyleBackColor = true;
            this.usuarioNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxCoste);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBoxDescripcion);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.checkBoxEsterilizado);
            this.tabPage2.Controls.Add(this.checkBoxVacunas);
            this.tabPage2.Controls.Add(this.textBoxChip);
            this.tabPage2.Controls.Add(this.textBoxEnfermedad);
            this.tabPage2.Controls.Add(this.textBoxCod_Ingreso);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.ImageIndex = 4;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "La otra página";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(25, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enfermedad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de ingreso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EjemploTabs_2021.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.interface_splash_current;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(577, 539);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "el tercero";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(414, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_business.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_dog_leash.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_dog_pooping.ico");
            this.imageList1.Images.SetKeyName(3, "icons8_doggy_bag.ico");
            this.imageList1.Images.SetKeyName(4, "icons8_heart_outline.ico");
            this.imageList1.Images.SetKeyName(5, "icons8_horse.ico");
            this.imageList1.Images.SetKeyName(6, "icons8_maintenance.ico");
            this.imageList1.Images.SetKeyName(7, "icons8_pig.ico");
            this.imageList1.Images.SetKeyName(8, "icons8_pig_1.ico");
            this.imageList1.Images.SetKeyName(9, "icons8_print.ico");
            this.imageList1.Images.SetKeyName(10, "icons8_pug.ico");
            this.imageList1.Images.SetKeyName(11, "icons8_queen_bee.ico");
            this.imageList1.Images.SetKeyName(12, "icons8_sheep.ico");
            this.imageList1.Images.SetKeyName(13, "icons8_shiba_inu.ico");
            this.imageList1.Images.SetKeyName(14, "icons8_sparrowhawk.ico");
            this.imageList1.Images.SetKeyName(15, "icons8_user.ico");
            this.imageList1.Images.SetKeyName(16, "icons8_user_1.ico");
            this.imageList1.Images.SetKeyName(17, "icons8_veterinarian.ico");
            this.imageList1.Images.SetKeyName(18, "icons8_whatsapp.ico");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Location = new System.Drawing.Point(295, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Esterilizado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Location = new System.Drawing.Point(295, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vacunas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Location = new System.Drawing.Point(295, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chip";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.Location = new System.Drawing.Point(25, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Motivo de ingreso";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCod_Ingreso
            // 
            this.textBoxCod_Ingreso.Location = new System.Drawing.Point(130, 45);
            this.textBoxCod_Ingreso.Name = "textBoxCod_Ingreso";
            this.textBoxCod_Ingreso.Size = new System.Drawing.Size(146, 20);
            this.textBoxCod_Ingreso.TabIndex = 8;
            // 
            // textBoxEnfermedad
            // 
            this.textBoxEnfermedad.Location = new System.Drawing.Point(129, 157);
            this.textBoxEnfermedad.Name = "textBoxEnfermedad";
            this.textBoxEnfermedad.Size = new System.Drawing.Size(146, 20);
            this.textBoxEnfermedad.TabIndex = 10;
            // 
            // textBoxChip
            // 
            this.textBoxChip.Location = new System.Drawing.Point(399, 45);
            this.textBoxChip.Name = "textBoxChip";
            this.textBoxChip.Size = new System.Drawing.Size(146, 20);
            this.textBoxChip.TabIndex = 11;
            // 
            // checkBoxVacunas
            // 
            this.checkBoxVacunas.AutoSize = true;
            this.checkBoxVacunas.Location = new System.Drawing.Point(411, 105);
            this.checkBoxVacunas.Name = "checkBoxVacunas";
            this.checkBoxVacunas.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVacunas.TabIndex = 12;
            this.checkBoxVacunas.UseVisualStyleBackColor = true;
            // 
            // checkBoxEsterilizado
            // 
            this.checkBoxEsterilizado.AutoSize = true;
            this.checkBoxEsterilizado.Location = new System.Drawing.Point(411, 162);
            this.checkBoxEsterilizado.Name = "checkBoxEsterilizado";
            this.checkBoxEsterilizado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEsterilizado.TabIndex = 13;
            this.checkBoxEsterilizado.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(130, 99);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(129, 251);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(416, 20);
            this.textBoxDescripcion.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 128);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxCoste
            // 
            this.textBoxCoste.Location = new System.Drawing.Point(129, 208);
            this.textBoxCoste.Name = "textBoxCoste";
            this.textBoxCoste.Size = new System.Drawing.Size(146, 20);
            this.textBoxCoste.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.Location = new System.Drawing.Point(25, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Coste";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 582);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button usuarioNuevo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button mascotaNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxEsterilizado;
        private System.Windows.Forms.CheckBox checkBoxVacunas;
        private System.Windows.Forms.TextBox textBoxChip;
        private System.Windows.Forms.TextBox textBoxEnfermedad;
        private System.Windows.Forms.TextBox textBoxCod_Ingreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCoste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
    }
}

