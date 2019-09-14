using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp2_Savino.Negocios;

namespace Tp2_Savino
{
    public partial class Producto_Detalle : Form
    {
        private int iid;

        public int id
        {
            get
            {
                return iid;
            }
            set
            {
                iid = value;
            }
        }

        public Producto_Detalle()
        {
            InitializeComponent();
        }

        private void SetearDatos(Producto prod)
        {
            txtCod.Text += " " + prod.codigo;
            txtName.Text += " " + prod.nombre;
            txtDescripcion.Text += " " + prod.descripcion;
            boxMarca.SelectedIndex = prod.marca-1;
            boxCategoria.SelectedIndex= prod.categoria - 1;
            txtPrecio.Text += " " + prod.precio;
           //txtimagen.txt += " " + prod.imagen;
        }

        private void Producto_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                Negocios.Negocio negocio = new Negocios.Negocio();
                negocio.ObtenerComboBoxes(boxMarca, "marcas");
                negocio.ObtenerComboBoxes(boxCategoria, "Categorias");
                Producto prod = new Producto();
                prod = negocio.ObtenerProducto(iid);
                SetearDatos(prod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Keruministrador - Error!");
                this.Close();
            }
        }
    }
}
