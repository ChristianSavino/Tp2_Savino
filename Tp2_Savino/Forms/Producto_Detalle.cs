using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp2_Savino.Clases;

namespace Tp2_Savino
{
    public partial class Producto_Detalle : Form
    {
        public Producto_Detalle()
        {
            InitializeComponent();
        }

        public void SetearDatos(Producto prod)
        {
            txtCod.Text += " " + prod.codigo;
            txtName.Text += " " + prod.nombre;
            txtDescripcion.Text += " " + prod.descripcion;
            txtMarca.Text += " " + prod.marca;
            txtCategoria.Text += " " + prod.categoria;
            txtPrecio.Text += " " + prod.precio;
        }

        private void Producto_Detalle_Load(object sender, EventArgs e)
        {

        }
    }
}
