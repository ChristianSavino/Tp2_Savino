using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_Savino
{
    public partial class Menu_Principal : Form
    {
        private Form windows;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea salir del programa?", "Keruministrador - Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(windows == null)
            {
                windows = new NuevoProductofrm();
                windows.MdiParent = this;
                windows.Show();
            }
            else
            {
                windows.Close();
                windows = null;
                windows = new NuevoProductofrm();
                windows.MdiParent = this;
                windows.Show();
            }

        }
    }
}