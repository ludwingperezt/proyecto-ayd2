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
        /// <summary>
        /// Función de acceso al campo IdCliente, de la factura
        /// </summary>
        /// <param name="liIdCliente">int: id del cliente a quien se extiende la factura</param>
        public void setIdCliente(int liIdCliente)
        {
            this.giIdCliente = liIdCliente;
        }
        /// <summary>
        /// Función de modificaciòn del campo IdCliente, de la factura
        /// </summary>
        /// <returns>int: id del cliente a quien se extiende la factura</returns>
        public int getIdCliente()
        {
            return this.giIdCliente;
        }
        /// <summary>
        /// Función que retorna el detalle de factura
        /// </summary>
        /// <returns>List: objetos negociosDetalleFacturaCliente de todos los productos de la factura</returns>
        public List<negociosDetalleFacturaCliente> getDetalleFactura()
        {
            return this.glstListaDetalleFactura;
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
        public void fnvInsertarFacturaCliente()
        {
                fnvdInsertarEncabezadoFacturaCliente();
                fnvdInsertarDetallesFactura();
        }
        public void fnvCalcularDescuento(double descuento)
        {
            this.gdecTotal = 0;
            foreach (negociosDetalleFacturaCliente i in this.glstListaDetalleFactura)
            {
                gdecTotal += i.getMonto();
            }
            this.gduDescuento = descuento;
            this.gdecSubTotal = this.gdecTotal - (Convert.ToDecimal(descuento));
        }
        public decimal fndecCalcularTotal()
        {
            this.gdecTotal = 0;
            foreach (negociosDetalleFacturaCliente i in this.glstListaDetalleFactura)
            {
                gdecTotal += i.getMonto();
            }
            //this.gdecSubTotal = this.gdecTotal - (Convert.ToDecimal(this.getDescuento()));
            return this.gdecTotal;
        }
        public decimal fndecCalcularSubTotal()
        {
            this.gdecTotal = fndecCalcularTotal();
            this.gdecSubTotal = this.gdecTotal - (Convert.ToDecimal(this.getDescuento()));
            return this.gdecSubTotal;
        }
        #endregion
        #region Otras funciones
        /// <summary>
        /// Función para agregar un producto a la factura. Ésta función no se encarga de descargar el producto de la bodega
        /// </summary>
        /// <param name="lndfcProducto">negociosDetalleFacturaCliente: la especificación de precio y cantidad de producto comprado</param>
        public void fnvdAgregarProducto(negociosDetalleFacturaCliente lndfcProducto)
        {
            int index = -1;
            this.gdecTotal+=(lndfcProducto.getPrecio()*Convert.ToDecimal(lndfcProducto.getCantidad()));
            this.gdecSubTotal = this.gdecTotal - Convert.ToDecimal(this.gduDescuento);
            for (int i = 0; i < this.glstListaDetalleFactura.Count; i++ )
            {
                if (glstListaDetalleFactura[i].getIdProducto() == lndfcProducto.getIdProducto())
                {
                    index = i;
                    break;
                }
            }
            if (index > -1)
            {
                glstListaDetalleFactura[index].fnvAumentarCantidad(lndfcProducto.getCantidad());
            }
            else
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
                this.gdecTotal = this.gdecTotal - (ndfcTemporal.getPrecio()* Convert.ToDecimal(ndfcTemporal.getCantidad()));
                this.gdecSubTotal = this.gdecTotal - Convert.ToDecimal(this.gduDescuento);
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
        /// Función para quitar un producto de la factura. La cantidad solicitada del producto se devuelve a la bodega.
        /// </summary>
        /// <param name="liIndexDetalleProducto">int: indice del producto dentro de la lista de detalles</param>
        public void fnvQuitarProducto(int liIndexDetalleProducto)
        {
            negociosDetalleFacturaCliente ndfcTemporal = this.glstListaDetalleFactura[liIndexDetalleProducto];
            this.gdecTotal = this.gdecTotal - (ndfcTemporal.getPrecio() * Convert.ToDecimal(ndfcTemporal.getCantidad()));
            this.gdecSubTotal = this.gdecTotal - Convert.ToDecimal(this.gduDescuento);
            glstListaDetalleFactura.Remove(ndfcTemporal);
            negociosProducto.fnvdAumentarExistenciaProducto(ndfcTemporal.getIdProducto(), ndfcTemporal.getCantidad());             
        }
        /// <summary>
        /// Función que cambia la cantidad de un producto dentro de una factura
        /// </summary>
        /// <param name="liIndexDetalleProducto">int: indice del producto dentro de la lista de detalles</param>
        /// <param name="nuevaCantidad">double: la nueva cantidad</param>
        public void fnvCambiarCantidadProducto(int liIndexDetalleProducto, double nuevaCantidad)
        {
            negociosDetalleFacturaCliente ndfcTemporal = this.glstListaDetalleFactura[liIndexDetalleProducto];
            double cantidadActual = ndfcTemporal.getCantidad();

            //devolver
            this.gdecTotal = this.gdecTotal - ndfcTemporal.getMonto();
            this.gdecSubTotal = this.gdecTotal - Convert.ToDecimal(this.gduDescuento);
            negociosProducto.fnvdAumentarExistenciaProducto(ndfcTemporal.getIdProducto(), ndfcTemporal.getCantidad());
            
            //cambiar la cantidad
            ndfcTemporal.fnvCambiarCantidad(nuevaCantidad);

            //descargar la nueva cantidad
            if (negociosProducto.fnboVerificarCantidadExistenteProducto(ndfcTemporal.getIdProducto(), nuevaCantidad))
            {
                negociosProducto.fnvdDisminuirExistenciaProducto(ndfcTemporal.getIdProducto(), nuevaCantidad);
            }
            else
            {
                this.glstListaDetalleFactura.Remove(ndfcTemporal);
                throw new Exception("La cantidad no puede ser cambiada porque no existe suficiente producto en bodega. Se ha devuelto todo el producto a bodega.");
            }
            this.gdecTotal = this.gdecTotal + ndfcTemporal.getMonto();
            this.gdecSubTotal = this.gdecTotal + Convert.ToDecimal(this.gduDescuento);
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

        #region funciones para eliminar facturas de productos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtLocal"></param>
        /// <returns></returns>
        protected static List<negociosFacturaCliente> obtnerListaVisibleFactura(DataTable dtLocal)
        {
            List<negociosFacturaCliente> lst = new List<negociosFacturaCliente>();
            object[] objInstancia;
            for (int i = 0; i < dtLocal.Rows.Count; i++)
            {
                objInstancia = dtLocal.Rows[i].ItemArray;
                negociosFacturaCliente temporal = new negociosFacturaCliente();
                temporal.giIdFactura = (Convert.ToInt32(objInstancia[0]));
                temporal.giIdCliente = (Convert.ToInt32(objInstancia[1]));
                temporal.gbyIdEmpleado = (Convert.ToByte(objInstancia[2]));
                temporal.gsSerie = (Convert.ToString(objInstancia[3]));
                temporal.giNumero = (Convert.ToInt32(objInstancia[4]));
                temporal.gdtFecha = (Convert.ToDateTime(objInstancia[5]));
                temporal.gduDescuento = (Convert.ToDouble(objInstancia[6]));
                temporal.gdecSubTotal = (Convert.ToDecimal(objInstancia[7]));
                temporal.gdecTotal = (Convert.ToDecimal(objInstancia[8]));
                lst.Add(temporal);
            }
            return lst;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sizePage"></param>
        /// <param name="pageNum"></param>
        /// <returns></returns>
        public static List<negociosFacturaCliente> fnlstListarFacturas(int sizePage, int pageNum)
        {
            //IDFACTURACLIENTE,IDCLIENTE,IDEMPLEADO,SERIE,NUMERO,FECHA,DESCUENTO,SUBTOTAL,TOTAL
            //IDFACTURACLIENTE,IDCLIENTE,IDEMPLEADO,SERIE,NUMERO,FECHA,DESCUENTO,SUBTOTAL,TOTAL,ROW_NUMBER()
            return negociosFacturaCliente.obtnerListaVisibleFactura(negociosAdaptadores.gPaginacionFacturasClientes.GetData(sizePage, pageNum));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serie"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static List<negociosFacturaCliente> fnlstBuscarFacturaSerieNumero(string serie, int numero)
        {
            return negociosFacturaCliente.obtnerListaVisibleFactura(negociosAdaptadores.gBuscarFacturaSerieNumero.GetData(serie, numero));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idFactura"></param>
        /// <returns></returns>
        public static List<negociosDetalleFacturaCliente> fnlstObtenerDetalleFacturaCliente(int idFactura)
        {
            return negociosDetalleFacturaCliente.fnlstObtenerListaDetallesFactura(idFactura);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <param name="nota"></param>
        public void fnvInsertarFacturaEliminada(byte idEmpleado,string nota)
        {
            negociosAdaptadores.gAdaptadorGeneral.insertarFacturaEliminada(this.giIdFactura, idEmpleado, nota);
        }
        /// <summary>
        /// 
        /// </summary>
        public void fnvDevolverProductosFacturaEliminada()
        {
            negociosAdaptadores.gAdaptadorGeneral.devolverProductosDetallesFacturaEliminada(this.giIdFactura);
        }

        #endregion
    }
}
