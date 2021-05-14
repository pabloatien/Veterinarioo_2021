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
        Conexion miConexion = new Conexion(); //esta variable es del tipo que hemos creado para conectarnos a la BBDD MySql
        String _Chip = "";
        String _DNI = "";

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

            String Fecha = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            


            Boolean resultado = miConexion.ingresoMascota(textBoxCod_Ingreso.Text, Fecha, textBoxDescripcion.Text, textBoxEnfermedad.Text, textBoxVacunas.Text, textBoxEsterilizado.Text, textBoxCoste.Text, textBoxChip.Text);
            if (resultado)
            {
                MessageBox.Show("INSERTADO CORRECTAMENTE");
            }
            else
            {
                //MessageBox.Show("Ha ocurrido un error inesperado y no se ha podido insertar. Pruebe mas tarde");
                MessageBox.Show(" " + Fecha);
            }
        }



        private void tabPage3_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            AltaVeterinario ventana = new AltaVeterinario();
            ventana.Show();
        }

            private void button2_Click(object sender, EventArgs e)
        {
            _Chip = "" + textBox6.Text;
            DataTable misMascotas = miConexion.cogerMascota(_Chip);
            misMascotas = miConexion.cogerMascota(_Chip);
            nombreMascota.Text = misMascotas.Rows[0]["Nombre"].ToString();
            nombreAmo.Text = misMascotas.Rows[0]["Amo"].ToString();
            especie.Text = misMascotas.Rows[0]["Especie"].ToString();
            raza.Text = misMascotas.Rows[0]["Raza"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _DNI = "" + textBox7.Text;
            DataTable misClientes = miConexion.cogerNombre(_DNI);
            misClientes = miConexion.cogerNombre(_DNI);
            nombreDueño.Text = misClientes.Rows[0]["Nombre"].ToString();
            telefonoDueño.Text = misClientes.Rows[0]["Telefono"].ToString();
        }
    }
}

