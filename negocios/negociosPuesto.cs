using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos.ConexionBaseDatosTableAdapters;
using System.Data;

namespace negocios
{
    public class negociosPuesto
    {
        private int liIdPuesto;
        private string lsNombrePuesto;
        private string lsDescripcionPuesto;
        private bool lboActivo;

        #region constructores
        /// <summary>
        /// Constructor del objeto negociosPuesto, por defecto. Para establecer el valor de los campos deberá utilizar las funciones de modificación para cada campo.
        /// </summary>
        public negociosPuesto()
        { 
        }

        /// <summary>
        /// Constructor sobrecargado del objeto negociosPuesto.
        /// </summary>
        /// <param name="liIdPuesto">int: el id del puesto que se está creando</param>
        /// <param name="lsNombre">string: el nombre del puesto</param>
        /// <param name="lsDescripcion">string: la descripción del puesto</param>
        /// <param name="lboActivo">bool: campo de activación o desactivación del puesto</param>
        public negociosPuesto(int liIdPuesto, string lsNombre, string lsDescripcion, bool lboActivo)
        {
            this.liIdPuesto = liIdPuesto;
            this.lsNombrePuesto = lsNombre;
            this.lsDescripcionPuesto = lsDescripcion;
            this.lboActivo = true;
        }
        #endregion
        #region REGION DE FUNCIONES ACCESORAS Y MODIFICADORAS
        /// <summary>
        /// Función modificadora del campo ID del puesto
        /// </summary>
        /// <param name="liIdPuesto">int: El nuevo id</param>
        public void setIdPuesto(int liIdPuesto)
        {
            this.liIdPuesto = liIdPuesto;
        }
        /// <summary>
        /// Función de acceso al campo ID del puesto
        /// </summary>
        /// <returns>int: el id del puesto</returns>
        public int getIdPuesto()
        {
            return this.liIdPuesto;
        }
        /// <summary>
        /// Función modificadora del campo NOMBRE del puesto
        /// </summary>
        /// <param name="lsNombre">string: el nuevo nombre del puesto</param>
        public void setNombrePuesto(string lsNombre)
        {
            this.lsNombrePuesto = lsNombre;
        }
        /// <summary>
        /// Función de acceso al campo NOMBRE del puesto
        /// </summary>
        /// <returns>string: el nombre del puesto</returns>
        public string getNombrePuesto()
        {
            return this.lsNombrePuesto;
        }
        /// <summary>
        /// Función modificadora del campo DESCRIPCION del puesto
        /// </summary>
        /// <param name="lsDescripcion">string: la nueva descripcion del puesto</param>
        public void setDescripcionPuesto(string lsDescripcion)
        {
            this.lsDescripcionPuesto = lsDescripcion;
        }
        /// <summary>
        /// Función de acceso al campo DESCRIPCION del puesto
        /// </summary>
        /// <returns>string: la descripcion del puesto</returns>
        public string getDescripcionPuesto()
        {
            return this.lsDescripcionPuesto;
        }
        /// <summary>
        /// Función de modificación del campo ACTIVO del puesto. Si desea "eliminar" el puesto, debe utilizar ésta función con un parámetro false
        /// </summary>
        /// <param name="lboActivo">bool: True para activar el puesto, False para desactivarlo (eliminarlo)</param>
        public void setActivo(bool lboActivo)
        {
            this.lboActivo = lboActivo;
        }
        /// <summary>
        /// Función de acceso al campo ACTIVO del puesto. Informa sobre el estado específico de un puesto.
        /// </summary>
        /// <returns>bool: True si el puesto está activo, False si el puesto fue desactivado (eliminado)</returns>
        public bool getActivo()
        {
            return this.lboActivo;
        }
        #endregion
        #region REGION DE FUNCIONES DE ACCESO A LA BASE DE DATOS
        /// <summary>
        /// Función para insertar un nuevo Puesto a la base de datos. Funciona sobre el objeto this, por lo tanto, éste deberá tener como mínimo los campos NOMBRE y DESCRIPCION asignados.
        /// </summary>
        /// <returns>string: Mensaje de confirmación o de error de la operación</returns>
        public string fnInsertarPuesto()
        {
            try
            {
                negocios.negociosAdaptadores.gAdaptadorDeConsultas.insertarPuesto(this.lsNombrePuesto,this.lsDescripcionPuesto);
                return "La operación de inserción se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de modificación de un puesto en la base de datos.
        /// </summary>
        /// <returns>string: Mensaje de confirmación o de error de la operación</returns>
        public string fnModificarPuesto()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarPuesto(this.liIdPuesto,this.lsNombrePuesto,this.lsDescripcionPuesto);
                return "La operación de modificación del puesto "+this.lsNombrePuesto+" se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función que envía la confirmación de eliminación (desactivación) de éste puesto de la base de datos.
        /// </summary>
        /// <returns>string: Mensaje de confirmación o de error de la operación</returns>
        public string fnEliminarPuesto()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.eliminarPuesto(this.liIdPuesto);
                return "La operación de eliminación del puesto "+this.lsNombrePuesto+" se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
        #region funciones estáticas (listados y búsquedas)
        /// <summary>
        /// Función que obtiene la lista de todos los puestos en la base de datos
        /// </summary>
        /// <returns>DataTable: Lista de todos los puestos de la base de datos</returns>
        public static DataTable fnListarPuestos()
        {
            return negociosAdaptadores.gListarPuestos.GetData();
        }
        #endregion
    }
}
