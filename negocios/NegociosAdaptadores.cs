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
        public static buscarClienteNombreTableAdapter gAdaptadorClienteNombre = new buscarClienteNombreTableAdapter();
        public static buscarTipoClienteNombre1TableAdapter gAdaptadorTipoClienteNombre = new buscarTipoClienteNombre1TableAdapter();

    }
}
