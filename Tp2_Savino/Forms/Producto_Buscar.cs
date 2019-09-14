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

        private void Buscar_Click(object sender, EventArgs e)
        {
            string condicion = "";
            if(txtCod.Text.Length > 0)
            {
                condicion = "Where Codigo = '" + txtCod.Text + "'";
                txtNombre.Text = "";
            }
            if(txtNombre.Text.Length > 0)
            {
                condicion = "Where Nombre Like '%" + txtNombre.Text + "%'";
                txtCod.Text = "";
            }
            string query = "Select codigo as 'Codigo',nombre as 'Nombre',descripcion as 'Descripcion',(Select descripcion from MARCAS where id=idmarca) as 'Marca',(Select descripcion from CATEGORIAS where id=idcategoria) as 'Categoria', precio as 'Precio' from Articulos";

            Negocios.Negocio negocio = new Negocios.Negocio();
            idataTable = negocio.ObtenerDataTable(true, condicion , query);
            iDataGrid.DataSource = idataTable.DefaultView;
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            Producto_Detalle detalle = new Producto_Detalle();
            detalle.id = iDataGrid.CurrentCell.RowIndex + 1;
            detalle.Show();
        }
    }
}
