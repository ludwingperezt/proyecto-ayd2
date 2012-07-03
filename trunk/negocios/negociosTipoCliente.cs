using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocios
{
    /// <summary>
    /// Clase para el manejo de tipo de cliente
    /// </summary>
    public class negociosTipoCliente
    {
        private int idTipoCliente;
        private string nombre;
        private string descripcion;
        private float descuento;
     #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosCliente
        /// </summary>
        public negociosTipoCliente()
        { 
        }
             public negociosTipoCliente(int isTipoCliente, string isNombre, string isdescripcion, float ifdescuento)
        {
            this.idTipoCliente = isTipoCliente;
            this.nombre = isNombre;
            this.descripcion = isdescripcion;
            this.descuento = ifdescuento;
        }
        #endregion
    }
}
