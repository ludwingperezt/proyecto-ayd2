using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosTipoCliente
    {
        private int liIdTipoCliente;
        private string lsNombre;
        private string lsDescripcion;
        private double lDescuento;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosTipoCliente
        /// </summary>
        public negociosTipoCliente() { }
        /// <summary>
        /// Constructor con parámetros del objeto negociosTipoCliente (categoría de cliente)
        /// </summary>
        /// <param name="liIdTipoCliente">int: id del tipo de cliente</param>
        /// <param name="lsNombre">string: nombre de la categoría de cliente</param>
        /// <param name="lsDescripcion">string: descripción de la categoría de cliente</param>
        /// <param name="lDescuento">double: porcentaje de descuento para la categoría de cliente</param>
        public negociosTipoCliente(int liIdTipoCliente, string lsNombre, string lsDescripcion, double lDescuento) 
        {
            this.liIdTipoCliente = liIdTipoCliente;
            this.lsNombre = lsNombre;
            this.lsDescripcion = lsDescripcion;
            this.lDescuento = lDescuento;
        }
        #endregion
        #region funciones de acceso y modificación
        /// <summary>
        /// Función de modificación del ID del tipo de cliente
        /// </summary>
        /// <param name="liIdTipoCliente"></param>
        public void setIdTipoCliente(int liIdTipoCliente)
        {
            this.liIdTipoCliente = liIdTipoCliente;
        }
        /// <summary>
        /// Función de modificación del nombre de la categoría de cliente
        /// </summary>
        /// <param name="lsNombre">string: nombre de la categoría</param>
        public void setNombre(string lsNombre)
        {
            this.lsNombre = lsNombre;
        }
        /// <summary>
        /// Función de modificación de la descripción del tipo de cliente
        /// </summary>
        /// <param name="lsDescripcion">string: la descripción de la categoría</param>
        public void setDescripcion(string lsDescripcion)
        {
            this.lsDescripcion = lsDescripcion;
        }
        /// <summary>
        /// Función de modificación del descuento para el tipo de cliente
        /// </summary>
        /// <param name="lDescuento">double: porcentaje de descuento</param>
        public void setDescuento(double lDescuento)
        {
            this.lDescuento = lDescuento;
        }
        /// <summary>
        /// Función de acceso al campo ID del tipo de cliente (categoría de cliente)
        /// </summary>
        /// <returns>int: id del tipo de cliente</returns>
        public int getIdTipoCliente()
        {
            return this.liIdTipoCliente;
        }
        /// <summary>
        /// Función de acceso al campo Nombre del tipo de cliente (categoría de cliente)
        /// </summary>
        /// <returns>string: nombre de la categoría</returns>
        public string getNombre()
        {
            return this.lsNombre;
        }
        /// <summary>
        /// Función de acceso al campo Descripcion del tipo de cliente (categoría de cliente)
        /// </summary>
        /// <returns>string: descripción de la categoría</returns>
        public string getDescripcion()
        {
            return this.lsDescripcion;
        }
        /// <summary>
        /// Función de acceso al campo Descuento del tipo de cliente (categoría de cliente)
        /// </summary>
        /// <returns>double: porcentaje de descuento</returns>
        public double getDescuento()
        {
            return this.lDescuento;
        }
        #endregion
        #region funciones de acceso a la base de datos
        /// <summary>
        /// Función de inserción de un nuevo tipo de cliente (categoría de cliente) en la base de datos.
        /// Para realizar la inserción, se envían a la base de datos, los datos que se encuentran almacenados actualmente en éste objeto.
        /// </summary>
        /// <returns>string: Mensaje de confirmación o de error de la operación</returns>
        public string insertarTipoCliente()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insertarTipoCliente(this.lsNombre, this.lsDescripcion, this.lDescuento);
                return "La operación de inserción de la categoría de cliente "+this.lsNombre+" se finalizó con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de modificación de un tipo de cliente (categoría de cliente) existente en la base de datos.
        /// Para realizar la modificación, se envían a la base de datos, los datos que se encuentran almacenados actualmente en éste objeto.
        /// </summary>
        /// <returns></returns>
        public string modificarTipoCliente()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarTipoCliente(this.liIdTipoCliente,this.lsNombre, this.lsDescripcion, this.lDescuento);
                return "La operación de modificación de datos de la categoría de cliente " + this.lsNombre + " se finalizó con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
        #region funciones estáticas (búsquedas y listados)
        /// <summary>
        /// Función de listado de todos los tipos (categorías) de clientes que existen en la base de datos.
        /// </summary>
        /// <returns>DataTable: listado de todos los tipos de cliente</returns>
        public DataTable mostrarTiposCliente()
        {
            return negociosAdaptadores.gListarTiposCliente.GetData();
        }
        #endregion
    }
}
