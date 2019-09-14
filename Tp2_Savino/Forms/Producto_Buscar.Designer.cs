namespace Tp2_Savino.Forms
{
    partial class Producto_Buscar
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.iDataGrid = new System.Windows.Forms.DataGridView();
            this.Ver = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxCategoria = new System.Windows.Forms.ComboBox();
            this.boxMarca = new System.Windows.Forms.ComboBox();
            this.Marcacheck = new System.Windows.Forms.CheckBox();
            this.CategoriaCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.iDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(171, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 30);
            this.txtNombre.TabIndex = 18;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(171, 93);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(293, 30);
            this.txtCod.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buscar Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo:";
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(47, 199);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(158, 45);
            this.Buscar.TabIndex = 19;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // iDataGrid
            // 
            this.iDataGrid.AllowUserToAddRows = false;
            this.iDataGrid.AllowUserToDeleteRows = false;
            this.iDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.iDataGrid.Location = new System.Drawing.Point(47, 279);
            this.iDataGrid.Name = "iDataGrid";
            this.iDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.iDataGrid.Size = new System.Drawing.Size(1324, 242);
            this.iDataGrid.TabIndex = 20;
            // 
            // Ver
            // 
            this.Ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ver.Location = new System.Drawing.Point(47, 552);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(158, 45);
            this.Ver.TabIndex = 21;
            this.Ver.Text = "Detalles";
            this.Ver.UseVisualStyleBackColor = true;
            this.Ver.Click += new System.EventHandler(this.Ver_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(211, 552);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(158, 45);
            this.Eliminar.TabIndex = 22;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(375, 552);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(158, 45);
            this.Modificar.TabIndex = 23;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Marca:";
            // 
            // boxCategoria
            // 
            this.boxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCategoria.FormattingEnabled = true;
            this.boxCategoria.Location = new System.Drawing.Point(615, 141);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(293, 33);
            this.boxCategoria.TabIndex = 25;
            // 
            // boxMarca
            // 
            this.boxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMarca.Location = new System.Drawing.Point(615, 91);
            this.boxMarca.Name = "boxMarca";
            this.boxMarca.Size = new System.Drawing.Size(293, 33);
            this.boxMarca.TabIndex = 24;
            // 
            // Marcacheck
            // 
            this.Marcacheck.AutoSize = true;
            this.Marcacheck.Location = new System.Drawing.Point(594, 102);
            this.Marcacheck.Name = "Marcacheck";
            this.Marcacheck.Size = new System.Drawing.Size(15, 14);
            this.Marcacheck.TabIndex = 28;
            this.Marcacheck.UseVisualStyleBackColor = true;
            // 
            // CategoriaCheck
            // 
            this.CategoriaCheck.AutoSize = true;
            this.CategoriaCheck.Location = new System.Drawing.Point(595, 152);
            this.CategoriaCheck.Name = "CategoriaCheck";
            this.CategoriaCheck.Size = new System.Drawing.Size(15, 14);
            this.CategoriaCheck.TabIndex = 29;
            this.CategoriaCheck.UseVisualStyleBackColor = true;
            // 
            // Producto_Buscar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1391, 618);
            this.Controls.Add(this.CategoriaCheck);
            this.Controls.Add(this.Marcacheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxCategoria);
            this.Controls.Add(this.boxMarca);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.iDataGrid);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Producto_Buscar";
            this.Text = "Producto_Buscar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Producto_Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView iDataGrid;
        private System.Windows.Forms.Button Ver;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxCategoria;
        private System.Windows.Forms.ComboBox boxMarca;
        private System.Windows.Forms.CheckBox Marcacheck;
        private System.Windows.Forms.CheckBox CategoriaCheck;
    }
}