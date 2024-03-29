﻿using System;
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
       private negociosTipoCliente ntcTipoCliente;

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCliente"></param>
             public void setIdCliente(int idCliente)
             {
                 this.idCliente = idCliente;
             }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
             public int getIdCliente()
             {
                 return this.idCliente;
             }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idTipoCliente"></param>
             public void setIdTipoCliente(int idTipoCliente)
             {
                 this.idTipoCliente = (byte)idTipoCliente;
             }
             #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ntc"></param>
             public void setTipoCliente(negociosTipoCliente ntc)
             {
                 this.ntcTipoCliente = ntc;
             }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
             public negociosTipoCliente getTipoCliente()
             {
                 return this.ntcTipoCliente;
             }

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
                     negociosAdaptadores.gAdaptadorDeConsultas.ModificarCliente(getIdCliente(),getIdTipoCliente(),getNombreCliente(),getDireccionCliente(),getNitCliente());
                     return "La modificación de los datos del cliente se llevó a cabo con éxito";
                 }
                 catch (Exception ex)
                 {
                     return ex.Message;
                 }
             }
             public static DataTable fnDbDevolverVeinteClientes()
             {
                 return negociosAdaptadores.gAdaptadorBuscarVeinteClientes.GetData();
             }
             public static List<negociosCliente> fnsVeinteClientes()
             {
                 List<negociosCliente> lnpCliente = new List<negociosCliente>();
                 try
                 {
                     DataTable ldtClientes = negocios.negociosCliente.fnDbDevolverVeinteClientes();
                     object[] oListaElmentos;
                     for (int i = 0; i < ldtClientes.Rows.Count; i++)
                     {
                         oListaElmentos = ldtClientes.Rows[i].ItemArray;
                         negociosCliente npNuevoCliente = new negociosCliente();
                         npNuevoCliente.setIdCliente(Convert.ToByte(oListaElmentos[0]));
                         npNuevoCliente.setIdTipoCliente(Convert.ToByte(oListaElmentos[1]));
                         npNuevoCliente.setNitCliente(Convert.ToString(oListaElmentos[2]));
                         npNuevoCliente.setNombreCliente(Convert.ToString(oListaElmentos[3]));
                         npNuevoCliente.setDireccionCliente(Convert.ToString(oListaElmentos[4]));
                         lnpCliente.Add(npNuevoCliente);
                     }
                     return lnpCliente;
                 }
                 catch (Exception e)
                 {
                     return null;
                 }
             }
             public static DataTable fnDbBuscarClienteNombre1(string snombreCliente)
             {
                 return negociosAdaptadores.gAdaptadorClienteNombre.GetData(snombreCliente);
             }
             public static List<negociosCliente> fnsClienteNombre(string sNombre)
             {
                 List<negociosCliente> lnpCliente = new List<negociosCliente>();
                 try
                 {
                     DataTable ldtClientes = negocios.negociosCliente.fnDbBuscarClienteNombre1(sNombre);
                     object[] oListaElmentos;
                     for (int i = 0; i < ldtClientes.Rows.Count; i++)
                     {
                         oListaElmentos = ldtClientes.Rows[i].ItemArray;
                         negociosCliente npNuevoCliente = new negociosCliente();
                         npNuevoCliente.setIdCliente(Convert.ToByte(oListaElmentos[0]));
                         npNuevoCliente.setIdTipoCliente(Convert.ToByte(oListaElmentos[1]));
                         npNuevoCliente.setNitCliente(Convert.ToString(oListaElmentos[2]));
                         npNuevoCliente.setNombreCliente(Convert.ToString(oListaElmentos[3]));
                         npNuevoCliente.setDireccionCliente(Convert.ToString(oListaElmentos[4]));
                         lnpCliente.Add(npNuevoCliente);
                     }
                     return lnpCliente;
                 }
                 catch (Exception e)
                 {
                     return null;
                 }
             }
              public static DataTable fnDbBuscarClienteNit1(string snitCliente)
             {
                 return negociosAdaptadores.gAdaptadorClientePorNit2.GetData(snitCliente);
             }
             public static List<negociosCliente> fnsClienteNit(string sNit)
             {
                 List<negociosCliente> lnpCliente = new List<negociosCliente>();
                 try
                 {
                     DataTable ldtClientes = negocios.negociosCliente.fnDbBuscarClienteNit1(sNit);
                     object[] oListaElmentos;
                     for (int i = 0; i < ldtClientes.Rows.Count; i++)
                     {
                         oListaElmentos = ldtClientes.Rows[i].ItemArray;
                         negociosCliente npNuevoCliente = new negociosCliente();
                         npNuevoCliente.setIdCliente(Convert.ToByte(oListaElmentos[0]));
                         npNuevoCliente.setIdTipoCliente(Convert.ToByte(oListaElmentos[1]));
                         npNuevoCliente.setNitCliente(Convert.ToString(oListaElmentos[2]));
                         npNuevoCliente.setNombreCliente(Convert.ToString(oListaElmentos[3]));
                         npNuevoCliente.setDireccionCliente(Convert.ToString(oListaElmentos[4]));
                         lnpCliente.Add(npNuevoCliente);
                     }
                     return lnpCliente;
                 }
                 catch (Exception e)
                 {
                     return null;
                 }
             }
             public static DataTable fnDbBuscarClienteDireccion1(string sdireccionCliente)
             {
                 return negociosAdaptadores.gAdaptadorClientePorDireccion.GetData(sdireccionCliente);
             }
             public static List<negociosCliente> fnsClienteDireccion1(string sdireccion)
             {
                 List<negociosCliente> lnpCliente = new List<negociosCliente>();
                 try
                 {
                     DataTable ldtClientes = negocios.negociosCliente.fnDbBuscarClienteDireccion1(sdireccion);
                     object[] oListaElmentos;
                     for (int i = 0; i < ldtClientes.Rows.Count; i++)
                     {
                         oListaElmentos = ldtClientes.Rows[i].ItemArray;
                         negociosCliente npNuevoCliente = new negociosCliente();
                         npNuevoCliente.setIdCliente(Convert.ToByte(oListaElmentos[0]));
                         npNuevoCliente.setIdTipoCliente(Convert.ToByte(oListaElmentos[1]));
                         npNuevoCliente.setNitCliente(Convert.ToString(oListaElmentos[2]));
                         npNuevoCliente.setNombreCliente(Convert.ToString(oListaElmentos[3]));
                         npNuevoCliente.setDireccionCliente(Convert.ToString(oListaElmentos[4]));
                         lnpCliente.Add(npNuevoCliente);
                     }
                     return lnpCliente;
                 }
                 catch (Exception e)
                 {
                     return null;
                 }
             }
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lsNit"></param>
        /// <returns></returns>
             public static negociosCliente fnnaBuscarClienteNit(string lsNit)
             {
                 DataTable dtLocal = negociosAdaptadores.gAdaptadorBcn.GetData(lsNit);
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
        /// <summary>
        /// 
        /// </summary>
             public void fnvInsertarCliente()
             {
                     negociosAdaptadores.gAdaptadorDeConsultas.insertarCliente(this.idTipoCliente, this.nombre, this.direccion, this.nit);
             }
        /// <summary>
        /// 
        /// </summary>
             public void fnvinsertarclienteCF()
             {
                 DataTable dtLocal = negociosAdaptadores.gAdaptadorBuquedaExactaClNombreDireccion.GetData(this.nombre, this.direccion);
                 if ((dtLocal.Rows.Count > 1) || ((dtLocal.Rows.Count == 0))) //si la bùsqueda exacta de los datos del cliente por nombre y por direccion no retornan resultados o si retornan màs de un resultado, se inserta la tupla del cliente y se obtiene el Id del cliente insertado
                 {
                     DataTable dtResult = negociosAdaptadores.gAdaptadorInsClDevolverId.GetData(this.idTipoCliente, this.nit, this.nombre, this.direccion);
                     object o = dtResult.Rows[0].ItemArray[0];
                     this.idCliente = Convert.ToInt32(o);
                 }
                 else
                 {
                     object[] objInstancia = dtLocal.Rows[0].ItemArray;
                     this.idCliente = (Convert.ToInt32(objInstancia[0]));                    
                     this.setIdTipoCliente(Convert.ToInt32(objInstancia[1]));
                     this.setNitCliente(Convert.ToString(objInstancia[2]));
                     this.setNombreCliente(Convert.ToString(objInstancia[3]));
                     this.setDireccionCliente(Convert.ToString(objInstancia[4]));                     
                 }
             }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
             public static negociosCliente fnncObtenerClienteYTipo(int id)
             {
                 negociosCliente temporal = null;
                 DataTable dtLocal = negociosAdaptadores.gAdaptadorClienteTipoCliente.GetData(id);
                 if (dtLocal.Rows.Count > 0)
                 {
                     object[] objInstancia = dtLocal.Rows[0].ItemArray;
                     temporal = new negociosCliente();
                     temporal.setIdCliente(id);
                     //c.IDTIPOCLIENTE,c.NIT,c.NOMBRE,c.DIRECCION,t.NOMBRE,t.DESCRIPCION,t.DESCUENTO
                     temporal.setIdTipoCliente(Convert.ToInt32(objInstancia[0]));
                     temporal.setNitCliente(Convert.ToString(objInstancia[1]));
                     temporal.setNombreCliente(Convert.ToString(objInstancia[2]));
                     temporal.setDireccionCliente(Convert.ToString(objInstancia[3]));

                     negociosTipoCliente ntcTemp = new negociosTipoCliente();
                     ntcTemp.setIdTipoCliente((byte)temporal.getIdCliente());
                     ntcTemp.setNombreTipoCliente(Convert.ToString(objInstancia[4]));
                     ntcTemp.setDescripcionTipoCliente(Convert.ToString(objInstancia[5]));
                     ntcTemp.setDescuentoTipoCliente((float)Convert.ToDouble(objInstancia[6]));

                     temporal.setTipoCliente(ntcTemp);
                 }
                 return temporal;
             }
             #endregion


    }
}
