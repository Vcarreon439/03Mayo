using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _03Mayo
{
    public partial class Mostrar : Form
    {
        ConexionSQL interno;

        public Mostrar(ConexionSQL obj)
        {
            InitializeComponent();
            interno = obj;
        }
        
        public Mostrar()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                interno.AbrirConexion();
                string cadena = "select codigo, descripcion,precio from articulos";
                SqlCommand comando = new SqlCommand(cadena, interno.Conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    txtMostrar.AppendText(registros["codigo"].ToString());
                    txtMostrar.AppendText(" - ");
                    txtMostrar.AppendText(registros["descripcion"].ToString());
                    txtMostrar.AppendText(" - ");
                    txtMostrar.AppendText(registros["precio"].ToString());
                    txtMostrar.AppendText(" - ");
                }

                interno.Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
