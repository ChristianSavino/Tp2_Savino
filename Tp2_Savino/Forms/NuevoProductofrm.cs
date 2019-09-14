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

        private float precio;
        public NuevoProductofrm()
        {
            InitializeComponent();
        }


        private void SetearDatos(Producto prod)
        {
            txtCod.Text = prod.codigo;
            txtNombre.Text = prod.nombre;
            txtDesc.Text = prod.descripcion;
            boxMarca.SelectedIndex = prod.marca - 1;
            boxCategoria.SelectedIndex = prod.categoria - 1;
            txtPrecioPesos.Text = prod.precio.ToString();
            imageTxT.Text = prod.imagen;
        }

        private void NuevoProductofrm_Load(object sender, EventArgs e)
        {
            Negocios.Negocio negocio = new Negocios.Negocio();
            negocio.ObtenerComboBoxes(boxMarca, "marcas");
            negocio.ObtenerComboBoxes(boxCategoria, "Categorias");
            negocio = null;
            EstadoBox.Hide();
            Estadolabel.Hide();
            if(id != 0)
            {
                negocio = new Negocios.Negocio();
                Producto prod = new Producto();
                prod = negocio.ObtenerProducto(id);
                SetearDatos(prod);
                titulo.Text = "Modificar Producto";
                EstadoBox.Show();
                EstadoBox.Items.Add("Alta");
                EstadoBox.Items.Add("Baja");
                Estadolabel.Show();
            }
            txtCod.MaxLength =50;
            txtNombre.MaxLength = 50;
            txtDesc.MaxLength = 150;
            txtPrecioCentavos.MaxLength = 2;
            imageTxT.MaxLength = 150;
            negocio = null;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    Negocios.Negocio negocio = new Negocios.Negocio();
                    Producto prod = new Producto();
                    prod.id = id;
                    prod.codigo = txtCod.Text;
                    prod.nombre = txtNombre.Text;
                    prod.descripcion = txtDesc.Text;
                    prod.imagen = imageTxT.Text;
                    prod.marca = boxMarca.SelectedIndex + 1;
                    prod.categoria = boxCategoria.SelectedIndex + 1;
                    prod.precio = precio;
                    if(prod.id != 0)
                    {
                        negocio.Actualizar(prod);
                        MessageBox.Show("Producto Actualizado", "Keruministrador - Actualizar Producto");
                    }
                    else
                    {
                        negocio.NuevoProducto(prod);
                        MessageBox.Show("Producto Creado", "Keruministrador - Nuevo Producto");
                    }
                    
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
