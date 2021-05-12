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
    public partial class AltaVeterinario : Form
    {
        public AltaVeterinario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String passhasheada = BCrypt.Net.BCrypt.HashPassword(textBoxContraseñaVet.Text, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(textBoxContraseñaVet.Text + "  " + passhasheada);
            Conexion miConexion = new Conexion();
            Boolean resultado = miConexion.insertaVeterinario(textBoxDNIVet.Text, textBoxNombreVet.Text, textBoxApellidosVet.Text,  textBoxEspecialidad.Text,  textBoxPacientes.Text, passhasheada);
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
