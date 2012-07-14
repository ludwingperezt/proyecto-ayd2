using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    /// <summary>
    /// Clase para el manejo de clientes
    /// </summary>
    public class negociosCliente
    {
        private int idCliente;
       private string nit;
       private byte idTipoCliente;
       private string nombre;
       private string direccion;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosCliente
        /// </summary>
        public negociosCliente()
        { 
        }
             public negociosCliente(string sNitCliente, byte iByteDTipoCliente, string sNombreCliente, string sDireccionCliente)
        {
            this.nombre = sNombreCliente;
            this.nit = sNitCliente;
            this.idTipoCliente = iByteDTipoCliente;
            this.direccion = sDireccionCliente;
        }
        #endregion

        #region métodos accesores y modificadores
             /// <summary>
             /// Método que accede al nit del cliente
             /// </summary>
             /// <returns>string: el nit del cliente</returns>
             public string getNitCliente()
             {
                 return this.nit;
             }
             /// <summary>
             /// Método que accede al Nombre del cliente
             /// </summary>
             /// <returns>string: el nombre del cliente</returns>
             public string getNombreCliente()
             {
                 return this.nombre;
             }
             /// <summary>
             /// Método que accede al Identificador del tipo del cliente
             /// </summary>
             /// <returns>byte: el identificador del tipo del cliente</returns>
             public byte getIdTipoCliente()
             {
                 return this.idTipoCliente;
             }
             /// <summary>
             /// Método que accede a la direccion del cliente
             /// </summary>
             /// <returns>string :la direccion del cliente</returns>
             public string getDireccionCliente()
             {
                 return this.direccion;
             }
             /// <summary>
             /// Método modificador del campo nit del cliente
             /// </summary>
             /// <param name="lsNit">string: el nit del cliente</param>
             public void setNitCliente(string lsNit)
             {
                 this.nit = lsNit;
             }
             /// <summary>
             /// Método modificador del campo id tipo del cliente
             /// </summary>
             /// <param name="lIIdTipo">int: el id del tipo del cliente del cliente</param>
             public void setNitCliente(byte lIIdTipo)
             {
                 this.idTipoCliente = lIIdTipo;
             }
             /// <summary>
             /// Método modificador del campo nombre del cliente
             /// </summary>
             /// <param name="lsNombre">string: el nombre del cliente</param>
             public void setNombreCliente(string lsNombre)
             {
                 this.nombre = lsNombre;
             }

             /// <summary>
             /// Método modificador del campo direccion del cliente
             /// </summary>
             /// <param name="lsDireccion">string: la direccion del cliente</param>
             public void setDireccionCliente(string lsDireccion)
             {
                 this.direccion = lsDireccion;
             }

             public void setIdCliente(int idCliente)
             {
                 this.idCliente = idCliente;
             }
             public int getIdCliente()
             {
                 return this.idCliente;
             }
             public void setIdTipoCliente(int idTipoCliente)
             {
                 this.idTipoCliente = (byte)idTipoCliente;
             }
             #endregion

        #region Métodos de comunicación con la base de datos
             /// <summary>
             /// Método que inserta un nuevo cliente a la base de datos.
             /// Los datos que se envían a la base de datos son los que se encuentran contenidos actualmente en éste objeto.
             /// </summary>
             /// <returns>string: mensaje de confirmación o error de la operación</returns>
             public string fnsInsertarCliente()
             {
                 try
                 {
                     negociosAdaptadores.gAdaptadorDeConsultas.insertarCliente(this.idTipoCliente,this.nombre,this.direccion,this.nit);
                     return "La inserción del cliente en la base de datos se llevó a cabo con éxito";
                 }
                 catch (Exception ex)
                 {
                     return ex.Message;
                 }

             }
             /// <summary>
             /// Método que modifica del cliente. Los datos que se utilizan para la modificación son los que se encuentran almacenados en el objeto actual.
             /// </summary>
             /// <returns>string: mensaje de confirmación o error de la operación</returns>
             public string fnsModificarCliente()
             {
                 try
                 {
                     negociosAdaptadores.gAdaptadorDeConsultas.ModificarCliente(this.idTipoCliente, this.nombre, this.direccion, this.nit);
                     return "La modificación de los datos del cliente se llevó a cabo con éxito";
                 }
                 catch (Exception ex)
                 {
                     return ex.Message;
                 }
             }
             /// <summary>
             /// Función que lista a los clientes
             /// </summary>
             /// <returns>DataTable: lista de los clientes de la base de datos.</returns>
             public static DataTable fnDbListarClientes()
             {
                 return negociosAdaptadores.gAdaptadorListarClientes.GetData();
             }
             /// <summary>
             /// Función que busca a un cliente por nombre
             /// </summary>
             /// <returns>DataTable: me devuelve a un cliente buscado por nombre</returns>
             public static DataTable fnDbBuscarClienteNombre(string nombreCliente)
             {
                 return negociosAdaptadores.gAdaptadorClienteNombre.GetData(nombreCliente);

             }
             /// <summary>
             /// Función que busca a un cliente por nit
             /// </summary>
             /// <returns>DataTable: me devuelve a un cliente buscado por nit</returns>
             public static DataTable fnDbBuscarClienteNit(string SnitCliente)
             {
                 return negociosAdaptadores.gAdaptadorClienteNit.GetData(SnitCliente);
             }
             public static negociosCliente fnnaBuscarClienteNit(string lsNit)
             {
                 DataTable dtLocal = negociosCliente.fnDbBuscarClienteNit(lsNit);
                 negociosCliente temporal = null;
                 object[] objInstancia;
                 if (dtLocal.Rows.Count > 0)
                 {
                     temporal = new negociosCliente();
                     objInstancia = dtLocal.Rows[0].ItemArray;
                     temporal.setIdCliente(Convert.ToInt32(objInstancia[0]));
                     temporal.setIdTipoCliente(Convert.ToInt32(objInstancia[1]));
                     temporal.setNitCliente(Convert.ToString(objInstancia[2]));
                     temporal.setNombreCliente(Convert.ToString(objInstancia[3]));
                     temporal.setDireccionCliente(Convert.ToString(objInstancia[4]));
                 }
                 return temporal;
             }
             public void fnvInsertarCliente()
             {
                     negociosAdaptadores.gAdaptadorDeConsultas.insertarCliente(this.idTipoCliente, this.nombre, this.direccion, this.nit);
             }
             #endregion
    }
}
