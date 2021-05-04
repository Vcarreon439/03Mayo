using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03Mayo
{
    public partial class frmConsultas : Form
    {
        ConexionSQL interno;

        public frmConsultas()
        {
            InitializeComponent();
        }
        
        
        public frmConsultas(ConexionSQL externo)
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
                    lblPrecio2.Text = "$" + registro["precio"].ToString();
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
    }
}
