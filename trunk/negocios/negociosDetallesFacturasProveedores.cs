using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocios
{
    public class negociosDetallesFacturasProveedores
    {
        private int idDetalleFacturaProveedor;
        private int idFacturaProveedor;
        private int idProducto;
        private decimal costo;
        private double cantidad;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosDetallesFacturasProveedores
        /// </summary>
        /*public void negociosDetallesFacturasProveedores()
        {

        }*/
        #endregion

        #region Accesores y modificadores
        /// <summary>
        /// Grupo de funciones para modificar los valores de la clase
        /// </summary>

        public void setIdDetalleFacturaProveedor(int liIdFacturaDetalleProveedor)
        {
            this.idDetalleFacturaProveedor = liIdFacturaDetalleProveedor;
        }

        public void setIdFacturaProveedor(int liIdFacturaProveedor)
        {
            this.idFacturaProveedor = liIdFacturaProveedor;
        }

        public void setIdProducto(int liIdProducto)
        {
            this.idProducto = liIdProducto;
        }

        public void setCosto(decimal ldecCosto)
        {
            this.costo = ldecCosto;
        }

        public void setCantidad(double  ldecCantidad)
        {
            this.cantidad = ldecCantidad;
        }
        /// <summary>
        /// Grupo de funciones para leer los datos de la clase
        /// </summary>

        public int getIdDetalleFacturaProveedor()
        {
            return this.idDetalleFacturaProveedor;
        }

        public int getIdFacturaProveedor()
        {
            return this.idFacturaProveedor;
        }

        public int getIdProducto()
        {
            return this.idProducto;
        }

        public decimal getCosto()
        {
            return this.costo;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }
        #endregion

        /// <summary>
        /// Función de inserción de detalle factura proveedor en la base de datos.
        /// </summary>
        public string fnsInsertarDetalleFacturaProveedor()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insertarDetalleFacturaProveedores(this.idFacturaProveedor, this.idProducto, this.costo, this.cantidad);
                return "La inserción del empleado en la base de datos se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
