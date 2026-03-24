using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ListaAsistencia.Clases
{
    internal class Datos
    {
        string cadenaConexion = "server=localhost;user=luis;pwd=joseluis;Database=asistencia;port=3307";
        MySqlConnection conexion;

        private void Conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Desconectar()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DataSet ejecutar(string comando)
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool ejecutarComando(String comando)
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
