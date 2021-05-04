using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _03Mayo
{
    public partial class frmPrincipal : Form
    {
        ConexionSQL obj;

        public frmPrincipal()
        {
            InitializeComponent();
            obj = new ConexionSQL($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("./Datos1.mdf")};Integrated Security = True");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.AbrirConexion();
                string descripcion = txtDescripcion.Text;
                string precio = txtPrecio.Text;
                SqlCommand insercion = new SqlCommand($"insert into articulos(descripcion, precio) values('{descripcion}',{precio})", obj.Conexion);
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
