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
        /// Función de acceso al permiso de creación de roles, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCreacionRol()
        {
            return larrbyPermisosRoles[0];
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de roles, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarRoles()
        {
            return larrbyPermisosRoles[1];
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de roles, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoModificacionRol()
        {
            return larrbyPermisosRoles[2];
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de roles, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoEliminacionRol()
        {
            return larrbyPermisosRoles[3];
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCreacionEmpleados()
        {
            return larrbyPermisosEmpleados[0];
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de empleados, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarEmpleados()
        {
            return larrbyPermisosEmpleados[1];
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de datos de empleados, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoModificacionEmpleados()
        {
            return larrbyPermisosEmpleados[2];
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de empleados, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoEliminacionEmpleados()
        {
            return larrbyPermisosEmpleados[3];
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCreacionProveedores()
        {
            return larrbyPermisosProveedores[0];
        }
        /// <summary>
        /// Función de acceso al permiso de listado de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarProveedores()
        {
            return larrbyPermisosProveedores[1];
        }
        /// <summary>
        /// Función de acceso al permiso de búsqueda de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoBuscarProveedores()
        {
            return larrbyPermisosProveedores[4];
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de datos de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoModificacionProveedores()
        {
            return larrbyPermisosProveedores[2];
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de proveedores, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoEliminacionProveedores()
        {
            return larrbyPermisosProveedores[3];
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCreacionProductos()
        {
            return larrbyPermisosProductos[0];
        }
        /// <summary>
        /// Función de acceso al permiso de listado de productos, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarProductos()
        {
            return larrbyPermisosProductos[1];
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de datos de productos, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoModificacionProductos()
        {
            return larrbyPermisosProductos[2];
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de productos, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoEliminacionProductos()
        {
            return larrbyPermisosProductos[3];
        }
        /// <summary>
        /// Función de acceso al permiso de búsqueda de productos, para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoBusquedaProductos()
        {
            return larrbyPermisosProductos[4];
        }
        /// <summary>
        /// Función de acceso al permiso de carga de productos (aumentar existencias), para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCargarProductos()
        {
            return larrbyPermisosProductos[5];
        }
        /// <summary>
        /// Función de acceso al permiso de descarga de productos (disminuir existencias), para éste rol de acceso
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoDescargarProductos()
        {
            return larrbyPermisosProductos[6];
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCompra()
        {
            return larrbyPermisosCompras[0];
        }
        /// <summary>
        /// Función de acceso al permiso para hacer anotaciones de crédito a favor y devolver productos a proveedores
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoDevolverProductosProveedores()
        {
            return larrbyPermisosCompras[1];
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCreacionClientes()
        {
            return larrbyPermisosClientes[0];
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de clientes
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarClientes()
        {
            return larrbyPermisosClientes[1];
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de clientes
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoModificacionClientes()
        {
            return larrbyPermisosClientes[2];
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoVentas()
        {
            return larrbyPermisosVentas[0];
        }
        /// <summary>
        /// Función de acceso al permiso específico para hacer modificaciones a facturas de venta (eliminar facturas y volver a crearlas)
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoEliminarFacturasVentas()
        {
            return larrbyPermisosVentas[1];
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
        public void setPermisoListarFacturasVentaEliminadas(byte lbyPermiso)
        {
            this.larrbyPermisosReportes[1] = lbyPermiso;
        }
        /// <summary>
        /// Función que asigna un permiso específico para listar devoluciones al proveedor
        /// </summary>
        /// <param name="lbyPermiso">byte: un numero que indica el nivel de permiso asignado</param>
        public void setPermisoListarDevolucionesProveedor(byte lbyPermiso)
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCortesCaja()
        {
            return larrbyPermisosReportes[0];
        }
        /// <summary>
        /// Función de acceso al permiso para hacer listas de facturas de venta eliminadas
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarFacturasVentaEliminadas()
        {
            return larrbyPermisosReportes[1];
        }
        /// <summary>
        /// Función de acceso al permiso para hacer listas de devoluciones de producto al proveedor
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarDevolucionesProveedor()
        {
            return larrbyPermisosReportes[2];
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de costos
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoHistorialCostos()
        {
            return larrbyPermisosReportes[3];
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de ventas del mes
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoHistorialVentasMes()
        {
            return larrbyPermisosReportes[4];
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de compras del mes
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoHistorialComprasMes()
        {
            return larrbyPermisosReportes[5];
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de crédito por proveedor
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoHistorialCreditoPorProveedor()
        {
            return larrbyPermisosReportes[6];
        }
        /// <summary>
        /// Función de acceso al permiso para ver el historial de crédito por mes
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoHistorialCreditoMes()
        {
            return larrbyPermisosReportes[7];
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCreacionSerieFacturaVenta()
        {
            return larrbyPermisosRoles[4];
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de series de facturas de venta
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarSerieFacturaVenta()
        {
            return larrbyPermisosRoles[5];
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de series de facturas de venta
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoModificacionSerieFacturaVenta()
        {
            return larrbyPermisosRoles[6];
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de series de facturas de venta
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoEliminacionSerieFacturaVenta()
        {
            return larrbyPermisosRoles[7];
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
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoCreacionTiposCliente()
        {
            return larrbyPermisosEmpleados[4];
        }
        /// <summary>
        /// Función de acceso al permiso de listado y búsqueda de tipos de cliente
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoListarTiposCliente()
        {
            return larrbyPermisosEmpleados[5];
        }
        /// <summary>
        /// Función de acceso al permiso de modificación de datos de tipos de cliente
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoModificacionTiposCliente()
        {
            return larrbyPermisosEmpleados[6];
        }
        /// <summary>
        /// Función de acceso al permiso de Eliminación de tipos de cliente
        /// </summary>
        /// <returns>byte: el número que representa el permiso concedido a éste rol</returns>
        public byte getPermisoEliminacionTiposCliente()
        {
            return larrbyPermisosEmpleados[7];
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
        /// Función para listar todos los roles activos dentro de la base de datos
        /// </summary>
        /// <returns>DataTable: todos los roles activos en la base de datos</returns>
        public DataTable listarRoles()
        {
            return negociosAdaptadores.gAdaptadorListaRoles.GetData();
        }
        #endregion
    }
}
