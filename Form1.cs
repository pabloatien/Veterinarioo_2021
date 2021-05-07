using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploTabs_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaUsuario ventana = new AltaUsuario();
            ventana.Show();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();  //cierra la aplicación
        }

        private void mascotaNueva_Click(object sender, EventArgs e)
        {
            AltaMascotas ventana = new AltaMascotas();
            ventana.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Conexion miConexion = new Conexion();
            String fecha = dateTimePicker2.Text;
            String Vacunas = "";
            String Esterilizado = "";

            if (checkBoxVacunas.ThreeState)
            {

                checkBoxVacunas.ThreeState = true;
                Vacunas = "Si";
            }
            else
            {
                Vacunas = "No";
            }
            if (checkBoxEsterilizado.ThreeState)
            {

                checkBoxEsterilizado.ThreeState = true;
                Esterilizado = "Si";
            }
            else
            {
                Esterilizado = "No";
            }
          


            Boolean resultado = miConexion.ingresoMascota(textBoxCod_Ingreso.Text, textBoxDescripcion.Text, textBoxEnfermedad.Text, Vacunas, Esterilizado, textBoxCoste.Text, textBoxChip.Text, fecha);
            if (resultado)
            {
                MessageBox.Show("INSERTADO CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado y no se ha podido insertar. Pruebe mas tarde");
            }
        }
    }
}

