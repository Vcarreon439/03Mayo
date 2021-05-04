using System;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace _03Mayo
{
    public class ConexionSQL
    {
        private SqlConnection conexion;
        public SqlConnection Conexion { get => conexion; set => conexion = value; }

        public ConexionSQL(string cadCon) 
        {
            conexion = new SqlConnection(cadCon);
        }

        public void AbrirConexion() 
        {
            conexion.Open();
        }
        
        public void CerrarConexion() 
        {
            conexion.Close();
        }



    }
}
