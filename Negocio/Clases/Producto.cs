using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Savino.Negocios
{
    public class Producto
    {
        #region variables   
        private string icodigo;
        private string inombre;
        private string idescripcion;
        private string iimagen;
        private int imarca;
        private int icategoria;
        private float iprecio;
        private int iestado;
        private int iid;
        #endregion

        #region propiedades
        public string codigo
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
        public string imagen
        {
            get
            {
                return iimagen;
            }
            set
            {
                iimagen = value;
            }
        }
        public int marca
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
        public int categoria
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

        public int id
        {
            get
            {
                return iid;
            }
            set
            {
                iid = value;
            }
        }

        public int estado
        {
            get
            {
                return iestado;
            }
            set
            {
                iestado = value;
            }
        }
        #endregion
    }
}
