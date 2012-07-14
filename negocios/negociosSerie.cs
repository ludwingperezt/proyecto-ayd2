using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace negocios
{
    public class negociosSerie
    {
        private string lsSerie;
        private int liNumeroActual;
        private bool lboActiva;
        private int liLimite;
        private int liNumeroTerminal;
        private int liNumeroSucursal;

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
        /// <summary>
        /// Funcion de modificacion del campo IdTerminal al que pertenece la serie de facturas
        /// </summary>
        /// <param name="liIdTerminal">int: idTerminal al que pertenece la serie de facturas</param>
        public void setIdTerminal(int liIdTerminal)
        {
            this.liNumeroTerminal = liIdTerminal;
        }
        /// <summary>
        /// Función de acceso al campo idTerminal a la que pertenece la serie
        /// </summary>
        /// <returns>int: numero de terminal a la que pertenece la serie</returns>
        public int getIdTerminal()
        {
            return this.liNumeroTerminal;
        }
        /// <summary>
        /// Funcion de modificacion del campo IdSucursal
        /// </summary>
        /// <param name="liIdSucursal">int: la sucursal a la que pertenece la serie y la terminal</param>
        public void setIdSucursal(int liIdSucursal)
        {
            this.liNumeroSucursal = liIdSucursal;
        }
        /// <summary>
        /// Función de acceso al campo idSucursal a la que pertenece la serie y la terminal o estaciòn de trabajo
        /// </summary>
        /// <returns>int: el Id de la sucursal a la que pertenece la serie</returns>
        public int getIdSucursal()
        {
            return this.liNumeroSucursal;
        }
        /// <summary>
        /// Funciòn de modificaciòn del limite de la serie de facturas que se pueden emitir
        /// </summary>
        /// <param name="liLimite">int: En nùmero màximo de facturas que pueden ser emitidas por esta serie</param>
        public void setLimite(int liLimite)
        {
            this.liLimite = liLimite;
        }
        /// <summary>
        /// Funcion de acceso al campo limite, de la serie de facturas
        /// </summary>
        /// <returns>int: el numero màximo de facturas que se pueden emitir</returns>
        public int getLimite()
        {
            return this.liLimite;
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
                negociosAdaptadores.gAdaptadorDeConsultas.insertarSerieFactura(this.lsSerie, this.liNumeroActual, this.liLimite, (byte)this.liNumeroSucursal, (short)this.liNumeroTerminal);
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
            negociosAdaptadores.gAdaptadorDeConsultas.insertarSerieFactura(this.lsSerie, this.liNumeroActual, this.liLimite, (byte)this.liNumeroSucursal, (short)this.liNumeroTerminal);
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
        
        #endregion
        #region funciones de acceso estático
        /// <summary>
        /// Función que verifica la existencia de una serie de facturas de venta.
        /// </summary>
        /// <param name="lsSerie">string: el nombre de la serie a buscar</param>
        /// <returns>bool: True si la serie existe, False si no</returns>
        public static bool verificarExistenciaBaseSerie(string lsSerie)
        {
            string ConnectionString = "Data Source=ROLANDO-PC;Initial Catalog=textiles;Persist Security Info=True;User ID=textilesUser;Password=123";
            //string cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=textiles;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(ConnectionString);
            SqlCommand comando = new SqlCommand("verificarExistenciaSerie", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@serie", SqlDbType.Char, 3);
            comando.Parameters["@serie"].Value = lsSerie;
            comando.Parameters.Add(new SqlParameter("@RETORNO", SqlDbType.Bit));
            comando.Parameters["@RETORNO"].Direction = ParameterDirection.ReturnValue;
            conexion.Open();
            comando.ExecuteScalar();
            SqlParameter retorno = comando.Parameters["@RETORNO"];
            conexion.Close();
            return Convert.ToBoolean(retorno.Value);
        }
        /// <summary>
        /// Función que verifica la existencia de una serie de facturas de venta.
        /// </summary>
        /// <param name="lsSerie">string: el nombre de la serie a buscar</param>
        /// <returns>bool: True si la serie existe, False si no</returns>
        public static bool fnboVerificarExistenciaSerie(string lsSerie)
        {
            return (bool)negociosAdaptadores.gAdaptadorDeConsultas.verificarExistenciaSerie(lsSerie);
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
            //s.SERIE,s.ACTUAL,s.LIMITE,s.IDSUCURSAL,s.IDTERMINAL,s.ACTIVA
            DataTable dtLocal = negociosSerie.fnListarSeries();
            List<negociosSerie> lstSeries = new List<negociosSerie>();
            object[] objInstancia;
            for (int i = 0; i < dtLocal.Rows.Count; i++)
            {
                objInstancia = dtLocal.Rows[i].ItemArray;
                negociosSerie temporal = new negociosSerie();
                temporal.setSerie(Convert.ToString(objInstancia[0]));
                temporal.setNumeroActual(Convert.ToInt32(objInstancia[1]));
                temporal.setLimite(Convert.ToInt32(objInstancia[2]));
                temporal.setIdSucursal(Convert.ToInt32(objInstancia[3]));
                temporal.setIdTerminal(Convert.ToInt32(objInstancia[4]));
                temporal.setActiva(Convert.ToBoolean(objInstancia[5]));
                lstSeries.Add(temporal);
            }
            return lstSeries;
            //s.SERIE,s.ACTUAL,s.ACTIVA
        }
        /// <summary>
        /// Funcion que busca una serie, segun su codigo de serie
        /// </summary>
        /// <param name="lsSerie">string: la serie buscada</param>
        /// <returns>negociosSerie: el objeto que representa la serie encontrada. Si no existe se retorna null</returns>
        public static negociosSerie fnBuscarSeriePorSerie(string lsSerie)
        {
            DataTable dtLocal = negociosSerie.fnListarSeries();
            negociosSerie temporal=null;
            object[] objInstancia;
            if (dtLocal.Rows.Count > 0)
            {
                temporal = new negociosSerie();
                objInstancia = dtLocal.Rows[0].ItemArray;                
                temporal.setSerie(Convert.ToString(objInstancia[0]));
                temporal.setNumeroActual(Convert.ToInt32(objInstancia[1]));
                temporal.setLimite(Convert.ToInt32(objInstancia[2]));
                temporal.setIdSucursal(Convert.ToInt32(objInstancia[3]));
                temporal.setIdTerminal(Convert.ToInt32(objInstancia[4]));
                temporal.setActiva(Convert.ToBoolean(objInstancia[5]));                
            }
            return temporal;
        }
        /// <summary>
        /// Obtiene la ùnica serie activa para emisión de facturas
        /// </summary>
        /// <returns>negociosSerie: el objeto de la ùnica serie activa</returns>
        public static negociosSerie fnObtenerSerieActiva()
        {
            List<negociosSerie> lstSeries = negociosSerie.fnlstListaSeries();
            negociosSerie temporal = null;

            if (lstSeries.Count >= 1)
            {
                temporal = lstSeries[0];
            }

            return temporal;
        }
        /// <summary>
        /// Obtiene la ùnica serie activa para emisión de facturas, segùn el ID de la terminal
        /// </summary>
        /// <param name="idTerminal">int: el id de la terminal</param>
        /// <returns>negociosSerie: el objeto de la ùnica serie activa</returns>
        public static negociosSerie fnObtenerSerieActivaIdTerminal(int idTerminal)
        {
            return null;
        }
        /// <summary>
        /// Funciòn que retorna la lista de todas las series en la base de datos (la serie activa y las no activas que no han sido usadas), menos las series vencidas
        /// </summary>
        /// <returns></returns>
        public static List<negociosSerie> fnlstListarSeriesTodas()
        {
            return null;
        }
        #endregion
    }
}
