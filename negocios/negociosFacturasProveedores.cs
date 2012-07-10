using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace negocios
{
    class negociosFacturasProveedores
    {
        private int idFacturaProveedor;
        private int idProveedor;
        private int idEmpleado;
        private string serie;
        private int numero;
        private DateTime fecha;
        private decimal total;//

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosFacturaProveedores
        /// </summary>
        public void negociosFacturaProveedores()
        {
        }
        #endregion

        #region Accesores y modificadores
        /// <summary>
        /// Grupo de funciones para modificar los valores de la clase
        /// </summary>

        public void setIdFacturaProveedor(int liIdFacturaProveedor)
        {
            this.idFacturaProveedor = liIdFacturaProveedor;
        }

        public void setIdProveedor(int liIdProveedor)
        {
            this.idProveedor = liIdProveedor;
        }

        public void setIdEmpleado(int liIdEmpleado)
        {
            this.idEmpleado = liIdEmpleado;
        }

        public void setSerie(string lsSerie)
        {
            this.serie = lsSerie;
        }

        public void setNumero(int liNumero)
        {
            this.numero = liNumero;
        }

        public void setFecha(DateTime ldtfecha)
        {
            this.fecha = ldtfecha;
        }

        public void setTotal(decimal ldTotal)
        {
            this.total = ldTotal;
        }

        /// <summary>
        /// Grupo de funciones para leer los datos de la clase
        /// </summary>

        public int getIdFacturaProveedor()
        {
            return this.idFacturaProveedor;
        }

        public int getIdProveedor()
        {
            return this.idProveedor;
        }

        public int getIdEmpleado()
        {
            return this.idEmpleado;
        }

        public string getSerie()
        {
            return this.serie;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public DateTime getFecha()
        {
            return this.fecha;
        }

        public decimal getTotal()
        {
            return this.total;
        }
        #endregion

        #region funciones de comunicación con la base de datos
        /// <summary>
        /// Función de inserción de factura proveedor en la base de datos.
        /// </summary>
        public void fnsInsertarFacturaProveedor()
        {
            
        }
        #endregion
    }

}
