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
            this.Hide();
            Form1 ventana = new Form1();
            ventana.Show();

            //string dni = usuario.text; //leo lo que el usuario ha escrito en las cajas
            //string password = pass.text;
            //if (miconexion.logininicial(dni, password))
            //{
            //    this.hide();
            //    form1 ventana = new form1();
            //    ventana.show();

            //}
            //else {  //o la contraseña o el usuario son incorrectos
            //    messagebox.show("el usuario o la contraseña son incorrectos");
            //}
        }
    }
}
