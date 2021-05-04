using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03Mayo
{
    public partial class frmBajas : Form
    {
        ConexionSQL interno;
        public frmBajas()
        {
            InitializeComponent();
        }
        public frmBajas(ConexionSQL externo)
        {
            InitializeComponent();
            interno = externo;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                rTxtBxDescripcion.Text = "";
                lblPrecio2.Text = "";

                interno.AbrirConexion();
                string cod = txtCodigo.Text;
                string comand = "select descripcion, precio from articulos where codigo=" + cod;
                SqlCommand command = new SqlCommand(comand, interno.Conexion);
                SqlDataReader registro = command.ExecuteReader();


                if (registro.Read())
                {
                    rTxtBxDescripcion.Text = registro["descripcion"].ToString();
                    lblPrecio2.Text = "$"+registro["precio"].ToString();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                interno.AbrirConexion();
                string cod = txtCodigo.Text;
                string cadena = "delete from articulos where codigo=" + cod;
                SqlCommand command = new SqlCommand(cadena, interno.Conexion);
                int cant = command.ExecuteNonQuery();
                
                if (cant!=0)
                {
                    MessageBox.Show("Elemento borrado");
                    lblPrecio2.Text = "";
                    lblDescripcion.Text = "";
                }
                else
                {
                    MessageBox.Show("Elemento inexistente");
                }

                interno.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                interno.CerrarConexion();
            }
        }
    }
}
