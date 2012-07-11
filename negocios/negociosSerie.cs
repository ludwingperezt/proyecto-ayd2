using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosSerie
    {
        private string lsSerie;
        private int liNumeroActual;
        private bool lboActiva;

        #region constructures
        /// <summary>
        /// Constructor por defecto del objeto negociosSeries
        /// </summary>
        public negociosSerie()
        { 
        }
        /// <summary>
        /// Constructor con parámetros del objeto negociosSerie
        /// </summary>
        /// <param name="lsSerie">sting: la serie asignada</param>
        /// <param name="liNumero">int: el número actual para la serie</param>
        /// <param name="lboActiva">bool: True si la serie está asignada, False si está desactivada</param>
        public negociosSerie(string lsSerie,int liNumero, bool lboActiva)
        {
            this.lsSerie = lsSerie;
            this.liNumeroActual = liNumero;
            this.lboActiva = lboActiva;
        }
        #endregion
        #region funciones de acceso y modificacion
        /// <summary>
        /// Función de modificación del campo serie
        /// </summary>
        /// <param name="lsSerie">string: serie que se desea asignar a la serie</param>
        public void setSerie(string lsSerie)
        {
            this.lsSerie = lsSerie;
        }
        /// <summary>
        /// Función de modificación del número correlativo actual de la serie
        /// </summary>
        /// <param name="liActual">int: número que se quiere asignar a la serie</param>
        public void setNumeroActual(int liActual)
        {
            this.liNumeroActual = liActual;
        }
        /// <summary>
        /// Función de modificación del campo activo de la serie
        /// </summary>
        /// <param name="lboActiva">bool: True para activar la serie, False para desactivarla</param>
        public void setActiva(bool lboActiva)
        {
            this.lboActiva = lboActiva;
        }
        /// <summary>
        /// Función de acceso al campo serie
        /// </summary>
        /// <returns>string: la serie</returns>
        public string getSerie()
        {
            return this.lsSerie;
        }
        /// <summary>
        /// Función de acceso al numero actual de la serie
        /// </summary>
        /// <returns>int: numero actual de la serie</returns>
        public int getNumeroActual()
        {
            return this.liNumeroActual;
        }
        /// <summary>
        /// Función de acceso al campo activo de la serie
        /// </summary>
        /// <returns>bool: True si está activa, False si no está activa.</returns>
        public bool getActiva()
        {
            return this.lboActiva;
        }
        #endregion
        #region funciones de acceso a la base de datos
        /// <summary>
        /// Función de inserción de una nueva serie a la base de datos. Los datos que se envían para la inserción son los que actualmente están en éste objeto.
        /// </summary>
        /// <returns>string: Mensaje de confirmación de inserción o de error en caso de falla.</returns>
        public string fnsInsertarSerie()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insertarSerieFactura(this.lsSerie,this.liNumeroActual);
                return "La serie se insertó correctamente";
            }
            catch (Exception ex)
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarSerie(this.lsSerie,this.liNumeroActual);
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de inserción de una nueva serie a la base de datos. Los datos que se envían para la inserción son los que actualmente están en éste objeto.
        /// </summary>
        public void fnvInsertarSerie()
        {
            negociosAdaptadores.gAdaptadorDeConsultas.insertarSerieFactura(this.lsSerie, this.liNumeroActual);
        }
        /// <summary>
        /// Función de modificación de una serie. En esta función el único dato que puede ser modificado es el número actual en el que se encuentra la serie.
        /// El nombre de la serie ('a','b',etc) no puede ser modificado.
        /// </summary>
        /// <returns>string: Mensaje de confirmación de inserción o de error en caso de falla.</returns>
        public string fnsModificarSerie()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarSerie(this.lsSerie, this.liNumeroActual);
                return "La serie se modificó correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de modificación de una serie. En esta función el único dato que puede ser modificado es el número actual en el que se encuentra la serie.
        /// El nombre de la serie ('a','b',etc) no puede ser modificado.
        /// </summary>
        public void fnvModificarSerie()
        {
            negociosAdaptadores.gAdaptadorDeConsultas.modificarSerie(this.lsSerie, this.liNumeroActual);
        }
        /// <summary>
        /// Función que elimina la serie actual de la base de datos.
        /// </summary>
        /// <returns>string: Mensaje de confirmación de inserción o de error en caso de falla.</returns>
        public string fnsEliminarSerie()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.darDeBajaSerie(this.lsSerie);
                return "La serie se eliminó correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función que elimina la serie actual de la base de datos.
        /// </summary>
        public void fnvEliminarSerie()
        {
           
                negociosAdaptadores.gAdaptadorDeConsultas.darDeBajaSerie(this.lsSerie);
             
        }
        /// <summary>
        /// Función de consulta de todas las series activas en la base de datos.
        /// </summary>
        /// <returns>DataTable: la lista de todas las series que se encuentran en la base de datos</returns>
        public DataTable fnDTListarSeries()
        {
            return negociosAdaptadores.gAdaptadorListaSeries.GetData();
        }
        /// <summary>
        /// Función de acceso estático de consulta de todas las series activas en la base de datos.
        /// </summary>
        /// <returns>DataTable: la lista de todas las series que se encuentran en la base de datos</returns>
        public static DataTable fnListarSeries()
        {
            return negociosAdaptadores.gAdaptadorListaSeries.GetData();
        }
        /// <summary>
        /// Devuelve una lista de objetos de tipo negociosSerie, que representan las tuplas en la tabla series
        /// </summary>
        /// <returns>List de negociosSerie: cada objeto representa una tupla en la tabla series</returns>
        public static List<negociosSerie> fnlstListaSeries()
        {
            DataTable dtLocal = negociosSerie.fnListarSeries();
            List<negociosSerie> lstSeries = new List<negociosSerie>();
            object[] objInstancia;
            for (int i = 0; i < dtLocal.Rows.Count; i++)
            {
                objInstancia = dtLocal.Rows[i].ItemArray;
                negociosSerie temporal = new negociosSerie();
                temporal.setSerie(Convert.ToString(objInstancia[0]));
                temporal.setNumeroActual(Convert.ToInt32(objInstancia[1]));
                temporal.setActiva(Convert.ToBoolean(objInstancia[2]));
                lstSeries.Add(temporal);
            }
            return lstSeries;
            //s.SERIE,s.ACTUAL,s.ACTIVA
        }
        #endregion
    }
}
