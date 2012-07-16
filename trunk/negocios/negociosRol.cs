using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosRol
    {
        private int liIdRol;
        private string lsNombre;
        private byte[] larrbyPermisosRoles = new byte[10];
        private byte[] larrbyPermisosEmpleados = new byte[10];
        private byte[] larrbyPermisosProveedores = new byte[10];
        private byte[] larrbyPermisosProductos = new byte[10];
        private byte[] larrbyPermisosCompras = new byte[10];
        private byte[] larrbyPermisosClientes = new byte[10];
        private byte[] larrbyPermisosVentas = new byte[10];
        private byte[] larrbyPermisosReportes = new byte[10];
        private int liNivelAcceso;
        private bool lboHabilitado;

        #region constructores
        public negociosRol()
        { }
        #endregion
        #region métodos de acceso y modificación de permisos para el módulo de roles
        /// <summary>
        /// Función que asigna un permiso específico para la creación de un nuevo rol de permisos de acceso a la aplicación
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCreacionRol(byte lbyPermiso)
        {
            this.larrbyPermisosRoles[0] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer listas y búsquedas de roles
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoListarRoles(byte lbyPermiso)
        {
            this.larrbyPermisosRoles[1] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer modificaciones de roles
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoModificacionRol(byte lbyPermiso)
        {
            this.larrbyPermisosRoles[2] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para eliminar roles de permisos en la base de datos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoEliminacionRol(byte lbyPermiso)
        {
            this.larrbyPermisosRoles[3] = lbyPermiso;
        }
        /// <summary>
        /// Función que retorna el permiso de creación de roles, para éste rol de acceso en modo boolean
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoCreacionRol()
        {
            return Convert.ToBoolean(larrbyPermisosRoles[0]);
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de roles, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoListarRoles()
        {
            return Convert.ToBoolean(larrbyPermisosRoles[1]);
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de roles, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoModificacionRol()
        {
            return Convert.ToBoolean(larrbyPermisosRoles[2]);
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de roles, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoEliminacionRol()
        {
            return Convert.ToBoolean(larrbyPermisosRoles[3]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Roles
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloRol()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 0; j < 4; j++)
                if (larrbyPermisosRoles[j] == 0)
                    i++;
            if (i == 4)
                retorno = false;
            return retorno;
        }

        #endregion
        #region métodos de acceso y modificación de permisos para el módulo de empleados
        /// <summary>
        /// Función que asigna un permiso específico para la creación de un nuevo empleado
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCreacionEmpleado(byte lbyPermiso)
        {
            this.larrbyPermisosEmpleados[0] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer listas y búsquedas de empleados
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoListarEmpleados(byte lbyPermiso)
        {
            this.larrbyPermisosEmpleados[1] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer modificaciones de datos de empleados
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoModificacionEmpleados(byte lbyPermiso)
        {
            this.larrbyPermisosEmpleados[2] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico eliminar empleados de la base de datos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoEliminacionEmpleados(byte lbyPermiso)
        {
            this.larrbyPermisosEmpleados[3] = lbyPermiso;
        }
        /// <summary>
        /// Función de acceso al permiso de creación de empleados, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoCreacionEmpleados()
        {
            return Convert.ToBoolean(larrbyPermisosEmpleados[0]);
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de empleados, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoListarEmpleados()
        {
            return Convert.ToBoolean(larrbyPermisosEmpleados[1]);
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de datos de empleados, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoModificacionEmpleados()
        {
            return Convert.ToBoolean(larrbyPermisosEmpleados[2]);
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de empleados, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoEliminacionEmpleados()
        {
            return Convert.ToBoolean(larrbyPermisosEmpleados[3]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Empleados
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloEmpleados()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 0; j < 4; j++)
                if (larrbyPermisosEmpleados[j] == 0)
                    i++;
            if (i == 4)
                retorno = false;
            return retorno;
        }

        #endregion
        #region métodos de acceso y modificación de permisos para el módulo de proveedores
        /// <summary>
        /// Función que asigna un permiso específico para la inserción de un nuevo proveedor en la base de datos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCreacionProveedores(byte lbyPermiso)
        {
            this.larrbyPermisosProveedores[0] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para listar proveedores
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoListarProveedores(byte lbyPermiso)
        {
            this.larrbyPermisosProveedores[1] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer modificaciones de datos de Proveedores
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoModificacionProveedores(byte lbyPermiso)
        {
            this.larrbyPermisosProveedores[2] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico eliminar proveedores de la base de datos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoEliminacionProveedores(byte lbyPermiso)
        {
            this.larrbyPermisosProveedores[3] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer búsquedas de proveedores
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoBuscarProveedores(byte lbyPermiso)
        {
            this.larrbyPermisosProveedores[4] = lbyPermiso;
        }
                
        /// <summary>
        /// Función de acceso al permiso de creación de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoCreacionProveedores()
        {
            return Convert.ToBoolean(larrbyPermisosProveedores[0]);
        }
        /// <summary>
        /// Función de acceso al permiso de listado de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoListarProveedores()
        {
            return Convert.ToBoolean(larrbyPermisosProveedores[1]);
        }
        /// <summary>
        /// Función de acceso al permiso de búsqueda de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoBuscarProveedores()
        {
            return Convert.ToBoolean(larrbyPermisosProveedores[4]);
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de datos de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoModificacionProveedores()
        {
            return Convert.ToBoolean(larrbyPermisosProveedores[2]);
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no tiene permiso</returns>
        public bool getPermisoEliminacionProveedores()
        {
            return Convert.ToBoolean(larrbyPermisosProveedores[3]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Proveedores
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloProveedores()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 0; j < 5; j++)
                if (larrbyPermisosProveedores[j] == 0)
                    i++;
            if (i == 5)
                retorno = false;
            return retorno;
        }

        #endregion
        #region métodos de acceso y modificación de permisos para el módulo de productos
        /// <summary>
        /// Función que asigna un permiso específico para la inserción de un nuevo producto en la base de datos (descripción del producto)
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCreacionProductos(byte lbyPermiso)
        {
            this.larrbyPermisosProductos[0] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer listas y búsquedas de productos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoListarProductos(byte lbyPermiso)
        {
            this.larrbyPermisosProductos[1] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer modificaciones de datos de Productos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoModificacionProductos(byte lbyPermiso)
        {
            this.larrbyPermisosProductos[2] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico eliminar productos de la base de datos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoEliminacionProductos(byte lbyPermiso)
        {
            this.larrbyPermisosProductos[3] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer búsquedas de productos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoBuscarProductos(byte lbyPermiso)
        {
            this.larrbyPermisosProductos[4] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para manejar inventarios de productos: cargar producto (agregar existencias)
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCargarProductos(byte lbyPermiso)
        {
            this.larrbyPermisosProductos[5] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para manejar inventarios de productos: descargar productos (disminuir existencias)
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoDescargarProductos(byte lbyPermiso)
        {
            this.larrbyPermisosProductos[6] = lbyPermiso;
        }
        /// <summary>
        /// Función de acceso al permiso de creación de productos, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoCreacionProductos()
        {
            return Convert.ToBoolean(larrbyPermisosProductos[0]);
        }
        /// <summary>
        /// Función de acceso al permiso de listado de productos, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoListarProductos()
        {
            return Convert.ToBoolean(larrbyPermisosProductos[1]);
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de datos de productos, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoModificacionProductos()
        {
            return Convert.ToBoolean(larrbyPermisosProductos[2]);
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de productos, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoEliminacionProductos()
        {
            return Convert.ToBoolean(larrbyPermisosProductos[3]);
        }
        /// <summary>
        /// Función de acceso al permiso de búsqueda de productos, para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoBusquedaProductos()
        {
            return Convert.ToBoolean(larrbyPermisosProductos[4]);
        }
        /// <summary>
        /// Función de acceso al permiso de carga de productos (aumentar existencias), para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoCargarProductos()
        {
            return Convert.ToBoolean(larrbyPermisosProductos[5]);
        }
        /// <summary>
        /// Función de acceso al permiso de descarga de productos (disminuir existencias), para éste rol de acceso
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoDescargarProductos()
        {
            return Convert.ToBoolean(larrbyPermisosProductos[6]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Productos
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloProductos()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 0; j < 7; j++)
                if (larrbyPermisosProductos[j] == 0)
                    i++;
            if (i == 7)
                retorno = false;
            return retorno;
        }
        #endregion
        #region métodos de acceso y modificación de permisos para el módulo de compras
        /// <summary>
        /// Función que asigna un permiso específico para ingresar al módulo de compras en la parte de cargado de nuevas facturas de compra
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCompra(byte lbyPermiso)
        {
            this.larrbyPermisosCompras[0] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer anotaciones de crédito a favor y devolver productos a proveedores
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoDevolverProductosProveedores(byte lbyPermiso)
        {
            this.larrbyPermisosCompras[1] = lbyPermiso;
        }
        
        /// <summary>
        /// Función de acceso al permiso de ingresar al módulo de compras en la parte de cargado de nuevas facturas de compra
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoCompra()
        {
            return Convert.ToBoolean(larrbyPermisosCompras[0]);
        }
        /// <summary>
        /// Función de acceso al permiso para hacer anotaciones de crédito a favor y devolver productos a proveedores
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoDevolverProductosProveedores()
        {
            return Convert.ToBoolean(larrbyPermisosCompras[1]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Roles
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloCompras()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 0; j < 2; j++)
                if (larrbyPermisosCompras[j] == 0)
                    i++;
            if (i == 2)
                retorno = false;
            return retorno;
        }

        #endregion
        #region métodos de acceso y modificación de permisos para el módulo de clientes
        /// <summary>
        /// Función que asigna un permiso específico para la creación de un nuevo cliente en la base de datos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCreacionClientes(byte lbyPermiso)
        {
            this.larrbyPermisosClientes[0] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer listas y búsquedas de clientes
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoListarClientes(byte lbyPermiso)
        {
            this.larrbyPermisosClientes[1] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer modificaciones de clientes
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoModificacionClientes(byte lbyPermiso)
        {
            this.larrbyPermisosClientes[2] = lbyPermiso;
        }
        /// <summary>
        /// Función de acceso al permiso de creación de clientes
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoCreacionClientes()
        {
            return Convert.ToBoolean(larrbyPermisosClientes[0]);
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de clientes
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoListarClientes()
        {
            return Convert.ToBoolean(larrbyPermisosClientes[1]);
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de clientes
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoModificacionClientes()
        {
            return Convert.ToBoolean(larrbyPermisosClientes[2]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Clientes
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloCliente()
        {
            bool retorno = true;
            int i = 0;
            for (int j=0; j<3;j++)
                if (larrbyPermisosClientes[j] == 0)
                    i++;
            if (i == 3)
                retorno = false;
            return retorno;
        }

        #endregion
        #region métodos de acceso y modificación de permisos para el módulo de ventas
        /// <summary>
        /// Función que asigna un permiso específico para ingresar al módulo de ventas (facturación de ventas)
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoVentas(byte lbyPermiso)
        {
            this.larrbyPermisosVentas[0] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer modificaciones a facturas de venta (eliminar facturas y volver a crearlas)
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoEliminarFacturasVentas(byte lbyPermiso)
        {
            this.larrbyPermisosVentas[1] = lbyPermiso;
        }

        /// <summary>
        /// Función de acceso al permiso de ingresar al módulo de ventas
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoVentas()
        {
            return Convert.ToBoolean(larrbyPermisosVentas[0]);
        }
        /// <summary>
        /// Función de acceso al permiso específico para hacer modificaciones a facturas de venta (eliminar facturas y volver a crearlas)
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoEliminarFacturasVentas()
        {
            return Convert.ToBoolean(larrbyPermisosVentas[1]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Ventas
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloVentas()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 0; j < 2; j++)
                if (larrbyPermisosClientes[j] == 0)
                    i++;
            if (i == 2)
                retorno = false;
            return retorno;
        }
        #endregion
        #region métodos de acceso y modificación de permisos para el módulo de reportes
        /// <summary>
        /// Función que asigna un permiso específico para hacer cortes de caja
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCorteCaja(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[0] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer listas de facturas de venta eliminadas
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoReporteFacturasVentaEliminadas(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[1] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para listar devoluciones al proveedor
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoReporteDevolucionesProveedor(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[2] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para ver el historial de costos
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoHistorialCostos(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[3] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para ver el historial de ventas del mes
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoHistorialVentasMes(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[4] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para ver el historial de compras del mes
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoHistorialComprasMes(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[5] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para ver el historial de crédito por proveedor
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoHistorialCreditoPorProveedor(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[6] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para ver el historial de crédito por mes
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoHistorialCreditoMes(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[7] = lbyPermiso;
        }
        /// <summary>
        /// Función de acceso al permiso para hacer cortes de caja
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoCortesCaja()
        {
            return Convert.ToBoolean(larrbyPermisosReportes[0]);
        }
        /// <summary>
        /// Función de acceso al permiso para hacer listas de facturas de venta eliminadas
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoReporteFacturasVentaEliminadas()
        {
            return Convert.ToBoolean(larrbyPermisosReportes[1]);
        }
        /// <summary>
        /// Función de acceso al permiso para hacer listas de devoluciones de producto al proveedor
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoReporteDevolucionesProveedor()
        {
            return Convert.ToBoolean(larrbyPermisosReportes[2]);
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de costos
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoHistorialCostos()
        {
            return Convert.ToBoolean(larrbyPermisosReportes[3]);
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de ventas del mes
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoHistorialVentasMes()
        {
            return Convert.ToBoolean(larrbyPermisosReportes[4]);
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de compras del mes
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoHistorialComprasMes()
        {
            return Convert.ToBoolean(larrbyPermisosReportes[5]);
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de crédito por proveedor
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoHistorialCreditoPorProveedor()
        {
            return Convert.ToBoolean(larrbyPermisosReportes[6]);
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de crédito por mes
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoHistorialCreditoMes()
        {
            return Convert.ToBoolean(larrbyPermisosReportes[7]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Roles
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloReportes()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 0; j < 8; j++)
                if (larrbyPermisosReportes[j] == 0)
                    i++;
            if (i == 8)
                retorno = false;
            return retorno;
        }

        #endregion
        #region métodos de acceso y modificación de series de facturas de venta
        /// <summary>
        /// Función que asigna un permiso específico para la creación de una nueva serie de facturas de venta
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCreacionSerieFacturaVenta(byte lbyPermiso)
        {
            this.larrbyPermisosRoles[4] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer listas y búsquedas de series de facturas de venta
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoListarSerieFacturaVenta(byte lbyPermiso)
        {
            this.larrbyPermisosRoles[5] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer modificaciones de series de facturas de venta
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoModificacionSerieFacturaVenta(byte lbyPermiso)
        {
            this.larrbyPermisosRoles[6] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para eliminar series de facturas de venta
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoEliminacionSerieFacturaVenta(byte lbyPermiso)
        {
            this.larrbyPermisosRoles[7] = lbyPermiso;
        }
        /// <summary>
        /// Función de acceso al permiso de creación de series de facturas de venta
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoCreacionSerieFacturaVenta()
        {
            return Convert.ToBoolean(larrbyPermisosRoles[4]);
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de series de facturas de venta
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoListarSerieFacturaVenta()
        {
            return Convert.ToBoolean(larrbyPermisosRoles[5]);
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de series de facturas de venta
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoModificacionSerieFacturaVenta()
        {
            return Convert.ToBoolean(larrbyPermisosRoles[6]);
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de series de facturas de venta
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoEliminacionSerieFacturaVenta()
        {
            return Convert.ToBoolean(larrbyPermisosRoles[7]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Roles
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloTalonario()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 4; j < 8; j++)
                if (larrbyPermisosRoles[j] == 0)
                    i++;
            if (i == 4)
                retorno = false;
            return retorno;
        }
        #endregion
        #region métodos de acceso y modificación de permisos para el módulo tipos de clientes
        /// <summary>
        /// Función que asigna un permiso específico para la creación de un nuevo tipo de cliente
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoCreacionTiposCliente(byte lbyPermiso)
        {
            this.larrbyPermisosEmpleados[4] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer listas y búsquedas de tipos de cliente
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoListarTiposCliente(byte lbyPermiso)
        {
            this.larrbyPermisosEmpleados[5] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para hacer modificaciones de tipos de cliente
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoModificacionTiposCliente(byte lbyPermiso)
        {
            this.larrbyPermisosEmpleados[6] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico eliminar tipos de cliente
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoEliminacionTiposCliente(byte lbyPermiso)
        {
            this.larrbyPermisosEmpleados[7] = lbyPermiso;
        }
        /// <summary>
        /// Función de acceso al permiso de creación de tipos de cliente
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoCreacionTiposCliente()
        {
            return Convert.ToBoolean(larrbyPermisosEmpleados[4]);
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de tipos de cliente
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoListarTiposCliente()
        {
            return Convert.ToBoolean(larrbyPermisosEmpleados[5]);
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de datos de tipos de cliente
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoModificacionTiposCliente()
        {
            return Convert.ToBoolean(larrbyPermisosEmpleados[6]);
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de tipos de cliente
        /// </summary>
        /// <returns>bool: True si tiene permiso, False si no</returns>
        public bool getPermisoEliminacionTiposCliente()
        {
            return Convert.ToBoolean(larrbyPermisosEmpleados[7]);
        }

        /// <summary>
        /// Función de acceso al permiso de Módulo de Tipos Clientes
        /// </summary>
        /// <returns>bool: True si puede acceder al Módulo, False si no tiene permiso</returns>
        public bool getPermisoAccesoModuloTiposClientes()
        {
            bool retorno = true;
            int i = 0;
            for (int j = 4; j < 8; j++)
                if (larrbyPermisosEmpleados[j] == 0)
                    i++;
            if (i == 4)
                retorno = false;
            return retorno; 
        }
        #endregion
        #region otros métodos de acceso y modificacion
        /// <summary>
        /// Función de modificación del ID del rol
        /// </summary>
        /// <param name="id">int: el nuevo ID para el rol</param>
        public void setIdRol(int id)
        {
            this.liIdRol = id;
        }
        /// <summary>
        /// Función de acceso del ID del rol
        /// </summary>
        /// <returns>int: el ID del rol</returns>
        public int getIdRol()
        {
            return this.liIdRol;
        }
        /// <summary>
        /// Función de modificación del nivel de acceso para el rol
        /// </summary>
        /// <param name="liNivelAcceso">int: el nuevo nivel de acceso aplicado</param>
        public void setNivelAcceso(int liNivelAcceso)
        {
            this.liNivelAcceso = liNivelAcceso;
        }
        /// <summary>
        /// Función para obtener el nivel de acceso del rol
        /// </summary>
        /// <returns>int: el nivel de acceso del rol</returns>
        public int getNivelAcceso()
        {
            return this.liNivelAcceso;
        }
        /// <summary>
        /// Función de modificación del campo "Habilitado" del rol
        /// </summary>
        /// <param name="lboActivado">bool: True para activar el rol, False para desactivarlo (eliminarlo)</param>
        public void setHabilitado(bool lboActivado)
        {
            this.lboHabilitado = lboActivado;
        }
        /// <summary>
        /// Función de acceso del campo "Habilitado" del rol
        /// </summary>
        /// <returns>bool: True si el rol está activado, False si no lo está</returns>
        public bool getHabilitado()
        {
            return this.lboHabilitado;
        }
        /// <summary>
        /// Función de modificación del campo nombre de rol
        /// </summary>
        /// <param name="lsNombreRol">string: el nombre del rol</param>
        public void setNombre(string lsNombreRol)
        {
            this.lsNombre = lsNombreRol;
        }
        /// <summary>
        /// Función de acceso al campo Nombre, del rol
        /// </summary>
        /// <returns>string: el nombre actual del rol</returns>
        public string getNombre()
        {
            return this.lsNombre;
        }
        #endregion
        #region métodos de comunicación con la base de datos
        /// <summary>
        /// Función para insertar un nuevo rol de acceso y permisos de la aplicación, en la base de datos.
        /// Los datos a ingresar son los que el objeto actual contiene.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string crearRol()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insertarRol(this.lsNombre, this.larrbyPermisosRoles, this.larrbyPermisosEmpleados, this.larrbyPermisosProveedores, this.larrbyPermisosProductos, this.larrbyPermisosCompras, this.larrbyPermisosClientes, this.larrbyPermisosVentas, this.larrbyPermisosReportes, (byte)this.liNivelAcceso);
                return "La inserción del nuevo rol se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función para insertar un nuevo rol de acceso y permisos de la aplicación, en la base de datos.
        /// Los datos a ingresar son los que el objeto actual contiene.
        /// </summary>
        public void fnvdCrearRol()
        {            
               negociosAdaptadores.gAdaptadorDeConsultas.insertarRol(this.lsNombre, this.larrbyPermisosRoles, this.larrbyPermisosEmpleados, this.larrbyPermisosProveedores, this.larrbyPermisosProductos, this.larrbyPermisosCompras, this.larrbyPermisosClientes, this.larrbyPermisosVentas, this.larrbyPermisosReportes, (byte)this.liNivelAcceso);               
        }
        /// <summary>
        /// Función de modificación del rol de acceso y permisos de la aplicación.
        /// Los datos que son enviados para reemplazo son los que actualmente están almacenados en éste objeto.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string modificarRol()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarRol((byte)this.liIdRol, this.lsNombre, this.larrbyPermisosRoles, this.larrbyPermisosEmpleados, this.larrbyPermisosProveedores, this.larrbyPermisosProductos, this.larrbyPermisosCompras, this.larrbyPermisosClientes, this.larrbyPermisosVentas, this.larrbyPermisosReportes, (byte)this.liNivelAcceso);
                return "El rol de permisos fue modificado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Función de modificación del rol de acceso y permisos de la aplicación.
        /// Los datos que son enviados para reemplazo son los que actualmente están almacenados en éste objeto.
        /// </summary>
        public void fnvdModificarRol()
        {            
            negociosAdaptadores.gAdaptadorDeConsultas.modificarRol((byte)this.liIdRol, this.lsNombre, this.larrbyPermisosRoles, this.larrbyPermisosEmpleados, this.larrbyPermisosProveedores, this.larrbyPermisosProductos, this.larrbyPermisosCompras, this.larrbyPermisosClientes, this.larrbyPermisosVentas, this.larrbyPermisosReportes, (byte)this.liNivelAcceso);
        }
        /// <summary>
        /// Función para eliminar (desactivar) el rol que representa éste objeto, de la base de datos.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string eliminarRol()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.eliminarRol((byte)this.liIdRol);
                return "El rol de permisos se eliminó de la base de datos satisfactoriamente";
            }
            catch (Exception ex)
            {
                return ex.Message;    
            }
        }
        /// <summary>
        /// Función para eliminar (desactivar) el rol que representa éste objeto, de la base de datos.
        /// </summary>
        public void fnvdEliminarRol()
        {            
            negociosAdaptadores.gAdaptadorDeConsultas.eliminarRol((byte)this.liIdRol);
        }
        /// <summary>
        /// Función para listar todos los roles activos dentro de la base de datos
        /// </summary>
        /// <returns>DataTable: todos los roles activos en la base de datos</returns>
        public DataTable listarRoles()
        {
            return negociosAdaptadores.gAdaptadorListaRoles.GetData();
        }      
        #endregion

        #region metodos de acceso estàtico
        /// <summary>
        /// Función de acceso estàtico para listar todos los roles activos dentro de la base de datos
        /// </summary>
        /// <returns>DataTable: todos los roles activos en la base de datos</returns>
        public static DataTable fndtlistarRoles()
        {
            return negociosAdaptadores.gAdaptadorListaRoles.GetData();
        }
        /// <summary>
        /// Funciòn que retorna una lista con los roles activos que existen en la base de datos.
        /// </summary>
        /// <returns>List negociosRol: lista de tuplas de roles en la base de datos</returns>
        public static List<negociosRol> fnlstListarRoles()
        {
            /*
             * r.IDROL,r.NOMBRE,
			r.MODULOROLES,r.MODULOEMPLEADOS,r.MODULOPROVEEDORES,
			r.MODULOPRODUCTOS,r.MODULOCOMPRAS,r.MODULOCLIENTES,
			r.MODULOVENTAS,r.MODULOREPORTES,r.NIVELACCESO 
             */
            List<negociosRol> lstRetorno = new List<negociosRol>();
            DataTable dtLocal = negociosRol.fndtlistarRoles();

            object[] objInstancia;
            for (int i = 0; i < dtLocal.Rows.Count; i++)
            {
                objInstancia = dtLocal.Rows[i].ItemArray;
                negociosRol temporal = new negociosRol();
                temporal.setIdRol(Convert.ToInt32(objInstancia[0]));
                temporal.setNombre(Convert.ToString(objInstancia[1]));
                temporal.larrbyPermisosRoles = (byte[])objInstancia[2];
                temporal.larrbyPermisosEmpleados = (byte[])objInstancia[3];
                temporal.larrbyPermisosProveedores = (byte[])objInstancia[4];
                temporal.larrbyPermisosProductos = (byte[])objInstancia[5];
                temporal.larrbyPermisosCompras = (byte[])objInstancia[6];
                temporal.larrbyPermisosClientes = (byte[])objInstancia[7];
                temporal.larrbyPermisosVentas = (byte[])objInstancia[8];
                temporal.larrbyPermisosReportes = (byte[])objInstancia[9];
                temporal.liNivelAcceso = Convert.ToInt32(objInstancia[10]);

                lstRetorno.Add(temporal);
            }

            return lstRetorno;
        }
        /// <summary>
        /// Funciòn que obtiene un objeto tipo Rol, segun su ID
        /// </summary>
        /// <param name="liIdRol">int: id del rol buscado</param>
        /// <returns>negociosRol: el objeto que representa el rol de permisos.Si no se encuentra, retorna null</returns>
        public static negociosRol fnObtenerRolPorId(int liIdRol)
        {
            DataTable dtLocal = negociosAdaptadores.gAdaptadorRolPorId.GetData(liIdRol);
            negociosRol temporal = null;
            if (dtLocal.Rows.Count > 0)
            {                
                temporal = new negociosRol();
                object[] objInstancia = dtLocal.Rows[0].ItemArray;
                temporal.setIdRol(Convert.ToInt32(objInstancia[0]));
                temporal.setNombre(Convert.ToString(objInstancia[1]));
                temporal.larrbyPermisosRoles = (byte[])objInstancia[2];
                temporal.larrbyPermisosEmpleados = (byte[])objInstancia[3];
                temporal.larrbyPermisosProveedores = (byte[])objInstancia[4];
                temporal.larrbyPermisosProductos = (byte[])objInstancia[5];
                temporal.larrbyPermisosCompras = (byte[])objInstancia[6];
                temporal.larrbyPermisosClientes = (byte[])objInstancia[7];
                temporal.larrbyPermisosVentas = (byte[])objInstancia[8];
                temporal.larrbyPermisosReportes = (byte[])objInstancia[9];
                temporal.liNivelAcceso = Convert.ToInt32(objInstancia[10]);
            }
            return temporal;
        }
        #endregion
    }
}
