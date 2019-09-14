using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_Savino.Forms
{
    public partial class Producto_Buscar : Form
    {
        DataTable idataTable = new DataTable();

        public Producto_Buscar()
        {
            InitializeComponent();
        }

        private string condicionMarcas(string condicion)
        {
            if(condicion.Length >6)
            {
                condicion += " AND ";
            }
            if (Marcacheck.Checked == true)
            {
                if (CategoriaCheck.Checked == true)
                {
                    condicion += "idmarca = " + (boxMarca.SelectedIndex + 1) + " AND idcategoria = " + (boxCategoria.SelectedIndex + 1);
                }
                else
                {
                    condicion += "idmarca = " + (boxMarca.SelectedIndex + 1);
                }
            }
            else if (CategoriaCheck.Checked == true)
            {
                condicion += "idcategoria = " + (boxCategoria.SelectedIndex + 1);
            }
            return condicion;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = "";
                if (txtCod.Text.Length > 0)
                {
                    condicion = "Where Codigo = '" + txtCod.Text + "'";
                    txtNombre.Text = "";
                    condicion = condicionMarcas(condicion);
                }
                else if (txtNombre.Text.Length > 0)
                {
                    condicion = "Where Nombre Like '%" + txtNombre.Text + "%'";
                    txtCod.Text = "";
                    condicion = condicionMarcas(condicion);
                }
                else if(Marcacheck.Checked == true || CategoriaCheck.Checked == true)
                {
                    condicion = "Where ";
                   condicion = condicionMarcas(condicion);
                }

                Negocios.Negocio negocio = new Negocios.Negocio();
                idataTable = negocio.ObtenerDataTable(true, condicion, "Select id, codigo as 'Codigo',nombre as 'Nombre',descripcion as 'Descripcion',(Select descripcion from MARCAS where id=idmarca) as 'Marca',(Select descripcion from CATEGORIAS where id=idcategoria) as 'Categoria', precio as 'Precio' from Articulos");
                iDataGrid.DataSource = idataTable.DefaultView;
                iDataGrid.Columns["id"].Visible = false;
                negocio = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            Producto_Detalle detalle = new Producto_Detalle();
            detalle.id = (int.Parse(iDataGrid.Rows[iDataGrid.CurrentCell.RowIndex].Cells["id"].Value.ToString()));
            detalle.Show();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (iDataGrid.DataSource != null)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea Eliminar el producto?", "Keruministrador - Eliminar Producto", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Negocios.Negocio negocio = new Negocios.Negocio();
                        negocio.Borrar(int.Parse(iDataGrid.Rows[iDataGrid.CurrentCell.RowIndex].Cells["id"].Value.ToString()));
                        iDataGrid.Refresh();
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (iDataGrid.DataSource != null)
                {
                    NuevoProductofrm detalle = new NuevoProductofrm();
                    detalle.WindowState = FormWindowState.Normal;
                    detalle.id = (int.Parse(iDataGrid.Rows[iDataGrid.CurrentCell.RowIndex].Cells["id"].Value.ToString()));
                    detalle.Show();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void Producto_Buscar_Load(object sender, EventArgs e)
        {
            Negocios.Negocio negocio = new Negocios.Negocio();
            negocio.ObtenerComboBoxes(boxMarca, "marcas");
            negocio.ObtenerComboBoxes(boxCategoria, "Categorias");
            negocio = null;
        }
    }
}
