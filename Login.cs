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
    public partial class Login : Form
    {
        Conexion miConexion = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            String DNI = usuario.Text; //leo lo que el usuario ha escrito en las cajas
            String password = pass.Text;
            if (miConexion.loginInicial(DNI, password))
            {
                this.Hide();
                Form1 ventana = new Form1();
                ventana.Show();
                
            }
            else {  //o la contraseña o el usuario son incorrectos
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS");
            }
        }
    }
}
