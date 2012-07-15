using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Security.Cryptography;

namespace negocios
{
    /// <summary>
    /// Clase para el manejo de empleados
    /// </summary>
    public class negociosEmpleado
    {
        private byte idEmpleado;
        private byte idRol;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private string celular;
        private string puesto;
        private DateTime fechaContratacion;
        private decimal salario;
        private string usuario;
        private byte[] password = new byte[20];
        private Boolean habilitado;
        private string dpiCedula;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosEmpelado
        /// </summary>
        public negociosEmpleado()
        {
        }
        public negociosEmpleado(byte iIdEmpleado, byte iIdRolEmpleado, string isNombreEmpleado, string isApellidoEmpleado, string isDireccionEmpleado, string isTelefonoEmpleado, string isCelularEmpleado, string isPuestoEmpleado, DateTime iDateFechaContratacion, decimal iDoSalario, string isUsuario, byte[] isPassword, Boolean iboolHabilitado, string isdpiCedula)
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
            this.dpiCedula = isdpiCedula;
        }
        #endregion

        #region métodos accesores y modificadores
        /// <summary>
        /// Método que accede al id del Empleado 
        /// </summary>
        /// <returns>byte: el id del empleado</returns>
        public byte getIdEmpleado()
        {
            return this.idEmpleado;
        }
        /// <summary>
        /// Método que accede al id del rol del empleado
        /// </summary>
        /// <returns>byte: el id del rol del empleado</returns>
        public byte getIdRolEmpleado()
        {
            return this.idRol;
        }
        /// <summary>
        /// Método que accede al nombre del empleado
        /// </summary>
        /// <returns>string: el nombre del empleado</returns>
        public string getNombreEmpleado()
        {
            return this.nombre;
        }
        /// <summary>
        /// Método que accede al apellido del empleado
        /// </summary>
        /// <returns>string: el apellido del empleado </returns>
        public string getApellidoEmpleado()
        {
            return this.apellido;
        }
        /// <summary>
        /// Método que accede a la direccion del empleado
        /// </summary>
        /// <returns>string :la direccion del empleado</returns>
        public string getDireccionEmpleado()
        {
            return this.direccion;
        }
        /// <summary>
        /// Método que accede al campo telefono del empleado
        /// </summary>
        /// <return>string: el telefono del empleado</param>
        public string getTelefonoEmpleado()
        {
            return this.telefono;
        }
        /// <summary>
        /// Método que accede al campo celular del empleado
        /// </summary>
        /// <return>string: el celular del empleado</param>
        public string getCelularEmpleado()
        {
            return this.celular;
        }
        /// <summary>
        /// Método que accede al campo puesto del empleado
        /// </summary>
        /// <return>string: el puesto del empleado</param>
        public string getPuestoEmpleado()
        {
            return this.puesto;
        }
        /// <summary>
        /// Método que accede a la fecha de contratacion del empleado
        /// </summary>
        /// <return>dateTime: la fecha de contratacion del empleado</param>
        public DateTime getFechaDeContratacion()
        {
            return this.fechaContratacion;
        }
        /// <summary>
        /// Método que accede al campo salario del empleado
        /// </summary>
        /// <return>: el salario del empleado</param>
        public decimal getSalarioEmpleado()
        {
            return this.salario;
        }
        /// <summary>
        /// Método que accede al campo usuario del empleado
        /// </summary>
        /// <return>string: el usuario del empleado</param>
        public string getUsuarioEmpleado()
        {
            return this.usuario;
        }
        /// <summary>
        /// Método que accede al campo password del empleado
        /// </summary>
        /// <return>byte: el password del empleado</param>
        public byte[] getPasswordEmpleado()
        {
            return this.password;
        }
        /// <summary>
        /// Método que accede al campo habilitado del empleado
        /// </summary>
        /// <return>Boolean: el bit de habilitado del empleado</param>
        public Boolean getHabilitadoEmpleado()
        {
            return this.habilitado;
        }
        /// <summary>
        /// Método que accede al campo dpiCedula del empleado
        /// </summary>
        /// <return>string: el numero de la cedula o dpi del empleado</param>
        public string getDpiCedula()
        {
            return this.dpiCedula;
        }
        /// <summary>
        /// Método modificador el campo id del empleado
        /// </summary>
        /// <param name="lIdEmpleado">byte: el id del empleado</param>
        public void setIdEmpleado(byte lIIdEmpleado)
        {
            this.idEmpleado = lIIdEmpleado;
        }
        /// <summary>
        /// Método modificador el campo id del rol del empleado
        /// </summary>
        /// <param name="lIdRolEmpleado">byte: el id del rol del empleado</param>
        public void setIdRolEmpleado(byte lIIdRolEmpleado)
        {
            this.idRol = lIIdRolEmpleado;
        }
        /// <summary>
        /// Método modificador el campo nombre del empleado
        /// </summary>
        /// <param name="lIdEmpleado">string: el nombre del empleado</param>
        public void setNombreEmpleado(string lIdNombreEmpleado)
        {
            this.nombre = lIdNombreEmpleado;
        }
        /// <summary>
        /// Método modificador el campo apellido del empleado
        /// </summary>
        /// <param name="lIdNombreEmpleado">string: el apellido del empleado</param>
        public void setApellidoEmpleado(string lsApellidoEmpleado)
        {
            this.apellido = lsApellidoEmpleado;
        }
        /// <summary>
        /// Método modificador el campo direccion del empleado
        /// </summary>
        /// <param name="lsDireccionEmpleado">string: la direccion del empleado</param>
        public void setDireccionEmpleado(string lsDireccionEmpleado)
        {
            this.direccion = lsDireccionEmpleado;
        }
        /// <summary>
        /// Método modificador del campo telefono del cliente
        /// </summary>
        /// <param name="lsTelefonoCliente">string: el telefono del cliente</param>
        public void setTelefonoEmpleado(string lsTelefonoCliente)
        {
            this.telefono = lsTelefonoCliente;
        }
        /// <summary>
        /// Método modificador el campo celular del empleado
        /// </summary>
        /// <param name="lsCelularEmpleado">string: el celular del empleado</param>
        public void setCelularEmpleado(string lsCelularEmpleado)
        {
            this.celular = lsCelularEmpleado;
        }
        /// <summary>
        /// Método modificador el campo puesto del empleado
        /// </summary>
        /// <param name="lsPuestoEmpleado">string: el puesto del empleado</param>
        public void setPuestoEmpleado(string lsPuestoEmpleado)
        {
            this.puesto = lsPuestoEmpleado;
        }
        /// <summary>
        /// Método modificador el campo fecha de contratacion del empleado
        /// </summary>
        /// <param name="lIdEmpleado">datetime: la fecha de contratacion del empleado</param>
        public void setFechaContratacionEmpleado(DateTime ldaFechaContratacion)
        {
            this.fechaContratacion = ldaFechaContratacion;
        }
        /// <summary>
        /// Método modificador el campo salario del empleado
        /// </summary>
        /// <param name="lIdEmpleado">decimal: el salario del empleado</param>
        public void setSalarioEmpleado(decimal ldeSalarioEmpleado)
        {
            this.salario = ldeSalarioEmpleado;
        }
        /// <summary>
        /// Método modificador el campo usuario del empleado
        /// </summary>
        /// <param name="lIdEmpleado">string: el usuario del empleado</param>
        public void setUsuarioEmpleado(string lsUsuarioEmpleado)
        {
            this.usuario = lsUsuarioEmpleado;
        }
        /// <summary>
        /// Método modificador el campo password del empleado
        /// </summary>
        /// <param name="lIdEmpleado">byte: el password del empleado</param>
        public void setPasswordEmpleado(byte[] lsPasswordEmpleado)
        {
            this.password = lsPasswordEmpleado;
        }
        /// <summary>
        /// Permite el seteo del password a partir de una cadena limpia (que no ha sido hasheada)
        /// </summary>
        /// <param name="lsPaswordEmpleado">Contraseña</param>
        public void setPasswordEmpleado(string lsPaswordEmpleado)
        {
            this.password = arrbyCalcularHash(lsPaswordEmpleado);
        }
        /// <summary>
        /// Método modificador el campo habilitado del empleado
        /// </summary>
        /// <param name="lIdEmpleado">bool: el campo habilitado del empleado</param>
        public void setHabilitadoEmpleado(bool lbyHabilitadoEmpleado)
        {
            this.habilitado = lbyHabilitadoEmpleado;
        }
        /// <summary>
        /// Método modificador el numero de cedula o dpi del empleado
        /// </summary>
        /// <param name="lsdpiCedula">string: numero de cedula o dpi</param>
        public void setDpiCedula(string lsDpiCedula)
        {
            this.dpiCedula = lsDpiCedula;
        }
        #endregion
        #region otros métodos...
        /// <summary>
        /// Permite obtener una clave hash de una cadena (contraseña)
        /// Se utiliza el algoritmo SHA1
        /// </summary>
        /// <param name="lsPass"></param>
        /// <returns>Arreglo con la contraseña hasheada</returns>
        public byte[] arrbyCalcularHash(String lsPass)
        {
            SHA1 algoritmo = SHA1Managed.Create();
            ASCIIEncoding arreglo = new ASCIIEncoding();
            byte[] retorno;
            retorno = algoritmo.ComputeHash(arreglo.GetBytes(lsPass));
            return retorno;
        }

