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

        //REGION DE FUNCIONES ACCESORAS Y MODIFICADORAS
        #region 
        /// <summary>
        /// Función modificadora del campo ID del puesto
        /// </summary>
        /// <param name="liIdPuesto">Entero: El nuevo id</param>
        public void setIdPuesto(int liIdPuesto)
        {
            this.liIdPuesto = liIdPuesto;
        }
        /// <summary>
        /// Función de acceso al campo ID del puesto
        /// </summary>
        /// <returns>Entero: el id del puesto</returns>
        public int getIdPuesto()
        {
            return this.liIdPuesto;
        }
        /// <summary>
        /// Función modificadora del campo NOMBRE del puesto
        /// </summary>
        /// <param name="lsNombre">Cadena: el nuevo nombre del puesto</param>
        public void setNombrePuesto(string lsNombre)
        {
            this.lsNombrePuesto = lsNombre;
        }
        /// <summary>
        /// Función de acceso al campo NOMBRE del puesto
        /// </summary>
        /// <returns>Cadena: el nombre del puesto</returns>
        public string getNombrePuesto()
        {
            return this.lsNombrePuesto;
        }
        /// <summary>
        /// Función modificadora del campo DESCRIPCION del puesto
        /// </summary>
        /// <param name="lsDescripcion">Cadena: la nueva descripcion del puesto</param>
        public void setDescripcionPuesto(string lsDescripcion)
        {
            this.lsDescripcionPuesto = lsDescripcion;
        }
        /// <summary>
        /// Función de acceso al campo DESCRIPCION del puesto
        /// </summary>
        /// <returns>Cadena: la descripcion del puesto</returns>
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
        /// <returns>Bool: True si el puesto está activo, False si el puesto fue desactivado (eliminado)</returns>
        public bool getActivo()
        {
            return this.lboActivo;
        }
        #endregion

        //REGION DE FUNCIONES DE ACCESO A LA BASE DE DATOS
        #region
        /// <summary>
        /// Función para insertar un nuevo Puesto a la base de datos. Funciona sobre el objeto this, por lo tanto, éste deberá tener como mínimo los campos NOMBRE y DESCRIPCION asignados.
        /// </summary>
        /// <returns>Cadena: Mensaje de confirmación o de error de la operación</returns>
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
        /// <returns>Cadena: Mensaje de confirmación o de error de la operación</returns>
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
        /// <returns>Cadena: Mensaje de confirmación o de error de la operación</returns>
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
        /// <summary>
        /// Función que obtiene la lista de todos los puestos en la base de datos
        /// </summary>
        /// <returns>DataTable: Lista de todos los puestos de la base de datos</returns>
        public DataTable fnListarPuestos()
        {
            return negociosAdaptadores.gListarPuestos.GetData();
        }
        #endregion
    }
}
