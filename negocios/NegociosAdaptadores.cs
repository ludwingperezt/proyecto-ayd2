using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datos.ConexionBaseDatosTableAdapters;

namespace negocios
{
    public static class negociosAdaptadores
    {
        public static QueriesTableAdapter gAdaptadorDeConsultas = new QueriesTableAdapter();
        public static mostrarProductosTableAdapter gAdaptadorListaProductos = new mostrarProductosTableAdapter();
        public static mostrarRolesTableAdapter gAdaptadorListaRoles = new mostrarRolesTableAdapter();
        public static mostrarSeriesTableAdapter gAdaptadorListaSeries = new mostrarSeriesTableAdapter();
        public static listarProveedoresTableAdapter gAdaptadorListarProveedores = new listarProveedoresTableAdapter();
        public static paginacionProveedoresTableAdapter gAdaptadorPaginacionProveedores = new paginacionProveedoresTableAdapter();
        public static ListarClientesTableAdapter gAdaptadorListarClientes = new ListarClientesTableAdapter();
        public static ListarTiposClientesTableAdapter gAdaptadorListarTiposClientes = new ListarTiposClientesTableAdapter();
        public static ListarEmpleadosTableAdapter gAdaptadorListaEmpleados = new ListarEmpleadosTableAdapter();
        public static listarFacturasProveedorEliminadasTableAdapter gAdaptadorListarFacturasProveedorEliminadas = new listarFacturasProveedorEliminadasTableAdapter();
        public static insertarEncabezadoFacturaClienteTableAdapter gAdaptadorEncabezadoFacturaCliente = new insertarEncabezadoFacturaClienteTableAdapter();
        public static buscarProveedorPorNitTableAdapter gAdaptadorBuscarProveedorPorNit = new buscarProveedorPorNitTableAdapter();
        public static buscarProveedorPorEstadoTableAdapter gAdaptadorBuscarProveedorPorEstado = new buscarProveedorPorEstadoTableAdapter();
        public static buscarProveedorPorPropietaioTableAdapter gAdaptadorBuscarProveedorPorPropietario = new buscarProveedorPorPropietaioTableAdapter();
        public static buscarProveedorPorNombreTableAdapter gAdaptadorBuscarProveedorPorNombre = new buscarProveedorPorNombreTableAdapter();
        public static buscarProveedorPorEmpresaTableAdapter gAdaptadorBuscarProveedorPorEmpresa = new buscarProveedorPorEmpresaTableAdapter();
        public static buscarEmpleadoNombre1TableAdapter gAdaptadorEmpleadoNombre = new buscarEmpleadoNombre1TableAdapter();
        public static buscarClienteNit1TableAdapter gAdaptadorClienteNit = new buscarClienteNit1TableAdapter();
        public static buscarClienteNombre1TableAdapter gAdaptadorClienteNombre = new buscarClienteNombre1TableAdapter();
        public static buscarTipoClienteNombre1TableAdapter gAdaptadorTipoClienteNombre = new buscarTipoClienteNombre1TableAdapter();
        public static ultimosVeinteEmpleadosTableAdapter gAdaptadorUltimosVeinteEmpleados = new ultimosVeinteEmpleadosTableAdapter();
        public static buscarSeriePorSerieTableAdapter gAdaptadorBuscarSeriePorSerie = new buscarSeriePorSerieTableAdapter();
        public static buscarEmpleadoUsuario1TableAdapter gAdaptadorBuscarEmpleadoUsuario = new buscarEmpleadoUsuario1TableAdapter ();
        public static ultimasVeinteComprasTableAdapter gAdaptadorUltimasVeinteCompras = new ultimasVeinteComprasTableAdapter();
        public static buscarEmpleadoApellido1TableAdapter gAdaptadorBuscarEmpleadoApellido = new buscarEmpleadoApellido1TableAdapter();
        public static ultimosVeinteClientesTableAdapter gAdaptadorBuscarVeinteClientes = new ultimosVeinteClientesTableAdapter();
        public static ultimosVeinteClientesTableAdapter gClientes = new ultimosVeinteClientesTableAdapter();
        public static buscarEmpleadoCedulaDpiTableAdapter gAdaptadorBuscarEmpleadoCedulaDpi = new buscarEmpleadoCedulaDpiTableAdapter();
        public static buscarClienteTipoClienteTableAdapter gAdaptadorBuscarClienteTipoCliente = new buscarClienteTipoClienteTableAdapter();
        public static buscarClienteNitTableAdapter gAdaptadorBuscarClientesNit = new buscarClienteNitTableAdapter();
        public static devolverIdFacturaTableAdapter gAdaptadorDevolverIdFactura = new devolverIdFacturaTableAdapter();
        public static buscarClienteDireccionTableAdapter gAdaptadorClientePorDireccion = new buscarClienteDireccionTableAdapter();
        public static buscarClienteNit2TableAdapter gAdaptadorClientePorNit2 = new buscarClienteNit2TableAdapter();
        public static buscarTipoClienteDescripcionTableAdapter gAdapatadorTipoClienteDescripcion = new buscarTipoClienteDescripcionTableAdapter();
        public static buscarTipoClienteDescuentoTableAdapter gAdaptadorTipoClienteDescuento = new buscarTipoClienteDescuentoTableAdapter();
        public static buscarTipoClienteNombreTableAdapter gAdaptadorTipoClienteNombre = new buscarTipoClienteNombreTableAdapter();