        /// <summary>
        /// Compara un password sin hashear con el que se encuentra en el objeto
        /// </summary>
        /// <param name="lsOtroPass">Contraseña a comparar</param>
        /// <returns>True si son idénticos, False si no son equivalentes</returns>
        public bool bCompararPass(String lsOtroPass)
        {
            byte[] otroPassHasheado = arrbyCalcularHash(lsOtroPass);
            bool retorno = true;
            if (otroPassHasheado.Length == password.Length)
            {
                for (int i = 0; i < lsOtroPass.Length; i++)
                {
                    if (otroPassHasheado[i] != password[i])
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            else
                retorno = false;

            return retorno;
        }

        #endregion
        #region Métodos de comunicación con la base de datos
        /// <summary>
        /// Método que inserta un nuevo empleado a la base de datos.
        /// Los datos que se envían a la base de datos son los que se encuentran contenidos actualmente en éste objeto.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string fnsInsertarEmpleado()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insertarEmpleados(this.idRol, this.nombre, this.apellido, this.direccion, this.telefono, this.celular, this.puesto, this.fechaContratacion, this.salario, this.usuario, this.password, this.habilitado, this.dpiCedula);
                return "La inserción del empleado en la base de datos se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        /// <summary>
        /// Método que modificar al empleado. Los datos que se utilizan para la modificación son los que se encuentran almacenados en el objeto actual.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string fnsModificarEmpleado()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.ModificarEmpleado(this.idEmpleado, this.idRol, this.nombre, this.apellido, this.direccion, this.telefono, this.celular, this.puesto, this.fechaContratacion, this.salario, this.usuario, this.password, this.habilitado, this.dpiCedula);
                return "La modificación de los datos del empleado se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Método que da de baja al empleado.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string fnsDarBajaEmpleado()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.darBajaEmpleado((getIdEmpleado()));
                return "Se dio de baja con éxito al empleado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función que lista a los empleados
        /// </summary>
        /// <returns>DataTable: lista de los empleados de la base de datos.</returns>
        public static DataTable fnDbListarEmpleados()
        {
            return negociosAdaptadores.gAdaptadorListaEmpleados.GetData();
        }
        /// <summary>
        /// Función que busca a un empleado por nombre
        /// </summary>
        /// <returns>DataTable: busca a un empleado por nombre.</returns>

        /// <summary>
        /// Función que devuelve a los ultimos 20 empleados
        /// </summary>
        /// <returns>DataTable: devuelve los ultimos 20 empleados</returns>
        public static DataTable fnDbDevolverVeinteEmpleados()
        {
            return negociosAdaptadores.gAdaptadorUltimosVeinteEmpleados.GetData();
        }
        public static List<negociosEmpleado> fnslListarUltimosVeinteEmpleados()
        {
            List<negociosEmpleado> lnpEmpleados = new List<negociosEmpleado>();
            try
            {
                DataTable ldtEmpleados = negociosEmpleado.fnDbDevolverVeinteEmpleados();
                object[] oListaElmentos;
                for (int i = 0; i < ldtEmpleados.Rows.Count; i++)
                {
                    oListaElmentos = ldtEmpleados.Rows[i].ItemArray;
                    negociosEmpleado npNuevoEmpleado = new negociosEmpleado();
                    npNuevoEmpleado.setIdEmpleado(Convert.ToByte(oListaElmentos[0]));
                    npNuevoEmpleado.setIdRolEmpleado(Convert.ToByte(oListaElmentos[1]));
                    npNuevoEmpleado.setNombreEmpleado(Convert.ToString(oListaElmentos[2]));
                    npNuevoEmpleado.setApellidoEmpleado(Convert.ToString(oListaElmentos[3]));
                    npNuevoEmpleado.setDireccionEmpleado(Convert.ToString(oListaElmentos[4]));
                    npNuevoEmpleado.setTelefonoEmpleado(Convert.ToString(oListaElmentos[5]));
                    npNuevoEmpleado.setCelularEmpleado(Convert.ToString(oListaElmentos[6]));
                    npNuevoEmpleado.setPuestoEmpleado(Convert.ToString(oListaElmentos[7]));
                    npNuevoEmpleado.setFechaContratacionEmpleado(Convert.ToDateTime(oListaElmentos[8]));
                    npNuevoEmpleado.setSalarioEmpleado(Convert.ToDecimal(oListaElmentos[9]));
                    npNuevoEmpleado.setUsuarioEmpleado(Convert.ToString(oListaElmentos[10]));
                    lnpEmpleados.Add(npNuevoEmpleado);
                }
                return lnpEmpleados;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public static DataTable buscarEmpleadoUsuario(string sUsuario)
        {
            return negociosAdaptadores.gAdaptadorBuscarEmpleadoUsuario.GetData(sUsuario);
        }
        public static List<negociosEmpleado> fnslListarEmpleadoUsuario(string sUsuario)
        {
            List<negociosEmpleado> lnpEmpleados = new List<negociosEmpleado>();
            try
            {
                DataTable ldtEmpleados = negociosEmpleado.buscarEmpleadoUsuario(sUsuario);
                object[] oListaElmentos;
                for (int i = 0; i < ldtEmpleados.Rows.Count; i++)
                {
                    oListaElmentos = ldtEmpleados.Rows[i].ItemArray;
                    negociosEmpleado npNuevoEmpleado = new negociosEmpleado();
                    npNuevoEmpleado.setIdEmpleado(Convert.ToByte(oListaElmentos[0]));
                    npNuevoEmpleado.setIdRolEmpleado(Convert.ToByte(oListaElmentos[1]));
                    npNuevoEmpleado.setNombreEmpleado(Convert.ToString(oListaElmentos[2]));
                    npNuevoEmpleado.setApellidoEmpleado(Convert.ToString(oListaElmentos[3]));
                    npNuevoEmpleado.setDireccionEmpleado(Convert.ToString(oListaElmentos[4]));
                    npNuevoEmpleado.setTelefonoEmpleado(Convert.ToString(oListaElmentos[5]));
                    npNuevoEmpleado.setCelularEmpleado(Convert.ToString(oListaElmentos[6]));
                    npNuevoEmpleado.setPuestoEmpleado(Convert.ToString(oListaElmentos[7]));
                    npNuevoEmpleado.setFechaContratacionEmpleado(Convert.ToDateTime(oListaElmentos[8]));
                    npNuevoEmpleado.setSalarioEmpleado(Convert.ToDecimal(oListaElmentos[9]));
                    npNuevoEmpleado.setUsuarioEmpleado(Convert.ToString(oListaElmentos[10]));
                    lnpEmpleados.Add(npNuevoEmpleado);
                }
                return lnpEmpleados;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static DataTable buscarEmpleadoNombre(string sNombre)
        {
            return negociosAdaptadores.gAdaptadorEmpleadoNombre.GetData(sNombre);
        }
        public static List<negociosEmpleado> fnslListarEmpleadoNombre(string sNombre)
        {
            List<negociosEmpleado> lnpEmpleados = new List<negociosEmpleado>();
            try
            {
                DataTable ldtEmpleados = negociosEmpleado.buscarEmpleadoNombre(sNombre);
                object[] oListaElmentos;
                for (int i = 0; i < ldtEmpleados.Rows.Count; i++)
                {
                    oListaElmentos = ldtEmpleados.Rows[i].ItemArray;
                    negociosEmpleado npNuevoEmpleado = new negociosEmpleado();
                    npNuevoEmpleado.setIdEmpleado(Convert.ToByte(oListaElmentos[0]));
                    npNuevoEmpleado.setIdRolEmpleado(Convert.ToByte(oListaElmentos[1]));
                    npNuevoEmpleado.setNombreEmpleado(Convert.ToString(oListaElmentos[2]));
                    npNuevoEmpleado.setApellidoEmpleado(Convert.ToString(oListaElmentos[3]));
                    npNuevoEmpleado.setDireccionEmpleado(Convert.ToString(oListaElmentos[4]));
                    npNuevoEmpleado.setTelefonoEmpleado(Convert.ToString(oListaElmentos[5]));
                    npNuevoEmpleado.setCelularEmpleado(Convert.ToString(oListaElmentos[6]));
                    npNuevoEmpleado.setPuestoEmpleado(Convert.ToString(oListaElmentos[7]));
                    npNuevoEmpleado.setFechaContratacionEmpleado(Convert.ToDateTime(oListaElmentos[8]));
                    npNuevoEmpleado.setSalarioEmpleado(Convert.ToDecimal(oListaElmentos[9]));
                    npNuevoEmpleado.setUsuarioEmpleado(Convert.ToString(oListaElmentos[10]));
                    lnpEmpleados.Add(npNuevoEmpleado);
                }
                return lnpEmpleados;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static DataTable buscarEmpleadoApellido(string sApellido)
        {
            return negociosAdaptadores.gAdaptadorBuscarEmpleadoApellido.GetData(sApellido);
        }
        public static List<negociosEmpleado> fnslListarEmpleadoApellido(string sApellido)
        {
            List<negociosEmpleado> lnpEmpleados = new List<negociosEmpleado>();
            try
            {
                DataTable ldtEmpleados = negociosEmpleado.buscarEmpleadoApellido(sApellido);
                object[] oListaElmentos;
                for (int i = 0; i < ldtEmpleados.Rows.Count; i++)
                {
                    oListaElmentos = ldtEmpleados.Rows[i].ItemArray;
                    negociosEmpleado npNuevoEmpleado = new negociosEmpleado();
                    npNuevoEmpleado.setIdEmpleado(Convert.ToByte(oListaElmentos[0]));
                    npNuevoEmpleado.setIdRolEmpleado(Convert.ToByte(oListaElmentos[1]));
                    npNuevoEmpleado.setNombreEmpleado(Convert.ToString(oListaElmentos[2]));
                    npNuevoEmpleado.setApellidoEmpleado(Convert.ToString(oListaElmentos[3]));
                    npNuevoEmpleado.setDireccionEmpleado(Convert.ToString(oListaElmentos[4]));
                    npNuevoEmpleado.setTelefonoEmpleado(Convert.ToString(oListaElmentos[5]));
                    npNuevoEmpleado.setCelularEmpleado(Convert.ToString(oListaElmentos[6]));
                    npNuevoEmpleado.setPuestoEmpleado(Convert.ToString(oListaElmentos[7]));
                    npNuevoEmpleado.setFechaContratacionEmpleado(Convert.ToDateTime(oListaElmentos[8]));
                    npNuevoEmpleado.setSalarioEmpleado(Convert.ToDecimal(oListaElmentos[9]));
                    npNuevoEmpleado.setUsuarioEmpleado(Convert.ToString(oListaElmentos[10]));
                    lnpEmpleados.Add(npNuevoEmpleado);
                }
                return lnpEmpleados;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static negociosEmpleado fnneObtenerNombreApellidoEmpleadoPorId(byte id)
        {
            DataTable dtLocal = negociosAdaptadores.gAdaptadorNombreApellidosEmpleado.GetData(id);
            negociosEmpleado temporal = null;

            if (dtLocal.Rows.Count > 0)
            {
                object[] objInstancia = dtLocal.Rows[0].ItemArray;
                temporal = new negociosEmpleado();
                temporal.setNombreEmpleado(Convert.ToString(objInstancia[0]));
                temporal.setApellidoEmpleado(Convert.ToString(objInstancia[1]));
                temporal.setIdEmpleado(id);
            }
            return temporal;
        }
        #endregion
    }
}


