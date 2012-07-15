using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datos;
using System.Security.Cryptography;
using System.Data;

namespace negocios
{
    public class auxiliar
    {
        public static int getLogin(string u, string p)
        {
            return (int)negociosAdaptadores.gAdaptadorGeneral.ingreso(u, auxiliar.arrbyCalcularHash(p));
        }
        private static byte[] arrbyCalcularHash(String lsPass)
        {
            SHA1 algoritmo = SHA1Managed.Create();
            ASCIIEncoding arreglo = new ASCIIEncoding();
            byte[] retorno;
            retorno = algoritmo.ComputeHash(arreglo.GetBytes(lsPass));
            return retorno;
        }
        public static negociosEmpleado getEmpleado(string u, string p)
        {
            DataTable dtLocal = negociosAdaptadores.gAdaptadorGetEmpleadoValidoLogin.GetData(u, auxiliar.arrbyCalcularHash(p));
            negociosEmpleado temporal = null;
            if (dtLocal.Rows.Count>0)
            {
                object[] elemento = dtLocal.Rows[0].ItemArray;
                temporal = new negociosEmpleado();
                //e.IDEMPLEADO,e.IDROL,e.NOMBRE,e.APELLIDO,e.DIRECCION,e.TELEFONO,e.CELULAR,e.PUESTO,e.FECHACONTRATACION,e.SALARIO,e.USUARIO,e.HABILITADO,e.DPICEDULA
                temporal.setIdEmpleado(Convert.ToByte(elemento[0]));
                temporal.setIdRolEmpleado(Convert.ToByte(elemento[1]));
                temporal.setNombreEmpleado(Convert.ToString(elemento[2]));
                temporal.setApellidoEmpleado(Convert.ToString(elemento[3]));
                temporal.setDireccionEmpleado(Convert.ToString(elemento[4]));
                temporal.setTelefonoEmpleado(Convert.ToString(elemento[5]));
                temporal.setCelularEmpleado(Convert.ToString(elemento[6]));
                temporal.setPuestoEmpleado(Convert.ToString(elemento[7]));
                temporal.setFechaContratacionEmpleado(Convert.ToDateTime(elemento[8]));
                temporal.setSalarioEmpleado(Convert.ToDecimal(elemento[9]));
                temporal.setUsuarioEmpleado(Convert.ToString(elemento[10]));
                temporal.setHabilitadoEmpleado(Convert.ToBoolean(elemento[11]));
                temporal.setDpiCedula(Convert.ToString(elemento[12]));
            }
            return temporal;
        }
    }
}
