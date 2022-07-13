using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace formsTelefoicaApp
{
    internal class accesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string cadenadeconexion;

        public accesoDatos()
        {
            cadenadeconexion = @"Data Source=localhost;Initial Catalog=Telefonica;Integrated Security=True";
            conexion = new SqlConnection(cadenadeconexion);
            comando = new SqlCommand();
        }
        private void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

        }
        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable consultarBD(string cadena)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = cadena;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;

        }

        public int actualizarBD(string cadena)
        {
            int filasAfectadas;
            conectar();
            comando.CommandText = cadena;
            filasAfectadas = comando.ExecuteNonQuery();
            desconectar();
            return filasAfectadas;
            
        }
    }
}
