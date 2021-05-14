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
    public partial class tusAnimales : Form
    {
        Conexion miConexion = new Conexion(); //esta variable es del tipo que hemos creado para conectarnos a la BBDD MySql
        String _Chip = "";
        


        public tusAnimales()
        {
            InitializeComponent();
            //label2.Text = 
        }

        private void botonMascota_Click(object sender, EventArgs e)
        {
            _Chip = "" + textBox6.Text;
            DataTable misMascotas = miConexion.cogerMascota(_Chip);
            misMascotas = miConexion.cogerMascota(_Chip);
            nombreMascota.Text = misMascotas.Rows[0]["Nombre"].ToString();
            nombreAmo.Text = misMascotas.Rows[0]["Amo"].ToString();
            especie.Text = misMascotas.Rows[0]["Especie"].ToString();
            raza.Text = misMascotas.Rows[0]["Raza"].ToString();
        }
    }
}
