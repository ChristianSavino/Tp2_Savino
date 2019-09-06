using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Savino.Clases
{
    public class Producto
    {
        #region variables   
        private int icodigo;
        private string inombre;
        private string idescripcion;
        private string imarca;
        private string icategoria;
        private float iprecio;
        #endregion

        #region propiedades
        public int codigo
        {
            get
            {
                return icodigo;
            }
            set
            {
                icodigo = value;
            }
        }
        public string nombre
        {
            get
            {
                return inombre;
            }
            set
            {
                inombre = value;
            }
        }
        public string descripcion
        {
            get
            {
                return idescripcion;
            }
            set
            {
                idescripcion = value;
            }
        }
        public string marca
        {
            get
            {
                return imarca;
            }
            set
            {
                imarca = value;
            }
        }
        public string categoria
        {
            get
            {
                return icategoria;
            }
            set
            {
                icategoria = value;
            }
        }
        public float precio
        {
            get
            {
                return iprecio;
            }
            set
            {
                iprecio = value;
            }
        }
        #endregion
    }
}
