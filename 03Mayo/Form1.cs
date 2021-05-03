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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-185RN13\\SQLEXPRESS; database=Datos1; integrated security = true");

            try
            {
                conexion.Open();
                string descripcion = txtDescripcion.Text;
                string precio = txtPrecio.Text;
                SqlCommand insercion = new SqlCommand($"insert into articulos(descripcion, precio) values('{descripcion}',{ precio})", conexion);
                insercion.ExecuteNonQuery();
                conexion.Close();
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
            Form obj = new Mostrar();
            obj.ShowDialog();
        }
    }
}
