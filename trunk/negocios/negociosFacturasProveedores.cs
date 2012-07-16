using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace negocios
{
    public class negociosFacturasProveedores
    {
        private int idFacturaProveedor;
        private int idProveedor;
        private int idEmpleado;
        private string serie;
        private int numero;
        private DateTime fecha;
        private decimal total;//
        private List<negociosDetallesFacturasProveedores> lndfpDetallesFactura;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosFacturaProveedores
        /// </summary>
        public void negociosFacturaProveedores()
        {
            this.lndfpDetallesFactura = new List<negociosDetallesFacturasProveedores>();
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

        public List<negociosDetallesFacturasProveedores> getListaDetallesFacturaProveedor()
        {
            return this.lndfpDetallesFactura;
        }

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

        /// <summary>
        /// Funcion para cancelar la factura del proveedor indicada de la base de datos
        /// </summary>
        /// <param name="sAnotacion"></param>
        /// <returns>string: mensaje de confirmacion</returns>
        public string fnsDevolverFacturaProveedor(string sAnotacion)
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.darDeBajaFacturaProveedor(this.idFacturaProveedor, sAnotacion);
                foreach (negociosDetallesFacturasProveedores i in this.lndfpDetallesFactura)
                {
                    //if (negociosProducto.fnboVerificarCantidadExistenteProducto((short)i.getIdProducto(), Convert.ToDouble(i.getCantidad())))
                    //{
                        negociosProducto.fnvdDisminuirExistenciaProducto((short)i.getIdProducto(), Convert.ToDouble(i.getCantidad()));
                    //}
                    //else
                    //    return "Producto: " + negociosProducto.fnObtenerProductoPorId(i.getIdProducto()).getNombre() + ", insuficiente para devolucion";
                }
                return "Factura Eliminada Exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }   
        }

        /// <summary>
        /// Función que devuelve a las ultimas 20 compras
        /// </summary>
        /// <returns>DataTable: devuelve las ultimas 20 compras</returns>
        public static DataTable fnDbDevolverVeinteCompras()
        {
            return negociosAdaptadores.gAdaptadorUltimasVeinteCompras.GetData();
        }
        public static List<negociosFacturasProveedores> fnslListarUltimasVeinteCompras()
        {
            List<negociosFacturasProveedores> lnpFacturaProveedores = new List<negociosFacturasProveedores>();
            try
            {
                DataTable ldtFacturaProveedores = negociosFacturasProveedores.fnDbDevolverVeinteCompras();
                object[] oListaElmentos;
                for (int i = 0; i < ldtFacturaProveedores.Rows.Count; i++)
                {
                    oListaElmentos = ldtFacturaProveedores.Rows[i].ItemArray;
                    negociosFacturasProveedores npNuevaFacturaProveedores = new negociosFacturasProveedores();
                    npNuevaFacturaProveedores.setIdProveedor(Convert.ToByte(oListaElmentos[1]));
                    npNuevaFacturaProveedores.setIdEmpleado(Convert.ToByte(oListaElmentos[2]));
                    npNuevaFacturaProveedores.setSerie(Convert.ToString(oListaElmentos[3]));
                    npNuevaFacturaProveedores.setNumero(Convert.ToInt32(oListaElmentos[4]));
                    npNuevaFacturaProveedores.setFecha(Convert.ToDateTime(oListaElmentos[5]));
                    npNuevaFacturaProveedores.setTotal(Convert.ToDecimal(oListaElmentos[6]));
                    lnpFacturaProveedores.Add(npNuevaFacturaProveedores);
                }
                return lnpFacturaProveedores;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static DataTable fnDbDevolverFacturaSerieNumero(int numero, string serie)
        {
            return negociosAdaptadores.gAdaptadorDevolverIdFactura.GetData(numero,serie);
        }
        public static List<negociosFacturasProveedores> fnslListarFacturaSerieNumero(int numeroF, string serieF)
        {
            List<negociosFacturasProveedores> lnpFacturaProveedores = new List<negociosFacturasProveedores>();
            try
            {
                DataTable ldtFacturaProveedores = negociosFacturasProveedores.fnDbDevolverFacturaSerieNumero(numeroF,serieF);
                object[] oListaElmentos;
                for (int i = 0; i < ldtFacturaProveedores.Rows.Count; i++)
                {
                    oListaElmentos = ldtFacturaProveedores.Rows[i].ItemArray;
                    negociosFacturasProveedores npNuevaFacturaProveedores = new negociosFacturasProveedores();
                    npNuevaFacturaProveedores.setIdFacturaProveedor(Convert.ToInt32(oListaElmentos[0]));
                    npNuevaFacturaProveedores.setIdProveedor(Convert.ToByte(oListaElmentos[1]));
                    npNuevaFacturaProveedores.setIdEmpleado(Convert.ToByte(oListaElmentos[2]));
                    npNuevaFacturaProveedores.setSerie(Convert.ToString(oListaElmentos[3]));
                    npNuevaFacturaProveedores.setNumero(Convert.ToInt32(oListaElmentos[4]));
                    npNuevaFacturaProveedores.setFecha(Convert.ToDateTime(oListaElmentos[5]));
                    npNuevaFacturaProveedores.setTotal(Convert.ToDecimal(oListaElmentos[6]));
                    lnpFacturaProveedores.Add(npNuevaFacturaProveedores);
                }
                return lnpFacturaProveedores;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion
    }

}
