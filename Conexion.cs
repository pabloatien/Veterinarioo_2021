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

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM dueño WHERE DNI=@_DNI ", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_password", _password);

                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                if (resultado.Read())
                {
                    String passwordConHash = resultado.GetString("Contraseña");
                    //if (BCrypt.Net.BCrypt.Verify(_password, passwordConHash))
                    {
                        conexion.Close();
                        //si entra aquí es porque sí que estan bien el usuario y la contraseña
                        return true;
                    }
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
        public Boolean insertaMascota(String _Chip, String _Nombre, String _Especie, String _Raza, String _DNI_Dueño)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta2 = new MySqlCommand ("INSERT INTO paciente (Chip, Nombre, Especie,Raza, DNI_Dueño )VALUES(@_Chip,@_Nombre,@_Especie,@_Raza,@_DNI_Dueño)", conexion);


                consulta2.Parameters.AddWithValue("@_Chip", _Chip);
                consulta2.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta2.Parameters.AddWithValue("@_Especie", _Especie);
                consulta2.Parameters.AddWithValue("@_Raza", _Raza);
                consulta2.Parameters.AddWithValue("@_DNI_Dueño", _DNI_Dueño);


                int resultado = consulta2.ExecuteNonQuery(); //Ejecuta el insert
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
        public Boolean ingresoMascota(String _Cod_Ingreso, String _Descripcion, String _Enfermedad, String _Vacunas, String _Esterilizado,  String _Coste,  String _ChipAnimal , String _Fecha )
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta3 = new MySqlCommand("INSERT INTO ingreso (Cod_Ingreso, Descripcion, Enfermedad ,Vacunas, Esterilizado, Coste_Ingreso, Chip, Fecha )VALUES(@_Cod_Ingreso, @_Descripcion, @_Enfermedad ,@_Vacunas, @_Esterilizado, @_Coste_Ingreso, @_Chip, @_Fecha)", conexion);


                consulta3.Parameters.AddWithValue("@_Cod_Ingreso", _Cod_Ingreso);
                consulta3.Parameters.AddWithValue("@_Descripcion", _Descripcion);
                consulta3.Parameters.AddWithValue("@_Enfermedad", _Enfermedad);
                consulta3.Parameters.AddWithValue("@_Vacunas", _Vacunas);
                consulta3.Parameters.AddWithValue("@_Esterilizado", _Esterilizado);
                consulta3.Parameters.AddWithValue("@_Coste", _Coste);
                consulta3.Parameters.AddWithValue("@_ChipAnimal", _ChipAnimal);
                consulta3.Parameters.AddWithValue("@_Fecha", _Fecha);


                int resultado = consulta3.ExecuteNonQuery(); //Ejecuta el insert
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
