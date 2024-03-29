﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{  
    /// <summary>
    /// Clase para el manejo de proveedores
    /// </summary>
    public class negociosProveedores
    {
        private int id;
        private string nombre;
        private string nit;
        private string direccion;
        private string empresa;
        private string propietario;
        private string telefono;
        private string celular;
        private bool activo;

        #region Constructores
        public negociosProveedores(string sNombre, string sNit, string sDir, string sEmpresa, string sPropietario, string sTel, string sCel)
        {
            this.id = 0;
            this.nombre = sNombre;
            this.nit = sNit;
            this.direccion = sDir;
            this.empresa = sEmpresa;
            this.propietario = sPropietario;
            this.telefono = sTel;
            this.celular = sCel;
            this.activo = true;
        }
        public negociosProveedores()
        {
            this.activo = true;
        }
        #endregion

        #region Accesores y modificadores
        /// <summary>
        /// Grupo de funciones para modificar los valores de la clase
        /// </summary>
        /// <param name="lsNomb">String: dato a registrar en la clase</param>
        
        public void setNombre (string lsNomb)
        {
            this.nombre = lsNomb;
        }

        public void setId(int liId)
        {
            this.id = liId;
        }

        public void setNit (string lsNit)
        {
            this.nit = lsNit;
        }

        public void setDireccion (string lsDir)
        {
            this.direccion = lsDir;
        }

        public void setEmpresa(string lsEmpresa)
        {
            this.empresa = lsEmpresa;
        }

        public void setPropietario(string lsPropietario)
        {
            this.propietario = lsPropietario;
        }

        public void setTelefono (string lsTel)
        {
            this.telefono = lsTel;
        }

        public void setCelular (string lsCel)
        {
            this.celular = lsCel;
        }

        public void setEstado(bool lbEstado)
        {
            this.activo = lbEstado;
        }

        /// <summary>
        /// Grupo de funciones para leer los datos de la clase
        /// </summary>
        /// <returns>string: dato solicitado dependiendo de la funcion</returns>
        public string getNombre()
        {
            return this.nombre;
        }


        public string getNit()
        {
            return this.nit;
        }

        public string getDireccion()
        {
            return this.direccion;
        }

        public string getEmpresa()
        {
            return this.empresa;
        }

        public string getPropietario()
        {
            return this.propietario;
        }

        public string getTelefono()
        {
            return this.telefono;
        }

        public string getCelular()
        {
            return this.celular;
        }

        public int getId()
        {
            return this.id;
        }

        public string getEstado()
        {
            if (this.activo)
            {
                return "Activo";
            }
            else
                return "Inactivo";        
        }

        public bool  getEstadoBool()
        {
            return this.activo;
        }
        #endregion
        
        #region Comunicacion con la DB
        #region Acceso estatico
        /// <summary>
        /// Funcion para listar todos los proveedores existentes
        /// </summary>
        /// <returns>DataTable: Tabla con la lista de los proveedores</returns>
        public static DataTable fnsDTListarProveedores()
        {
            try
            {
                return negociosAdaptadores.gAdaptadorListarProveedores.GetData();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        protected static List<negociosProveedores> construirLista(DataTable lstnpDTProveedores)
        {
            List<negociosProveedores> lstnpProveedores = new List<negociosProveedores>();
            object[] oListaElmentos;
            for (int i = 0; i < lstnpDTProveedores.Rows.Count; i++)
            {
                oListaElmentos = lstnpDTProveedores.Rows[i].ItemArray;
                negociosProveedores npNuevoProveedor = new negociosProveedores();
                npNuevoProveedor.setId(Convert.ToInt16(oListaElmentos[0]));
                npNuevoProveedor.setNombre(Convert.ToString(oListaElmentos[1]));
                npNuevoProveedor.setNit(Convert.ToString(oListaElmentos[2]));
                npNuevoProveedor.setDireccion(Convert.ToString(oListaElmentos[3]));
                npNuevoProveedor.setEmpresa(Convert.ToString(oListaElmentos[4]));
                npNuevoProveedor.setPropietario(Convert.ToString(oListaElmentos[5]));
                npNuevoProveedor.setTelefono(Convert.ToString(oListaElmentos[6]));
                npNuevoProveedor.setCelular(Convert.ToString(oListaElmentos[7]));
                npNuevoProveedor.setEstado(Convert.ToBoolean(oListaElmentos[8]));
                
                lstnpProveedores.Add(npNuevoProveedor);
            }
            return lstnpProveedores;
        }

        public static List<negociosProveedores> fnslListarProveedores()
        {
            List<negociosProveedores> lnpProveedores = new List<negociosProveedores>();
            
                DataTable ldtProveedores = negociosProveedores.fnsDTListarProveedores();
                object[] oListaElmentos;
                for (int i = 0; i < ldtProveedores.Rows.Count; i++)
                {
                    oListaElmentos = ldtProveedores.Rows[i].ItemArray;
                    negociosProveedores npNuevoProveedor = new negociosProveedores();
                    npNuevoProveedor.setId(Convert.ToInt16(oListaElmentos[0]));
                    npNuevoProveedor.setNombre(Convert.ToString(oListaElmentos[1]));
                    npNuevoProveedor.setNit(Convert.ToString(oListaElmentos[2]));
                    npNuevoProveedor.setDireccion(Convert.ToString(oListaElmentos[3]));
                    npNuevoProveedor.setEmpresa(Convert.ToString(oListaElmentos[4]));
                    npNuevoProveedor.setPropietario(Convert.ToString(oListaElmentos[5]));
                    npNuevoProveedor.setTelefono(Convert.ToString(oListaElmentos[6]));
                    npNuevoProveedor.setCelular(Convert.ToString(oListaElmentos[7]));
                    npNuevoProveedor.setEstado(Convert.ToBoolean(oListaElmentos[8]));
                    lnpProveedores.Add(npNuevoProveedor);
                }
                return lnpProveedores;
            
        }

        public static List<negociosProveedores> fnslPaginacionProveedores(int iTamañoPagina, int iNumeroPagina)
        {
            return negociosProveedores.construirLista(negociosAdaptadores.gAdaptadorPaginacionProveedores.GetData(iTamañoPagina,iNumeroPagina));
        }

        public static List<negociosProveedores> fnslBuscarProveedorPorEstado(bool bEstado)
        {
            List<negociosProveedores> lnpProveedores = new List<negociosProveedores>();
            return lnpProveedores = negociosProveedores.construirLista(negociosAdaptadores.gAdaptadorBuscarProveedorPorEstado.GetData(bEstado));
        }

        public static negociosProveedores fnnpBuscarProveedorPorId(int iId)
        {
            List<negociosProveedores> temporal = negociosProveedores.construirLista(negociosAdaptadores.gAdapatadorBuscarProveedorPorId.GetData((short)iId));
            if (temporal.Count == 0)
            {
                return null;
            }
            else return temporal[0];

        }

        public static List<negociosProveedores> fnslBuscarProveedorPorNit(string sNit)
        {
            List<negociosProveedores> lstnpProveedores = new List<negociosProveedores>();
            DataTable lstnpDTProveedores = negociosAdaptadores.gAdaptadorBuscarProveedorPorNit.GetData(sNit);
            object[] oListaElmentos;
            for (int i = 0; i < lstnpDTProveedores.Rows.Count; i++)
            {
                oListaElmentos = lstnpDTProveedores.Rows[i].ItemArray;
                negociosProveedores npNuevoProveedor = new negociosProveedores();
                npNuevoProveedor.setId(Convert.ToInt16(oListaElmentos[0]));
                npNuevoProveedor.setNombre(Convert.ToString(oListaElmentos[1]));
                npNuevoProveedor.setDireccion(Convert.ToString(oListaElmentos[2]));
                npNuevoProveedor.setEmpresa(Convert.ToString(oListaElmentos[3]));
                npNuevoProveedor.setPropietario(Convert.ToString(oListaElmentos[4]));
                npNuevoProveedor.setTelefono(Convert.ToString(oListaElmentos[5]));
                npNuevoProveedor.setCelular(Convert.ToString(oListaElmentos[6]));
                npNuevoProveedor.setEstado(Convert.ToBoolean(oListaElmentos[7]));
                npNuevoProveedor.setNit(Convert.ToString(oListaElmentos[8]));
                lstnpProveedores.Add(npNuevoProveedor);
            }
            return lstnpProveedores;     
        }

        public static List<negociosProveedores> fnslBuscarProveedorPorPropietario(string sPropietario)
        {
            List<negociosProveedores> lnpProveedores = new List<negociosProveedores>();
            
                return lnpProveedores = negociosProveedores.construirLista(negociosAdaptadores.gAdaptadorBuscarProveedorPorPropietario.GetData(sPropietario));
            
        }

        public static List<negociosProveedores> fnslBuscarProveedorPorNombre(string sNombre)
        {
            List<negociosProveedores> lnpProveedores = new List<negociosProveedores>();
            
                return lnpProveedores = negociosProveedores.construirLista(negociosAdaptadores.gAdaptadorBuscarProveedorPorNombre.GetData(sNombre));
            
        }

        public static List<negociosProveedores> fnslBuscarProveedorPorEmpresa(string sEmpresa)
        {
            List<negociosProveedores> lnpProveedores = new List<negociosProveedores>();
            return lnpProveedores = negociosProveedores.construirLista(negociosAdaptadores.gAdaptadorBuscarProveedorPorEmpresa.GetData(sEmpresa));
        }
        #endregion

        #region acceso no estatico
        /// <summary>
        /// Funcion para insertar un nuevo proveedor en la base de datos
        /// </summary>
        /// <returns>string: mensaje de confirmacion de la insersion</returns>
        public string fnsInsertarProveedor()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insersionProveedor(this.nombre, this.nit, this.direccion, this.empresa, this.propietario, this.telefono, this.celular);
                return "La inserción del proveedor en la base de datos se llevó a cabo con éxito";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// Funcion para modificar a un proveedor existente en la base de datos
        /// </summary>
        /// <returns>string: mensaje de confirmacion de la modificacion</returns>
        public string fnsModificarProveedor()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarProveedor((short)this.id, this.nombre, this.nit, this.direccion, this.empresa, this.propietario, this.telefono, this.celular);
                return "La modificación de los datos del proveedor se llevó a cabo con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// Funcion para "eliminar" a un proveedor de la base de datos (cambiarlo a inactivo)
        /// </summary>
        /// <returns>string: mensaje de confirmacion de la modificacion</returns>
        public string fnsDarDeBajaProveedor()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.darDeBajaProveedor((short)this.id);
                //this.activo = false;
                return "La modificación de los datos del proveedor se llevó a cabo con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// Funcion para restaurar a un proveedor de la base de datos (cambiarlo a activo)
        /// </summary>
        /// <returns>string: mensaje de confirmacion de la modificacion</returns>
        public string fnsDarDeAltaProveedor()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.darDeAltaProveedor((short)this.id);
                return "La modificación de los datos del proveedor se llevó a cabo con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        #endregion
        #endregion
    }
}
