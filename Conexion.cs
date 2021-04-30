using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //la libreria de MySql
using System.Data;  //la libreria del DataTable

namespace EjemploTabs_2021
{
    class Conexion
    {
        public MySqlConnection conexion; //variable que se encarga de conectarnos al servidor MySql

        public Conexion() { //el constructor de la clase
            conexion = new MySqlConnection("Server=127.0.0.1; Database= veterinario; Uid=root; Pwd=; Port=3306 ");
        }

        public Boolean loginInicial(String _DNI, String _password) {
            try {
                conexion.Open();
                
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM dueño WHERE DNI=@_DNI AND Contraseña=@_password", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_password", _password);

                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                if (resultado.Read())
                {
                    conexion.Close();
                    //si entra aquí es porque sí que estan bien el usuario y la contraseña
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e) {
                throw e;
            }

        }
        public Boolean loginVeterinario(String _DNI, String _Contraseña)
        {
            try
            {
                conexion.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM doctores WHERE DNI=@_DNI AND Contraseña=@_password", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_password", _Contraseña);

                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                if (resultado.Read())
                {
                    conexion.Close();
                    //si entra aquí es porque sí que estan bien el usuario y la contraseña
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }

        public Boolean insertausuario(String _Apellidos, String _Contraseña, String _DNI, String _Nombre, String _Num_Cuenta, String _Telefono)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO dueño (Apellidos, Contraseña ,DNI , Nombre, Num_Cuenta, Telefono)  VALUES (@_Apellidos, @_Contraseña, @_DNI,@_Nombre, @_Num_Cuenta, @_Telefono)", conexion);
                

                consulta.Parameters.AddWithValue("@_Apellidos", _Apellidos);
                consulta.Parameters.AddWithValue("@_Contraseña", _Contraseña);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta.Parameters.AddWithValue("@_Num_Cuenta", _Num_Cuenta);
                consulta.Parameters.AddWithValue("@_Telefono", _Telefono);

                int resultado = consulta.ExecuteNonQuery(); //Ejecuta el insert
                if (resultado > 0)
                {
                    conexion.Close();
                    //si entra aquí es porque ha hecho bien la inserción
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
                throw e;
            }

        }


    }
}
