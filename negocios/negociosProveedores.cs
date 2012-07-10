using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{  

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
        #endregion
        
        #region Comunicacion con la DB
        /// <summary>
        /// Funcion para listar todos los proveedores existentes
        /// </summary>
        /// <returns>DataTable: Tabla con la lista de los proveedores</returns>
        public DataTable fnsListarProveedores()
        {
            return negociosAdaptadores.gAdaptadorListarProveedores.GetData();
        }

        /// <summary>
        /// Funcion para insertar un nuevo proveedor en la base de datos
        /// </summary>
        /// <returns>string: mensaje de confirmacion de la insersion</returns>
        public string fnsInsertarProveedor()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insersionProveedor(this.nombre, this.nit, this.direccion, this.empresa, this.propietario, this.telefono, this.celular);
                return "La inserción del cliente en la base de datos se llevó a cabo con éxito";

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
                return "La modificación de los datos del cliente se llevó a cabo con éxito";
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
                return "La modificación de los datos del cliente se llevó a cabo con éxito";
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
                return "La modificación de los datos del cliente se llevó a cabo con éxito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        /// <summary>
        /// Funcion para buscar a un proveedor por su nit
        /// </summary>
        /// <returns>DataTable: Tabla con la tupla del proveedor</returns>
        public DataTable fnsBuscarProveedorNit(string nitProveedor)
        {

                return negociosAdaptadores.gAdaptadorRegistroProveedor.GetData(nitProveedor);
        }
        #endregion
    }
}
