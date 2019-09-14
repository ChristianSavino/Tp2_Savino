using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Savino.Negocios
{
    public class Negocio
    {
        public DataTable ObtenerDataTable(bool usaCondicion, string condicion,string consulta)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                DataTable idataTable = new DataTable();
                if(usaCondicion)
                {
                    conexion.setearConsulta(consulta + " " + condicion);
                }
                else
                {
                    conexion.setearConsulta(consulta);
                }
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                idataTable.Load(conexion.Lector);
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
                conexion = null;
                return idataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void NuevoProducto(Producto p)
        {
            try
            {
                if (ValidarCreacionBaseDatos(p))
                {
                    AccesoDatos conexion = new AccesoDatos();
                    conexion.setearConsulta("Insert into ARTICULOS (codigo, nombre, descripcion,idmarca,idcategoria,imagen,precio) VALUES ( @codigo,@nombre,@descripcion,@marca,@categoria,@imagen,@precio)");
                    conexion.agregarParametro("@codigo", p.codigo);
                    conexion.agregarParametro("@nombre", p.nombre);
                    conexion.agregarParametro("@descripcion", p.descripcion);
                    conexion.agregarParametro("@marca", p.marca);
                    conexion.agregarParametro("@categoria", p.categoria);
                    conexion.agregarParametro("@imagen", p.imagen);
                    conexion.agregarParametro("@precio", p.precio);
                    conexion.abrirConexion();
                    conexion.ejecutarAccion();
                    if (conexion != null)
                    {
                        conexion.cerrarConexion();
                    }
                    conexion = null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void Actualizar(Producto p)
        {
            try
            {
                if (ValidarCreacionBaseDatos(p))
                {
                    AccesoDatos conexion = new AccesoDatos();
                    conexion.setearConsulta("update ARTICULOS set codigo= @codigo, nombre= @nombre, descripcion= @descripcion,idmarca= @marca,idcategoria= @categoria,imagen= @imagen,precio= @precio Where id= @id");
                    conexion.agregarParametro("@codigo", p.codigo);
                    conexion.agregarParametro("@nombre", p.nombre);
                    conexion.agregarParametro("@descripcion", p.descripcion);
                    conexion.agregarParametro("@marca", p.marca);
                    conexion.agregarParametro("@categoria", p.categoria);
                    conexion.agregarParametro("@imagen", p.imagen);
                    conexion.agregarParametro("@precio", p.precio);
                    conexion.agregarParametro("@id", p.id);
                    conexion.abrirConexion();
                    conexion.ejecutarAccion();
                    if (conexion != null)
                    {
                        conexion.cerrarConexion();
                    }
                    conexion = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar(int id)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                conexion.setearConsulta("Delete From ARTICULOS Where id= @id");
                conexion.agregarParametro("@id", id);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
                conexion = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidarCreacionBaseDatos(Producto p)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string error = "Ya existe un Articulo con ese codigo";
                conexion.setearConsulta("Select id,codigo from Articulos where codigo = @codigo");
                conexion.agregarParametro("@codigo", p.codigo);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.HasRows)
                {
                    if(conexion.Lector.Read() && p.id != 0)
                    {
                        if (p.codigo != conexion.Lector.GetString(conexion.Lector.GetOrdinal("Codigo")))
                        {
                            if(p.id != conexion.Lector.GetInt32(conexion.Lector.GetOrdinal("id")))
                            {
                                throw new Exception(error);
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                    if (conexion != null)
                    {
                        conexion.cerrarConexion();
                    }
                    conexion = null;
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Producto ObtenerProducto(int id)
        {
            try
            {
                Producto producto = new Producto();
                AccesoDatos conexion = new AccesoDatos();
                conexion.setearConsulta("Select codigo, nombre, descripcion, idmarca, idcategoria, precio, imagen from Articulos where id=" + id);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.HasRows && conexion.Lector.Read())
                {
                    producto.id = id;
                    producto.codigo = conexion.Lector.GetString(conexion.Lector.GetOrdinal("Codigo"));
                    producto.nombre = conexion.Lector.GetString(conexion.Lector.GetOrdinal("Nombre"));
                    producto.descripcion = conexion.Lector.GetString(conexion.Lector.GetOrdinal("Descripcion"));
                    producto.marca = conexion.Lector.GetInt32(conexion.Lector.GetOrdinal("idmarca"));
                    producto.categoria = conexion.Lector.GetInt32(conexion.Lector.GetOrdinal("idcategoria"));
                    producto.precio = float.Parse(conexion.Lector.GetValue(conexion.Lector.GetOrdinal("precio")).ToString());
                    producto.imagen = conexion.Lector.GetString(conexion.Lector.GetOrdinal("imagen"));
                }
                else
                {
                    throw new Exception("No se encontró el Articulo");
                }
                return producto;
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        public void ObtenerComboBoxes(ComboBox com, string tabla)
        {
            try
            {
                Negocios.Negocio negocio = new Negocios.Negocio();
                DataTable idatatable = new DataTable();
                idatatable = negocio.ObtenerDataTable(false, "", "Select descripcion from "+ tabla);
                com.DataSource = idatatable.DefaultView;
                com.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
