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
                    conexion.setearConsulta("Insert into ARTICULOS (codigo, nombre, descripcion,idmarca,idcategoria,imagen,precio) VALUES ( '"+p.codigo+"','"+p.nombre+"','"+p.descripcion+"',"+p.marca+","+p.categoria+",'"+p.imagen+"',"+p.precio+")");
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

        public bool ValidarCreacionBaseDatos(Producto p)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string error = "Ya existe un Articulo con ese codigo";
                conexion.setearConsulta("Select * from Articulos where codigo =" + "'" +p.codigo+"'");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.HasRows)
                {
                    if (conexion != null)
                    {
                        conexion.cerrarConexion();
                    }
                    conexion = null;
                    throw new Exception(error);
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
                //Console.WriteLine("Value of CompanyName column:" + conexion.Lector["CompanyName"]);
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

    }
}
