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
        public Boolean insertaMascota(String _Chip, String _Nombre, String _Especie, String _Raza, String _Amo)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta2 = new MySqlCommand ("INSERT INTO paciente (Chip, Nombre, Especie,Raza, Amo )VALUES(@_Chip,@_Nombre,@_Especie,@_Raza,@_Amo)", conexion);

                consulta2.Parameters.AddWithValue("@_Chip", _Chip);
                consulta2.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta2.Parameters.AddWithValue("@_Especie", _Especie);
                consulta2.Parameters.AddWithValue("@_Raza", _Raza);
                consulta2.Parameters.AddWithValue("@_Amo", _Amo);


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


        public Boolean insertaVeterinario(String  _DNI , String _Nombre, String _Apellidos, String _Especialidad, String _Pacientes, String  _Contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO doctores (DNI , Nombre ,Apellidos , Especialidad, Pacientes,Contraseña)  VALUES (@_DNI , @_Nombre ,@_Apellidos , @_Especialidad, @_Pacientes,@_Contraseña)", conexion);

                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta.Parameters.AddWithValue("@_Apellidos", _Apellidos);
                consulta.Parameters.AddWithValue("@_Especialidad", _Especialidad);
                consulta.Parameters.AddWithValue("@_Pacientes", _Pacientes);
                consulta.Parameters.AddWithValue("@_Contraseña", _Contraseña);

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


        public Boolean ingresoMascota(String _Cod_Ingreso, String _Fecha, String _Descripcion, String _Enfermedad, String _Vacunas, String _Esterilizado, String _Coste_Ingreso, String _Chip  )
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO ingreso (Cod_Ingreso, Descripcion, Enfermedad , Coste_Ingreso, Fecha, Chip, Vacunas, Esterilizado)VALUES(@_Cod_Ingreso, @_Descripcion, @_Enfermedad , @_Coste_Ingreso, @_Fecha, @_Chip, @_Vacunas, @_Esterilizado)", conexion);


                consulta.Parameters.AddWithValue("@_Cod_Ingreso", _Cod_Ingreso);
                consulta.Parameters.AddWithValue("@_Descripcion", _Descripcion);
                consulta.Parameters.AddWithValue("@_Enfermedad", _Enfermedad);
                consulta.Parameters.AddWithValue("@_Coste_Ingreso", _Coste_Ingreso);
                consulta.Parameters.AddWithValue("@_Fecha", _Fecha);
                consulta.Parameters.AddWithValue("@_Chip", _Chip);
                consulta.Parameters.AddWithValue("@_Vacunas", _Vacunas);
                consulta.Parameters.AddWithValue("@_Esterilizado", _Esterilizado);


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




        

        public DataTable cogerMascota(String _Chip)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM paciente WHERE Chip='" + _Chip + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la consulta (Query)
                DataTable veterinario = new DataTable(); //formato que espera el datagridview
                veterinario.Load(resultado); //Convierte MySqlDataReader en DataTable
                conexion.Close();
                return veterinario;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


        public DataTable cogerNombre(String _DNI)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM dueño WHERE DNI='" + _DNI + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la consulta (Query)
                DataTable veterinario = new DataTable(); //formato que espera el datagridview
                veterinario.Load(resultado); //Convierte MySqlDataReader en DataTable
                conexion.Close();
                return veterinario;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


    }

}
