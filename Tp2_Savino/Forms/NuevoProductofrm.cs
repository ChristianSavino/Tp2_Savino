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

    public partial class NuevoProductofrm : Form
    {
        private float precio;
        public NuevoProductofrm()
        {
            InitializeComponent();
        }

        public void ObtenerComboBoxes()
        {
            try
            {
                Negocios.Negocio negocio = new Negocios.Negocio();
                DataTable IdataMarca = new DataTable();
                DataTable IDataCategoria = new DataTable();
                IdataMarca = negocio.ObtenerDataTable(false,"","Select descripcion from marcas");
                IDataCategoria = negocio.ObtenerDataTable(false, "", "Select descripcion from categorias");
                boxCategoria.DataSource = IDataCategoria.DefaultView;
                boxCategoria.DisplayMember = "Descripcion";
                boxMarca.DataSource = IdataMarca.DefaultView;
                boxMarca.DisplayMember = "Descripcion";
                negocio = null;
                IdataMarca = null;
                IDataCategoria = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void NuevoProductofrm_Load(object sender, EventArgs e)
        {
            ObtenerComboBoxes();
          
            txtCod.MaxLength =50;
            txtNombre.MaxLength = 50;
            txtDesc.MaxLength = 150;
            txtPrecioCentavos.MaxLength = 2;
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    Negocios.Negocio negocio = new Negocios.Negocio();
                    Producto prod = new Producto();
                    prod.codigo = txtCod.Text;
                    prod.nombre = txtNombre.Text;
                    prod.descripcion = txtDesc.Text;
                    prod.imagen = "Imagen";
                    prod.marca = boxMarca.SelectedIndex + 1;
                    prod.categoria = boxCategoria.SelectedIndex + 1;
                    prod.precio = precio;
                    negocio.NuevoProducto(prod);

                    /*Producto_Detalle detalleproducto = new Producto_Detalle();
                    detalleproducto.SetearDatos(prod);
                    detalleproducto.Show();*/

                    MessageBox.Show("Producto Creado", "Keruministrador - Nuevo Producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Keruministrador - Error!");
            }

        }

        private bool validarDatos()
        {
            try
            {
                string ierror;
                //Cadenas vacías
                ierror = "Codigo está vacío";
                if(txtCod.TextLength == 0)
                {
                    throw new Exception(ierror);
                }
                ierror = "Nombre está vacío";
                if (txtNombre.TextLength == 0)
                {
                    throw new Exception(ierror);
                }
                ierror = "Descripción está vacío";
                if (txtDesc.TextLength == 0)
                {
                    throw new Exception(ierror);
                }
                ierror = "Seleccione una marca";
                if(boxMarca.SelectedItem == null)
                {
                    throw new Exception(ierror);
                }
                ierror = "Seleccione una categoria";
                if (boxCategoria.SelectedItem == null)
                {
                    throw new Exception(ierror);
                }
                ierror = "Precio está vacío";
                if (txtPrecioPesos.TextLength == 0)
                {
                    throw new Exception(ierror);
                }

                //Errores de tipeo
                ierror = "Nombre como Maximo debe tener 30 caracteres";
                if(txtNombre.TextLength > 30)
                {
                    throw new Exception(ierror);
                }
                ierror = "Precio debe tener solo numeros";
                precio = float.Parse(txtPrecioPesos.Text);
                ierror = "Centavos invalidos";
                if (txtPrecioCentavos.TextLength != 0)
                {
                    float precioCent = float.Parse(txtPrecioCentavos.Text);
                    precioCent /= 100;
                    precio += precioCent;
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Keruministrador - Error!");
                return false;
            }
            return true;
        }
    }
}
