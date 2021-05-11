using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03Mayo
{
    public partial class Actualizar : Form
    {
        ConexionSQL interno;

        public Actualizar()
        {
            InitializeComponent();
        }
        
        public Actualizar(ConexionSQL conexionSQL)
        {
            InitializeComponent();
            interno = conexionSQL;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                rTxtBxDescripcion.Text = "";
                txtPrecio.Text = "";

                interno.AbrirConexion();
                string cod = txtCodigo.Text;
                string comand = "select descripcion, precio from articulos where codigo=" + cod;
                SqlCommand command = new SqlCommand(comand, interno.Conexion);
                SqlDataReader registro = command.ExecuteReader();


                if (registro.Read())
                {
                    rTxtBxDescripcion.Text = registro["descripcion"].ToString();
                    txtPrecio.Text = "$" + registro["precio"].ToString();
                }
                else
                {
                    MessageBox.Show("Elemento no encontrado");
                }

                interno.CerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                interno.CerrarConexion();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                interno.AbrirConexion();
                string cadena = $"update articulos set descripcion='{rTxtBxDescripcion.Text}', precio={txtPrecio.Text} where codigo={txtCodigo.Text}";
                SqlCommand comando = new SqlCommand(cadena, interno.Conexion);

                if (comando.ExecuteNonQuery()!=0)
                    MessageBox.Show("El cambio ha sido realizado exitosamente");
                else
                    MessageBox.Show("Error: No se realizo ningun cambio");

                txtCodigo.Text = "";
                rTxtBxDescripcion.Text = "";
                txtPrecio.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }

            interno.CerrarConexion();
        }
    }
}
