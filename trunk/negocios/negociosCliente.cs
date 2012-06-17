using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosCliente
    {
        private int liIdCliente;
        private int liIdTipoCliente;
        private String lsNombre;
        private String lsApellido;
        private String lsDireccion;
        private String lsNIT;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosCliente
        /// </summary>
        public negociosCliente() { }
        /// <summary>
        /// Constructor con parámetros del objeto negociosCliente que contempla el ID del tipo de cliente aplicado.
        /// </summary>
        /// <param name="liIdCliente">int: id del cliente</param>
        /// <param name="liIdTipoCliente">int: id del tipo de cliente aplicado a éste cliente</param>
        /// <param name="lsNombre">string: nombre del cliente</param>
        /// <param name="lsApellido">string: apellido del cliente</param>
        /// <param name="lsDireccion">string: dirección del cliente</param>
        /// <param name="lsNIT">string: NIT del cliente</param>
        public negociosCliente(int liIdCliente, int liIdTipoCliente, string lsNombre, string lsApellido, string lsDireccion, string lsNIT)
        {
            this.liIdCliente = liIdCliente;
            this.liIdTipoCliente = liIdTipoCliente;
            this.lsNombre = lsNombre;
            this.lsApellido = lsApellido;
            this.lsDireccion = lsDireccion;
            this.lsNIT = lsNIT;
        }
        /// <summary>
        /// Constructor con parámetros del objeto negociosCliente que no contempla el ID del tipo de cliente aplicado.
        /// </summary>
        /// <param name="liIdCliente">int: id del cliente</param>
        /// <param name="lsNombre">string: nombre del cliente</param>
        /// <param name="lsApellido">string: apellido del cliente</param>
        /// <param name="lsDireccion">>string: dirección del cliente</param>
        /// <param name="lsNIT">string: NIT del cliente</param>
        public negociosCliente(int liIdCliente, string lsNombre, string lsApellido, string lsDireccion, string lsNIT)
        {
            this.liIdCliente = liIdCliente;
            this.lsNombre = lsNombre;
            this.lsApellido = lsApellido;
            this.lsDireccion = lsDireccion;
            this.lsNIT = lsNIT;
        }
        #endregion
        #region funciones de acceso y modificación
        /// <summary>
        /// Función de acceso al campo ID del cliente.
        /// </summary>
        /// <returns>int: el ID del cliente</returns>
        public int getIdCliente()
        {
            return this.liIdCliente;
        }
        /// <summary>
        /// Función de acceso al campo Id del tipo de cliente aplicado al cliente que representa éste objeto.
        /// </summary>
        /// <returns>int: int del tipo de cliente.</returns>
        public int getIdTipoCliente()
        {
            return this.liIdTipoCliente;
        }
        /// <summary>
        /// Función de acceso al Nombre del cliente.
        /// </summary>
        /// <returns>string: el nombre del cliente.</returns>
        public string getNombre()
        {
            return this.lsNombre;
        }
        /// <summary>
        /// Función de acceso al Apellido del cliente.
        /// </summary>
        /// <returns>string: el apellido del cliente.</returns>
        public string getApellido()
        {
            return this.lsApellido;
        }
        /// <summary>
        /// Función de acceso a la Dirección del cliente.
        /// </summary>
        /// <returns>string: la dirección del cliente.</returns>
        public string getDireccion()
        {
            return this.lsDireccion;
        }
        /// <summary>
        /// Función de acceso al NIT del cliente.
        /// </summary>
        /// <returns>string: el NIT del cliente</returns>
        public string getNIT()
        {
            return this.lsNIT;
        }
        /// <summary>
        /// Función de modificación del campo ID del cliente
        /// </summary>
        /// <param name="liIdCliente">int: el ID del cliente a establecer</param>
        public void setIdCliente(int liIdCliente)
        {
            this.liIdCliente = liIdCliente;
        }
        /// <summary>
        /// Función de modificación del campo ID del tipo de cliente aplicado al cliente actual.
        /// </summary>
        /// <param name="liIdTipoCliente">int: ID del tipo de cliente a aplicar al cliente actual.</param>
        public void setIdTipoCliente(int liIdTipoCliente)
        {
        }
        /// <summary>
        /// Función de modificación del nombre del cliente
        /// </summary>
        /// <param name="lsNombre">string: el nombre del cliente</param>
        public void setNombre(string lsNombre)
        {
            this.lsNombre = lsNombre;
        }
        /// <summary>
        /// Función de modificación del apellido del cliente
        /// </summary>
        /// <param name="lsApellidos">string: el apellido del cliente</param>
        public void setApellido(string lsApellidos)
        {
            this.lsApellido = lsApellidos;
        }
        /// <summary>
        /// Función de modificación de la dirección del cliente
        /// </summary>
        /// <param name="lsDireccion">string: la dirección del cliente</param>
        public void setDireccion(string lsDireccion)
        {
            this.lsDireccion = lsDireccion;
        }
        /// <summary>
        /// Función de modificación del NIT del cliente.
        /// </summary>
        /// <param name="lsNIT">string: el NIT del cliente</param>
        public void setNIT(string lsNIT)
        {
            this.lsNIT = lsNIT;
        }
        #endregion
        #region funciones de acceso a la base de datos
        /// <summary>
        /// Función de inserción de un nuevo cliente a la base de datos. Ésta inserción envía los datos almacenados actualmente en éste objeto, hacia la base de datos.
        /// </summary>
        /// <returns>string: Mensaje de confirmación o de error de la operación</returns>
        public string insertarCliente()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insertarCliente(this.liIdTipoCliente, this.lsNombre, this.lsApellido, this.lsDireccion, this.lsNIT);
                return "La operación de inserción del cliente "+this.lsNombre+" "+this.lsApellido+" se realizó con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de modificación de datos del cliente. Los datos tomados para la modificación son los que actualmente se encuentran almacenados en éste objeto.
        /// </summary>
        /// <returns>string: Mensaje de confirmación o de error de la operación</returns>
        public string modificarCliente()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarCliente(this.liIdCliente, this.liIdTipoCliente, this.lsNombre, this.lsApellido, this.lsDireccion, this.lsNIT);
                return "La operación de modificación de datos del cliente " + this.lsNombre + " " + this.lsApellido + " se realizó con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
        #region funciones estáticas (listados y búsquedas)
        public static DataTable listarClientes()
        {
            return negociosAdaptadores.gListarClientes.GetData();
        }
        #endregion


    }
}
