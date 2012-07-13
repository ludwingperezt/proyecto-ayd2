using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosFacturaCliente
    {
        private int giIdFactura;
        private string gsNIT;
        private byte gbyIdEmpleado;
        private string gsSerie;
        private int giNumero;
        private DateTime gdtFecha;
        private double gduDescuento;
        private decimal gdecSubTotal;
        private decimal gdecTotal;
        private int giIdCliente;
        private List<negociosDetalleFacturaCliente> glstListaDetalleFactura;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosFacturaCliente
        /// </summary>
        public negociosFacturaCliente()
        {
            glstListaDetalleFactura = new List<negociosDetalleFacturaCliente>();
        }
        #endregion
        #region funciones de acceso y modificacion de campos
        /// <summary>
        /// Función de modificación del Id de la factura
        /// </summary>
        /// <param name="liIdFactura">int: id de la factura</param>
        public void setIdFactura(int liIdFactura)
        {
            this.giIdFactura = liIdFactura;
        }
        /// <summary>
        /// Función de acceso al campo ID de factura
        /// </summary>
        /// <returns>int: el ID de la factura</returns>
        public int getIdFactura()
        {
            return this.giIdFactura;
        }
        /// <summary>
        /// Función de modificación del campo NIT
        /// </summary>
        /// <param name="lsNIT">string: el nit del cliente</param>
        public void setNIT(string lsNIT)
        {
            this.gsNIT = lsNIT;
        }
        /// <summary>
        /// Función de acceso al campo NIT
        /// </summary>
        /// <returns>string: el NIT del cliente</returns>
        public string getNIT()
        {
            return this.gsNIT;
        }
        /// <summary>
        /// Función de modificación del ID del empleado
        /// </summary>
        /// <param name="libyIdEmpleado">byte: el ID del empleado</param>
        public void setIdEmpleado(byte libyIdEmpleado)
        {
            this.gbyIdEmpleado = libyIdEmpleado;
        }
        /// <summary>
        /// Función de acceso al ID del empleado
        /// </summary>
        /// <returns>byte: el ID del empleado</returns>
        public byte getIdEmpleado()
        {
            return this.gbyIdEmpleado;
        }
        /// <summary>
        /// Función de modificación del campo serie
        /// </summary>
        /// <param name="lsSerie">string: serie a la que pertenece la factura</param>
        public void setSerie(string lsSerie)
        {
            this.gsSerie = lsSerie;
        }
        /// <summary>
        /// Función de acceso a la serie de la factura
        /// </summary>
        /// <returns>string: la serie a la que pertenece la factura</returns>
        public string getSerie()
        {
            return this.gsSerie;
        }
        /// <summary>
        /// Función de modificación del número de la factura
        /// </summary>
        /// <param name="liNumero">int: el número de la factura</param>
        public void setNumeroFactura(int liNumero)
        {
            this.giNumero = liNumero;
        }
        /// <summary>
        /// Función de acceso al número de factura
        /// </summary>
        /// <returns>int: el número de la factura</returns>
        public int getNumeroFactura()
        {
            return this.giNumero;
        }
        /// <summary>
        /// Función de modificiación de fecha de la factura
        /// </summary>
        /// <param name="ldtFecha">DateTime: la fecha de emisión de la factura</param>
        public void setFecha(DateTime ldtFecha)
        {
            this.gdtFecha = ldtFecha;
        }
        /// <summary>
        /// Función de acceso a la fecha de la factura
        /// </summary>
        /// <returns>DateTime: la fecha en que se emitió la factura</returns>
        public DateTime getFecha()
        {
            return this.gdtFecha;
        }
        /// <summary>
        /// Función de modificación del campo de descuento
        /// </summary>
        /// <param name="lduDescuento">double: descuento a aplicar</param>
        public void setDescuento(double lduDescuento)
        {
            this.gduDescuento = lduDescuento; 
        }
        /// <summary>
        /// Función de acceso al campo de descuento
        /// </summary>
        /// <returns>double: descuento a aplicar en la factura</returns>
        public double getDescuento()
        {
            return this.gduDescuento;
        }
        /// <summary>
        /// Función de modificación del campo subtotal
        /// </summary>
        /// <param name="ldecSubTotal">decimal: el subtotal de la factura (total sin descuento)</param>
        public void setSubTotal(decimal ldecSubTotal)
        {
            this.gdecSubTotal = ldecSubTotal;
        }
        /// <summary>
        /// Función de acceso del campo subtotal de la factura
        /// </summary>
        /// <returns>decimal: subtotal de la factura (monto sin descuento)</returns>
        public decimal getSubTotal()
        {
            return this.gdecSubTotal;
        }
        /// <summary>
        /// Función de modificación del campo Total, de la factura (subtotal menos descuento)
        /// </summary>
        /// <param name="ldecTotal">decimal: monto total de la factura (subtotal menos descuento)</param>
        public void setTotal(decimal ldecTotal)
        {
            this.gdecTotal = ldecTotal;
        }
        /// <summary>
        /// Función de acceso al campo Total, de la factura (subtotal menos descuento)
        /// </summary>
        /// <returns>decimal: monto total de la factura (subtotal menos descuento)</returns>
        public decimal getTotal()
        {
            return this.gdecTotal;
        }
        #endregion
        #region funciones de comunicación con la base de datos
        /// <summary>
        /// Función local para insertar el encabezado de la factura en la base de datos y recuperar el ID de la factura
        /// </summary>
        protected void fnvdInsertarEncabezadoFacturaCliente()
        {
            //DataTable tablaTemporal = negociosAdaptadores.gAdaptadorEncabezadoFacturaCliente.GetData(gsNIT, gbyIdEmpleado, gsSerie, gduDescuento, gdecSubTotal, gdecTotal);
            DataTable tablaTemporal = negociosAdaptadores.gAdaptadorEncabezadoFacturaCliente.GetData(this.giIdCliente, gbyIdEmpleado, gsSerie, gduDescuento, gdecSubTotal, gdecTotal);
            object o = tablaTemporal.Rows[0].ItemArray[0];
            this.giIdFactura = Convert.ToInt32(o);
            this.giNumero = (int)negociosAdaptadores.gAdaptadorDeConsultas.obtenerNumeroFacturaCliente(this.giIdFactura);
        }
        /// <summary>
        /// Función local para insertar todos los detalles de la factura en la base de datos.
        /// </summary>
        protected void fnvdInsertarDetallesFactura()
        {
            foreach (negociosDetalleFacturaCliente i in glstListaDetalleFactura)
            {
                i.setIdEncabezadoFacturaCliente(this.giIdFactura);
                i.fnsInsertarDetalleFacturaCliente();
            }
        }
        /// <summary>
        /// Función de acceso público en la cual se insertan todos los datos de la factura, encabezado y detalles
        /// </summary>
        /// <returns>string: mensaje de confirmación de la operación o de error en caso de falla</returns>
        public string fnInsertarFacturaCliente()
        {
            try
            {
                fnvdInsertarEncabezadoFacturaCliente();
                fnvdInsertarDetallesFactura();
                return "La factura fue ingresada exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
        #region Otras funciones
        /// <summary>
        /// Función para agregar un producto a la factura. Ésta función no se encarga de descargar el producto de la bodega
        /// </summary>
        /// <param name="lndfcProducto">negociosDetalleFacturaCliente: la especificación de precio y cantidad de producto comprado</param>
        public void fnvdAgregarProducto(negociosDetalleFacturaCliente lndfcProducto)
        {
            glstListaDetalleFactura.Add(lndfcProducto);
        }
        /// <summary>
        /// Función para quitar un producto de la factura. La cantidad solicitada del producto se devuelve a la bodega.
        /// </summary>
        /// <param name="liIdProducto">int: id del producto a eliminar</param>
        /// <returns>string: mensaje de confirmación de la operación o de error en caso de fallo</returns>
        public string fnsQuitarProducto(int liIdProducto)
        {
            try
            {
                short liIdProductoLocal = (short)liIdProducto;
                negociosDetalleFacturaCliente ndfcTemporal = null;
                foreach (negociosDetalleFacturaCliente i in this.glstListaDetalleFactura)
                {
                    if (i.getIdProducto() == liIdProductoLocal)
                    {
                        ndfcTemporal = i;
                        break;
                    }
                }
                glstListaDetalleFactura.Remove(ndfcTemporal);
                negociosProducto.fnvdAumentarExistenciaProducto(ndfcTemporal.getIdProducto(), ndfcTemporal.getCantidad());
                return "El producto se dió de baja de la factura con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
        /// <summary>
        /// Función para cancelar la operación de facturación. Devuelve todas las cantidades de todos los productos a la bodega.
        /// </summary>
        /// <returns>string: mensaje de confirmación de la operación o de error en caso de fallo</returns>
        public string fnsCancelarFactura()
        {
            try
            {
                foreach (negociosDetalleFacturaCliente i in glstListaDetalleFactura)
                {                    
                    negociosProducto.fnvdAumentarExistenciaProducto(i.getIdProducto(),i.getCantidad());
                }
                return "Se canceló la factura con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }            
        }
        #endregion
    }
}
