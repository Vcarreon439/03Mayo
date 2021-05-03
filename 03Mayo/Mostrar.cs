using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _03Mayo
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-185RN13\\SQLEXPRESS; database=Datos1; integrated security = true");

            try
            {
                conexion.Open();
                string cadena = "select codigo, descripcion,precio from articulos";
                SqlCommand comando = new SqlCommand(cadena, conexion);
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

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
