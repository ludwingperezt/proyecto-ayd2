using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocios
{
    public class negociosDetalleFacturaCliente
    {
        private int giIdDetalleFacturaCliente;
        private int giIdEncabezadoFacturaCliente;
        private short gshIdProducto;
        private decimal gdecPrecio;
        private double gduCantidad;

        #region constructores
        /// <summary>
        /// Constructor por defecto de la clase negociosDetalleFacturaCliente
        /// </summary>
        public negociosDetalleFacturaCliente()
        { 
        }
        #endregion 
        #region funciones de acceso y modificación de campos
        /// <summary>
        /// Función de modificación del campo ID del detalle de factura
        /// </summary>
        /// <param name="liIdDetalleFactura">int: ID del detalle de factura</param>
        public void setIdDetalleFacturaCliente(int liIdDetalleFactura)
        {
            this.giIdDetalleFacturaCliente = liIdDetalleFactura;
        }
        /// <summary>
        /// Función de modificación del campo ID del detalle del encabezado de factura
        /// </summary>
        /// <param name="liIdEncabezadoFactura">int: ID del encabezado de factura</param>
        public void setIdEncabezadoFacturaCliente(int liIdEncabezadoFactura)
        {
            this.giIdEncabezadoFacturaCliente = liIdEncabezadoFactura;
        }
        /// <summary>
        /// Función de modificación del campo ID producto
        /// </summary>
        /// <param name="lsiIdProducto">short: el ID del producto</param>
        public void setIdProducto(short lsiIdProducto)
        {
            this.gshIdProducto = lsiIdProducto;
        }
        /// <summary>
        /// Función de modificación del campo Precio.
        /// </summary>
        /// <param name="ldecPrecio">decimal: el precio al que se vendió el producto</param>
        public void setPrecio(decimal ldecPrecio)
        {
            this.gdecPrecio = ldecPrecio;
        }
        /// <summary>
        /// Función de modificiación de la cantidad comprada del producto.
        /// </summary>
        /// <param name="lduCantidad">double: cantidad que se compró del producto</param>
        public void setCantidad(double lduCantidad)
        {
            this.gduCantidad = lduCantidad;
        }
        /// <summary>
        /// Función de acceso al ID de detalle de la factura
        /// </summary>
        /// <returns>int: ID del detalle de la factura</returns>
        public int getIdDetalleFactura()
        {
            return this.giIdDetalleFacturaCliente;
        }
        /// <summary>
        /// Función de acceso al ID del encabezado de factura
        /// </summary>
        /// <returns>int: ID del encabezado de factura</returns>
        public int getIdEncabezadoFactura()
        {
            return this.giIdEncabezadoFacturaCliente;
        }
        /// <summary>
        /// Función de acceso al ID de producto
        /// </summary>
        /// <returns>short: ID del producto</returns>
        public short getIdProducto()
        {
            return this.gshIdProducto;
        }
        /// <summary>
        /// Función de acceso al precio en el que se vendió el producto
        /// </summary>
        /// <returns>decimal: precio de venta del producto</returns>
        public decimal getPrecio()
        {
            return this.gdecPrecio;
        }
        /// <summary>
        /// Función de acceso al campo cantidad.
        /// </summary>
        /// <returns>double: cantidad vendida del producto</returns>
        public double getCantidad()
        {
            return this.gduCantidad;
        }
        #endregion
        #region funciones de comunicación con la base de datos
        /// <summary>
        /// Función de inserción del detalle de factura en la base de datos.
        /// </summary>
        public void fnsInsertarDetalleFacturaCliente()
        {
            negociosAdaptadores.gAdaptadorDeConsultas.insertarDetalleFacturaCliente(this.giIdEncabezadoFacturaCliente, this.gshIdProducto, gdecPrecio, this.gduCantidad);
        }
        #endregion
    }
}
