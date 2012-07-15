using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosDetalleFacturaCliente
    {
        private int giIdDetalleFacturaCliente;
        private int giIdEncabezadoFacturaCliente;
        private short gshIdProducto;
        private decimal gdecPrecio;
        private double gduCantidad;
        private decimal gdecMonto;

        private string lsNombreProducto;
        private string lsCodigoProducto;

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
        public void setNombreProducto(string lsNombre)
        {
            this.lsNombreProducto = lsNombre;
        }
        public string getNombreProducto()
        {
            return this.lsNombreProducto;
        }
        public void setCodigoProducto(string lsCodigo)
        {
            this.lsCodigoProducto = lsCodigo;
        }
        public string getCodigoProducto()
        {
            return this.lsCodigoProducto;
        }
        public decimal getMonto()
        {
            return this.gdecMonto;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        public void fnvSetDatosDetalle(int idProducto, decimal precio, double cantidad, string nombre, string codigo)
        {
            this.gshIdProducto = (short)idProducto;
            this.gdecPrecio = precio;
            this.gduCantidad = cantidad;
            this.lsNombreProducto = nombre;
            this.lsCodigoProducto = codigo;
            this.gdecMonto = this.gdecPrecio * Convert.ToDecimal(this.gduCantidad);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        public void fnvAumentarCantidad(double cantidad)
        {
            this.gduCantidad += cantidad;
            this.gdecMonto = this.gdecPrecio * Convert.ToDecimal(this.gduCantidad);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        public void fnvDisminuirCantidad(double cantidad)
        {
            this.gduCantidad -= cantidad;
            this.gdecMonto = this.gdecPrecio * Convert.ToDecimal(this.gduCantidad);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        public void fnvCambiarCantidad(double cantidad)
        {
            this.gduCantidad = cantidad;
            this.gdecMonto = this.gdecPrecio * Convert.ToDecimal(this.gduCantidad);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public decimal fndecSetDatosDetalle(int idProducto, decimal precio, double cantidad, string nombre, string codigo)
        {
            this.gshIdProducto = (short)idProducto;
            this.gdecPrecio = precio;
            this.gduCantidad = cantidad;
            this.lsNombreProducto = nombre;
            this.lsCodigoProducto = codigo;
            this.gdecMonto = this.gdecPrecio * Convert.ToDecimal(this.gduCantidad);
            return this.gdecMonto;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idFactura"></param>
        /// <returns></returns>
        public static List<negociosDetalleFacturaCliente> fnlstObtenerListaDetallesFactura(int idFactura)
        {
            //IDDETALLEFACTURACLIENTE,IDPRODUCTO,PRECIO,CANTIDAD
            DataTable dtLocal = negociosAdaptadores.gBuscarDetalleFactura.GetData(idFactura);
            List<negociosDetalleFacturaCliente> lst = new List<negociosDetalleFacturaCliente>();
            object[] objInstancia;
            for (int i = 0; i < dtLocal.Rows.Count; i++)
            {
                objInstancia = dtLocal.Rows[i].ItemArray;
                negociosDetalleFacturaCliente temporal = new negociosDetalleFacturaCliente();
                temporal.giIdEncabezadoFacturaCliente = idFactura;
                temporal.giIdDetalleFacturaCliente = (Convert.ToInt32(objInstancia[0]));
                temporal.gshIdProducto = (short)(Convert.ToInt32(objInstancia[1]));
                temporal.gdecPrecio = (Convert.ToDecimal(objInstancia[2]));
                temporal.gduCantidad = (Convert.ToDouble(objInstancia[3]));
                temporal.gdecMonto = temporal.gdecPrecio * (Convert.ToDecimal(temporal.gduCantidad));
                lst.Add(temporal);
            }
            return lst;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtLocal"></param>
        /// <returns></returns>
        protected static List<negociosDetalleFacturaCliente> fnlstObtenerListaVisible(DataTable dtLocal)
        {
            //id,factura, IDDETALLEFACTURACLIENTE,IDPRODUCTO,PRECIO,CANTIDAD
            List<negociosDetalleFacturaCliente> lst = new List<negociosDetalleFacturaCliente>();
            object[] objInstancia;
            for (int i = 0; i < dtLocal.Rows.Count; i++)
            {
                objInstancia = dtLocal.Rows[i].ItemArray;
                negociosDetalleFacturaCliente temporal = new negociosDetalleFacturaCliente();
                temporal.giIdEncabezadoFacturaCliente = (Convert.ToInt32(objInstancia[0]));
                temporal.giIdDetalleFacturaCliente = (Convert.ToInt32(objInstancia[1]));
                temporal.gshIdProducto = (short)(Convert.ToInt32(objInstancia[2]));
                temporal.gdecPrecio = (Convert.ToDecimal(objInstancia[3]));
                temporal.gduCantidad = (Convert.ToDouble(objInstancia[4]));
                temporal.gdecMonto = temporal.gdecPrecio * (Convert.ToDecimal(temporal.gduCantidad));
                lst.Add(temporal);
            }
            return lst;
        }

        #endregion



    }
}
