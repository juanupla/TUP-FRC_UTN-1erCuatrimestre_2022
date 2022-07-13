using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsA4_13ConBd
{
    internal class accesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string cadenaconexion;



        public accesoDatos()
        {
            cadenaconexion = @"Data Source=localhost;Initial Catalog=TUPPI;Integrated Security=True";
            conexion = new SqlConnection(cadenaconexion);
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

        public DataTable consultarBd(string consultaSql)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = consultaSql;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public int actualizarBd(string insertOUpdate)
        {
            int filasAfectadas;
            conectar();
            comando.CommandText = insertOUpdate;
            filasAfectadas = comando.ExecuteNonQuery();
            desconectar();
            return filasAfectadas;
        }
    }
}
