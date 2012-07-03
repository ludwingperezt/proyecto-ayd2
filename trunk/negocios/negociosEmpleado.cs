using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocios
{
    /// <summary>
    /// Clase para el manejo de empleados
    /// </summary>
    public class negociosEmpleado
    {
      private int idEmpleado;
      private int idRol;
      private string nombre;
      private string apellido;
      private string direccion;
      private string telefono;
      private string celular;
      private string puesto;
      private DateTime fechaContratacion;
      private double salario;
      private string usuario;
      private string password; //es tipo binary ¿?
      private Boolean habilitado;

      #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosEmpelado
        /// </summary>
        public negociosEmpleado()
        { 
        }
             public negociosEmpleado(int iIdEmpleado, int iIdRolEmpleado, string isNombreEmpleado, string isApellidoEmpleado, string isDireccionEmpleado, string isTelefonoEmpleado, string isCelularEmpleado, string isPuestoEmpleado, DateTime iDateFechaContratacion, double iDoSalario, string isUsuario, string isPassword, Boolean iboolHabilitado)
        {
            this.idEmpleado = iIdEmpleado;
            this.idRol = iIdRolEmpleado;
            this.nombre = isNombreEmpleado;
            this.apellido = isApellidoEmpleado;
            this.direccion = isDireccionEmpleado;
            this.telefono = isTelefonoEmpleado;
            this.celular = isCelularEmpleado;
            this.puesto = isPuestoEmpleado;
            this.fechaContratacion = iDateFechaContratacion;
            this.salario = iDoSalario;
            this.usuario = isUsuario;
            this.password = isPassword;
            this.habilitado = iboolHabilitado;
        }
        #endregion
    }
}
