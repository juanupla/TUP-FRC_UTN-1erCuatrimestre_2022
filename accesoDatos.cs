using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace parcial2App2
{
    internal class accesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string cadenaconexion;

        public accesoDatos()
        {
            cadenaconexion = @"Data Source=localhost;Initial Catalog=Vivero;Integrated Security=True";
            conexion = new SqlConnection(cadenaconexion);
            comando = new SqlCommand();

        }

        public void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            
        }

        public void desconectar()
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
