using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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
            try
            {
                txtCod.Text += " " + prod.codigo;
                txtName.Text += " " + prod.nombre;
                txtDescripcion.Text += " " + prod.descripcion;
                if (prod.marca - 1 > boxMarca.Items.Count - 1)
                {
                    MessageBox.Show("La Marca en base de datos tiene un dato incorrecto \nCorregir usando la funcion Modificar", "Keruministrador - Alerta");
                }
                else
                {
                    boxMarca.SelectedIndex = prod.marca - 1;
                }
                if (prod.categoria - 1 > boxCategoria.Items.Count - 1)
                {
                    MessageBox.Show("La Categoria en base de datos tiene un dato incorrecto \nCorregir usando la funcion Modificar", "Keruministrador - Alerta");
                }
                else
                {
                    boxCategoria.SelectedIndex = prod.categoria - 1;
                }
                txtPrecio.Text += " " + prod.precio;

            }
            catch (Exception ex)
            {
                throw ex;
            }         
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
                if (prod.imagen != "" && prod.imagen.Length > 5)
                {
                    Image img = negocio.ObtenerImagen(prod.imagen);
                    SetearImagen(img);
                }
                SetearDatos(prod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Keruministrador - Error!");
                this.Close();
            }
        }

        private void SetearImagen(Image img)
        {
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
