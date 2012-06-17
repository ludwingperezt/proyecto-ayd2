using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosTipoUsuario
    {
        private int liIdTipoUsuario;
        private string lsNombre;
        private string lsDescripcion;
        private int liNivelAcceso;
        private bool lboActivo;

        /// <summary>
        /// Constructor por defecto del objeto negociosTipoUsuario.
        /// Para establecer el valor de los campos deberá utilizar las funciones de modificación para cada campo.
        /// </summary>
        public negociosTipoUsuario()
        { }

        /// <summary>
        /// Constructor con parametros del objeto negociosTipoUsuario.
        /// </summary>
        /// <param name="liIdTipoUsuario">int: Id del tipo de usuario</param>
        /// <param name="lsNombre">string: Nombre del tipo de usuario</param>
        /// <param name="lsDescripcion">string: Descripcion del tipo de usuario</param>
        /// <param name="liNivelAcceso">int: Número que identifica qué nivel de acceso tendrán los usuarios de éste tipo</param>
        /// <param name="lboActivo">bool: Campo de activación o desactivación del tipo de usuario</param>
        public negociosTipoUsuario(int liIdTipoUsuario, string lsNombre, string lsDescripcion, int liNivelAcceso, bool lboActivo)
        {
            this.liIdTipoUsuario = liIdTipoUsuario;
            this.lsNombre = lsNombre;
            this.lsDescripcion = lsDescripcion;
            this.liNivelAcceso = liNivelAcceso;
            this.lboActivo = lboActivo;
        }

        #region region de funciones accesoras y modificadoras
        /// <summary>
        /// Función de acceso al ID del tipo de usuario
        /// </summary>
        /// <returns>int: el ID del tipo de usuario</returns>
        public int getIdTipoUsuario()
        {
            return this.liIdTipoUsuario;
        }
        /// <summary>
        /// Función de acceso al nombre del tipo de usuario
        /// </summary>
        /// <returns>string: el nombre del tipo de usuario</returns>
        public string getNombre()
        {
            return this.lsNombre;
        }
        /// <summary>
        /// Función de acceso a la descripción del tipo de usuario
        /// </summary>
        /// <returns>Cadena: Descripción del tipo de usuario</returns>
        public string getDescripcion()
        {
            return this.lsDescripcion;
        }
        /// <summary>
        /// Función de acceso al nivel de acceso del tipo de usuario
        /// </summary>
        /// <returns>int: el nivel de acceso representado por un número</returns>
        public int getNivelAcceso()
        {
            return this.liNivelAcceso;
        }
        /// <summary>
        /// Función de acceso al campo de activación/desactivación (eliminación) del tipo de usuario.
        /// </summary>
        /// <returns>bool: True si el tipo de usuario está activado, false si no lo está.</returns>
        public bool getActivo()
        {
            return this.lboActivo;
        }
        /// <summary>
        /// Función modificadora del campo ID del tipo de usuario
        /// </summary>
        /// <param name="liIdTipoUsuario">int: el ID de tipo de usuario que se desea asignar</param>
        public void setIdTipoUsuario(int liIdTipoUsuario)
        {
            this.liIdTipoUsuario = liIdTipoUsuario;
        }
        /// <summary>
        /// Función modificadora del campo nombre del tipo de usuario
        /// </summary>
        /// <param name="lsNombre">string: El nombre que se desea asignar al tipo de usuario</param>
        public void setNombre(string lsNombre)
        {
            this.lsNombre = lsNombre;
        }
        /// <summary>
        /// Función modificadora del campo Descripción del tipo de usuario
        /// </summary>
        /// <param name="lsDescripcion">string: Descripción del tipo de usuario</param>
        public void setDescripcion(string lsDescripcion)
        {
            this.lsDescripcion = lsDescripcion;
        }

        /// <summary>
        /// Función modificadora del campo Nivel de acceso del tipo de usuario
        /// </summary>
        /// <param name="liNivelAcceso">int: Número que representa los privilegios de acceso para el tipo de usuario</param>
        public void setNivelAcceso(int liNivelAcceso)
        {
            this.liNivelAcceso = liNivelAcceso;
        }
        /// <summary>
        /// Función modificadora del campo Activo del tipo de usuario
        /// </summary>
        /// <param name="lboActivo">bool: Campo de activación/desactivación (eliminación) del tipo de usuario. True es para activar, False para desactivar (eliminar).</param>
        public void setActivo(bool lboActivo)
        {
            this.lboActivo = lboActivo;
        }
        #endregion
        /// <summary>
        /// Función de modificación del tipo de usuario en la base de datos. Contempla los campos: nombre, descripción y nivel de acceso.
        /// Los nuevos datos de envío a la base de datos son los que contiene actualmente éste objeto.
        /// </summary>
        /// <returns>string: Cadena con el mensaje de confirmación o de error de la operación.</returns>
        public string fnModificarTipoUsuario()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarTiposUsuarios(this.liIdTipoUsuario, this.lsNombre, this.lsDescripcion, this.liNivelAcceso);
                return "La operación de modificación del tipo de usuario "+this.lsNombre+" se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de inserción de un nuevo tipo de usuario en la base de datos. Los datos usados para la inserción son los que almacena actualmente éste objeto.
        /// </summary>
        /// <returns>string: Cadena con el mensaje de confirmación o de error de la operación.</returns>
        public string fnInsertarTipoUsuario()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insertarTiposUsuarios(this.lsNombre, this.lsDescripcion, this.liNivelAcceso);
                return "La operación de inserción del nuevo tipo de usuario " + this.lsNombre + " se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de eliminación de la base de datos de éste tipo de usuario.
        /// </summary>
        /// <returns>string: Cadena con el mensaje de confirmación o de error de la operación.</returns>
        public string fnEliminarTipoUsuario()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.eliminarTipoUsuario(this.liIdTipoUsuario);
                return "La eliminación del tipo de usuario " + this.lsNombre + " se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de lista de todos los tipos de usuario en la base de datos.
        /// </summary>
        /// <returns>DataTable: La lista de todos los tipos de usuario en la base de datos.</returns>
        public DataTable fnMostrarTiposUsuario()
        {
            return negociosAdaptadores.gListarTiposUsuario.GetData();
        }
    }
}
