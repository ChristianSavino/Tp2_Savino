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
    public partial class NuevoProductofrm : Form
    {
        private string ierror;
        private int cod;
        private float precio;

        public NuevoProductofrm()
        {
            InitializeComponent();
        }

        private void NuevoProductofrm_Load(object sender, EventArgs e)
        {
            txtCod.MaxLength = 10;
            txtNombre.MaxLength = 30;
            txtDesc.MaxLength = 50;
            txtPrecioCentavos.MaxLength = 2;
            boxCategoria.Items.Add("Juegos");
            boxMarca.Items.Add("Steam");         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validarDatos())
            {
                Producto prod = new Producto();
                prod.codigo = cod;
                prod.nombre = txtNombre.Text;
                prod.descripcion = txtDesc.Text;
                prod.marca = boxMarca.SelectedItem.ToString();
                prod.categoria = boxCategoria.SelectedItem.ToString();
                prod.precio = precio;
                Producto_Detalle detalleproducto = new Producto_Detalle();
                detalleproducto.SetearDatos(prod);
                detalleproducto.Show();
                MessageBox.Show("Producto Creado", "Keruministrador - Nuevo Producto");
            }
        }

        private bool validarDatos()
        {
            try
            {
                //Cadenas vacías
                ierror = "Codigo está vacío";
                if(txtCod.TextLength == 0)
                {
                    throw new Exception();
                }
                ierror = "Nombre está vacío";
                if (txtNombre.TextLength == 0)
                {
                    throw new Exception();
                }
                ierror = "Descripción está vacío";
                if (txtDesc.TextLength == 0)
                {
                    throw new Exception();
                }
                ierror = "Seleccione una marca";
                if(boxMarca.SelectedItem == null)
                {
                    throw new Exception();
                }
                ierror = "Seleccione una categoria";
                if (boxCategoria.SelectedItem == null)
                {
                    throw new Exception();
                }
                ierror = "Precio está vacío";
                if (txtPrecioPesos.TextLength == 0)
                {
                    throw new Exception();
                }

                //Errores de tipeo
                ierror = "Codigo debe tener solo numeros";
                cod = int.Parse(txtCod.Text);
                ierror = "Nombre como Maximo debe tener 30 caracteres";
                if(txtNombre.TextLength > 30)
                {
                    throw new Exception();
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
            catch
            {
                MessageBox.Show(ierror, "Keruministrador - Error!");
                return false;
            }
            return true;
        }
    }
}