        public static datos.ConexionFuncionesEspecialesTableAdapters.buscarProductoPorCodigoTableAdapter gAdaptadorProductoPorCodigo = new datos.ConexionFuncionesEspecialesTableAdapters.buscarProductoPorCodigoTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.buscarProductoPorIdTableAdapter gAdaptadorProductoPorId = new datos.ConexionFuncionesEspecialesTableAdapters.buscarProductoPorIdTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.buscarProductoPorNombreTableAdapter gAdaptadorProductoPorNombre = new datos.ConexionFuncionesEspecialesTableAdapters.buscarProductoPorNombreTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.devolverRolPorIdTableAdapter gAdaptadorRolPorId = new datos.ConexionFuncionesEspecialesTableAdapters.devolverRolPorIdTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.obtenerSeriePorEstacionTableAdapter gAdaptadorSerieEstacion = new datos.ConexionFuncionesEspecialesTableAdapters.obtenerSeriePorEstacionTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.obtenerSeriePorSucursalTableAdapter gAdaptadorSerieSucursal = new datos.ConexionFuncionesEspecialesTableAdapters.obtenerSeriePorSucursalTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.paginacionProductosTableAdapter gAdaptadorPaginacionProductos = new datos.ConexionFuncionesEspecialesTableAdapters.paginacionProductosTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.obtenerProductoPorCodigoTableAdapter gAdaptadorObtenerProductoPorCodigo = new datos.ConexionFuncionesEspecialesTableAdapters.obtenerProductoPorCodigoTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.obtenerProductoPorNombreTableAdapter gAdaptadorObtenerProductoPorNombre = new datos.ConexionFuncionesEspecialesTableAdapters.obtenerProductoPorNombreTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.QueriesTableAdapter gAdaptadorGeneral = new datos.ConexionFuncionesEspecialesTableAdapters.QueriesTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.obtenerSerieEspecificaPorEstacionTableAdapter gAdaptadorFuncionesEspeciales = new datos.ConexionFuncionesEspecialesTableAdapters.obtenerSerieEspecificaPorEstacionTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.busquedaExactaProductoTableAdapter gAdaptadorBusquedaExactaAmbosCriterios = new datos.ConexionFuncionesEspecialesTableAdapters.busquedaExactaProductoTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.bcnTableAdapter gAdaptadorBcn = new datos.ConexionFuncionesEspecialesTableAdapters.bcnTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.icEspecialTableAdapter gAdaptadorInsClDevolverId = new datos.ConexionFuncionesEspecialesTableAdapters.icEspecialTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.busquedaclnmdirTableAdapter gAdaptadorBuquedaExactaClNombreDireccion = new datos.ConexionFuncionesEspecialesTableAdapters.busquedaclnmdirTableAdapter();

        public static datos.ConexionFuncionesEspecialesTableAdapters.buscarDetalleFacturaTableAdapter gBuscarDetalleFactura = new datos.ConexionFuncionesEspecialesTableAdapters.buscarDetalleFacturaTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.buscarFacturasPorSerieNumeroTableAdapter gBuscarFacturaSerieNumero = new datos.ConexionFuncionesEspecialesTableAdapters.buscarFacturasPorSerieNumeroTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.paginacionFacturasClienteTableAdapter gPaginacionFacturasClientes = new datos.ConexionFuncionesEspecialesTableAdapters.paginacionFacturasClienteTableAdapter();

        public static datos.ConexionFuncionesEspecialesTableAdapters.obtenerClienteYTipoClienteTableAdapter gAdaptadorClienteTipoCliente = new datos.ConexionFuncionesEspecialesTableAdapters.obtenerClienteYTipoClienteTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.obtenerNombreApellidoEmpleadoTableAdapter gAdaptadorNombreApellidosEmpleado = new datos.ConexionFuncionesEspecialesTableAdapters.obtenerNombreApellidoEmpleadoTableAdapter();
        public static datos.ConexionFuncionesEspecialesTableAdapters.obtenerEmpleadoValidoTableAdapter gAdaptadorGetEmpleadoValidoLogin = new datos.ConexionFuncionesEspecialesTableAdapters.obtenerEmpleadoValidoTableAdapter();
    }
}
