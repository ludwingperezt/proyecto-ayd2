using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocios
{
    /// <summary>
    /// Clase para el manejo de clientes
    /// </summary>
    public class negociosCliente
    {
       private string nit;
       private int idTipoCliente;
       private string nombre;
       private string apellido;
       private string direccion;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosCliente
        /// </summary>
        public negociosCliente()
        { 
        }
             public negociosCliente(string sNitCliente, int iIDTipoCliente, string sNombreCliente, string sApellidoCliente, string sDireccionCliente)
        {
            this.nombre = sNombreCliente;
            this.nit = sNitCliente;
            this.idTipoCliente = iIDTipoCliente;
            this.apellido = sApellidoCliente;
            this.direccion = sDireccionCliente;
        }
        #endregion
    }
}
