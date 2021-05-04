using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _03Mayo
{
    public partial class frmPrincipal : Form
    {
        ConexionSQL obj = new ConexionSQL("server=DESKTOP-185RN13\\SQLEXPRESS; database=Datos1; integrated security = true");

        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.AbrirConexion();
                string descripcion = txtDescripcion.Text;
                string precio = txtPrecio.Text;
                SqlCommand insercion = new SqlCommand($"insert into articulos(descripcion, precio) values('{descripcion}',{ precio})", obj.Conexion);
                insercion.ExecuteNonQuery();
                obj.CerrarConexion();
                txtDescripcion.Text = "";
                txtPrecio.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (obj.Conexion.State!=ConnectionState.Closed)
                obj.CerrarConexion();

            frmMostrar forma = new frmMostrar(obj);
            forma.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            if (obj.Conexion.State != ConnectionState.Closed)
                obj.CerrarConexion();

            frmConsultas forma = new frmConsultas(obj);
            forma.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (obj.Conexion.State != ConnectionState.Closed)
                obj.CerrarConexion();

            frmBajas forma = new frmBajas(obj);
            forma.ShowDialog();
        }
    }
}
