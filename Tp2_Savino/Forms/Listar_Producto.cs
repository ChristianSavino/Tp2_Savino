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

namespace Tp2_Savino.Forms
{
    public partial class Listar_Producto : Form
    {
        public Listar_Producto()
        {
            InitializeComponent();
        }

        private void Listar_Producto_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "Select codigo as 'Codigo',nombre as 'Nombre',descripcion as 'Descripcion',(Select descripcion from MARCAS where id=idmarca) as 'Marca',(Select descripcion from CATEGORIAS where id=idcategoria) as 'Categoria', precio as 'Precio' from Articulos";
                DataTable idataTable = new DataTable();
                Negocios.Negocio negocio = new Negocios.Negocio();
                idataTable = negocio.ObtenerDataTable(false, "", query);
                iDataGrid.DataSource = idataTable.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
