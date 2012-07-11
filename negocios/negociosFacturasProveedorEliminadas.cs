using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosFacturasProveedorEliminadas
    {
        private int idFactura;
        private byte idEmpleado;
        private DateTime fecha;
        private string anotacion;

        #region constructores
        public negociosFacturasProveedorEliminadas(int liIdFactura, byte liIdEmpleado, DateTime ldtFecha, string lsAnotacion)
        {
            this.idFactura = liIdFactura;
            this.idEmpleado = liIdEmpleado;
            this.fecha = ldtFecha;
            this.anotacion = lsAnotacion;
        }
        public negociosFacturasProveedorEliminadas()
        {
        }
        #endregion

        #region Accesores y modificadores de los campos de la clase

        /// <summary>
        /// Grupo de funciones para modificar los valores de los campos de la 
        /// clase
        /// </summary>
        /// <param name="liId">int: valor a registrar en la clase</param>
        public void setIdFactura(int liId)
        {
            this.idFactura = liId;
        }

        public void setIdEmpleado(byte liId)
        {
            this.idEmpleado = liId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ldtFecha">DateTime: fecha a registrar en la clase</param>
        public void setFecha(DateTime ldtFecha)
        {
            this.fecha = ldtFecha;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lsAnotacion">string: anotacion a registrar en la clase</param>
        public void setAnotacion(string lsAnotacion)
        {
            this.anotacion = lsAnotacion;
        }

        /// <summary>
        /// Grupo de funciones para acceder a los campos
        /// de la clase
        /// </summary>
        /// <returns></returns>
        public int getIdFactura()
        {
            return this.idFactura;
        }

        public byte getIdEmpleado()
        {
            return this.idEmpleado;
        }

        public DateTime getFecha()
        {
            return this.fecha;
        }

        public string getAnotacion()
        {
            return this.anotacion;
        }
        #endregion

        #region Funciones de comunicacion con la BD
        /// <summary>
        /// Funcion para insertar una nueva factura a la tabla de FacturasProveedorEliminadas
        /// </summary>
        /// <returns>string: mensaje de confirmacion de la insersion</returns>
        public string fnvdInsersionFacturaProveedorEliminada()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insersionFacturaProveedorEliminada(this.idFactura, this.idEmpleado, this.fecha, this.anotacion);
                return "La factura fue registrada exitosamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// Funcion para modificar una factura de la tabla de FacturasProveedorEliminadas
        /// </summary>
        /// <returns>string: mensaje de confirmacion de la modificacion</returns>
        public string fnModificacionFacturaProveedorEliminada()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarFacutraProveedorEliminada(this.idFactura, this.idEmpleado, this.fecha, this.anotacion);
                return "La factura fue modificada exitosamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// Funcion para eliminar una factura de la tabla de FacturasProveedorEliminadas
        /// </summary>
        /// <returns>string: mensaje de confirmacion de la eliminacion</returns>
        public string fnEliminarFacturaProveedorEliminada()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.eliminarFacturaProveedorEliminada(this.idFactura);
                return "La factura fue eliminada exitosamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static DataTable fnsListarFacturasProveedorEliminadas()
        {
            return negociosAdaptadores.gAdaptadorListarFacturasProveedorEliminadas.GetData();
        }
        #endregion
    }
}
