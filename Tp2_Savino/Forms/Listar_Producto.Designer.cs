namespace Tp2_Savino.Forms
{
    partial class Listar_Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.iDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // iDataGrid
            // 
            this.iDataGrid.AllowUserToAddRows = false;
            this.iDataGrid.AllowUserToDeleteRows = false;
            this.iDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.iDataGrid.Location = new System.Drawing.Point(93, 33);
            this.iDataGrid.Name = "iDataGrid";
            this.iDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.iDataGrid.Size = new System.Drawing.Size(1680, 549);
            this.iDataGrid.TabIndex = 0;
            // 
            // Listar_Producto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.iDataGrid);
            this.Name = "Listar_Producto";
            this.Text = "Listar_Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Listar_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView iDataGrid;
    }
}