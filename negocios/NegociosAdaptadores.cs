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
        public static ListarClientesTableAdapter gAdaptadorListarClientes = new ListarClientesTableAdapter();
        public static ListarTiposClientesTableAdapter gAdaptadorListarTiposClientes = new ListarTiposClientesTableAdapter();
        public static ListarEmpleadosTableAdapter gAdaptadorListaEmpleados = new ListarEmpleadosTableAdapter();
        public static listarFacturasProveedorEliminadasTableAdapter gAdaptadorListarFacturasProveedorEliminadas = new listarFacturasProveedorEliminadasTableAdapter();
        public static insertarEncabezadoFacturaClienteTableAdapter gAdaptadorEncabezadoFacturaCliente = new insertarEncabezadoFacturaClienteTableAdapter();
        public static buscarProveedorPorNitTableAdapter gAdaptadorRegistroProveedor = new buscarProveedorPorNitTableAdapter();
        public static buscarEmpleadoNombre1TableAdapter gAdaptadorEmpleadoNombre = new buscarEmpleadoNombre1TableAdapter();
        public static buscarClienteNit1TableAdapter gAdaptadorClienteNit = new buscarClienteNit1TableAdapter();
        public static buscarClienteNombreTableAdapter gAdaptadorClienteNombre = new buscarClienteNombreTableAdapter();
        public static buscarTipoClienteNombre1TableAdapter gAdaptadorTipoClienteNombre = new buscarTipoClienteNombre1TableAdapter();
        public static ultimosVeinteEmpleadosTableAdapter gAdaptadorUltimosVeinteEmpleados = new ultimosVeinteEmpleadosTableAdapter();
        public static buscarSeriePorSerieTableAdapter gAdaptadorBuscarSeriePorSerie = new buscarSeriePorSerieTableAdapter();
        public static buscarEmpleadoUsuario1TableAdapter gAdaptadorBuscarEmpleadoUsuario = new buscarEmpleadoUsuario1TableAdapter ();

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
    }
}
