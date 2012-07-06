using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    /// <summary>
    /// Clase para el manejo de tipo de cliente
    /// </summary>
    public class negociosTipoCliente
    {
        private byte idTipoCliente;
        private string nombre;
        private string descripcion;
        private float descuento;
        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosCliente
        /// </summary>
        public negociosTipoCliente()
        { 
        }
             public negociosTipoCliente(int isTipoCliente, string isNombre, string isdescripcion, float ifdescuento)
        {
            this.idTipoCliente = isTipoCliente;
            this.nombre = isNombre;
            this.descripcion = isdescripcion;
            this.descuento = ifdescuento;
        }
        #endregion

        #region métodos accesores y modificadores
             /// <summary>
             /// Método que accede al id del Tipo de cliente
             /// </summary>
             /// <returns>byte: id del tipo del cliente</returns>
             public byte getIdTipoCliente()
             {
                 return this.idTipoCliente;
             }
             /// <summary>
             /// Método que accede al Nombre del tipo de cliente
             /// </summary>
             /// <returns>string: el nombre del tipo de cliente</returns>
             public string getNombreTipoCliente()
             {
                 return this.nombre;
             }
             /// <summary>
             /// Método que accede a la descripcion del tipo de cliente
             /// </summary>
             /// <returns>string: la descripcion del tipo del cliente</returns>
             public string getDescripcionTipoCliente()
             {
                 return this.descripcion;
             }
             /// <summary>
             /// Método que accede al descuento del tipo del cliente
             /// </summary>
             /// <returns>float: descuento del tipo de cliente </returns>
             public float getDescuentoTipoCliente()
             {
                 return this.descuento;
             }
             /// <summary>
             /// Método modificador del id tipo de cliente
             /// </summary>
             /// <param name="liTipoCliente">int: id del  tipo de cliente</param>
             public void setIdTipoCliente(byte liTipoCliente)
             {
                 this.idTipoCliente = liTipoCliente;
             }
             /// <summary>
             /// Método modificador del campo nombre del tipo de cliente
             /// </summary>
             /// <param name="lsNombreTipoCliente">string: el nombre del tipo de cliente</param>
             public void setNombreTipoCliente(string lsNombreTipoCliente)
             {
                 this.nombre = lsNombreTipoCliente;
             }
             /// <summary>
             /// Método modificador del campo descripcion del  tipo de cliente
             /// </summary>
             /// <param name="lsDescripcionTipoCliente">string: descripcion del tipo de cliente</param>
             public void setDescripcionTipoCliente(string lsDescripcionTipoCliente)
             {
                 this.descripcion = lsDescripcionTipoCliente;
             }
             /// <summary>
             /// Método modificador del campo descuento del tipo de cliente
             /// </summary>
             /// <param name="lfldescuentoTipoCliente">float: descuento del tipo de cliente</param>
             public void setDescuentoTipoCliente(float lfldescuentoTipoCliente)
             {
                 this.descuento = lfldescuentoTipoCliente;
             }
             #endregion

        #region Métodos de comunicación con la base de datos
             /// <summary>
             /// Método que inserta un nuevo tipo de cliente a la base de datos.
             /// Los datos que se envían a la base de datos son los que se encuentran contenidos actualmente en éste objeto.
             /// </summary>
             /// <returns>string: mensaje de confirmación o error de la operación</returns>
             public string fnsInsertarTipoCliente()
             {
                 try
                 {
                     negociosAdaptadores.gAdaptadorDeConsultas.insertarTipoCliente(this.idTipoCliente,this.nombre,this.descripcion,this.descuento);
                     return "La inserción del tipo de cliente en la base de datos se llevó a cabo con éxito";
                 }
                 catch (Exception ex)
                 {
                     return ex.Message;
                 }

             }
             /// <summary>
             /// Método que modifica el tipo de cliente. Los datos que se utilizan para la modificación son los que se encuentran almacenados en el objeto actual.
             /// </summary>
             /// <returns>string: mensaje de confirmación o error de la operación</returns>
             public string fnsModificarTipoCliente()
             {
                 try
                 {
                     negociosAdaptadores.gAdaptadorDeConsultas.ModificarTipoCliente(this.idTipoCliente, this.nombre, this.descripcion, this.descuento);
                     return "La modificación de los datos de tipos de  clientes se llevó a cabo con éxito";
                 }
                 catch (Exception ex)
                 {
                     return ex.Message;
                 }
             }
             /// <summary>
             /// Función que lista a los tipos de clientes
             /// </summary>
             /// <returns>DataTable: lista de los tipos de clientes de la base de datos.</returns>
             public static DataTable fnDbListarTiposClientes()
             {
                 return negociosAdaptadores.gAdaptadorListarTiposClientes.GetData();
             }
             #endregion
    }
}
