using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos.ConexionBaseDatosTableAdapters;

namespace negocios
{
    public static class negociosAdaptadores
    {
        public static QueriesTableAdapter gAdaptadorDeConsultas = new QueriesTableAdapter();
        public static mostrarProductosTableAdapter gAdaptadorListaProductos = new mostrarProductosTableAdapter();
        public static mostrarRolesTableAdapter gAdaptadorListaRoles = new mostrarRolesTableAdapter();
        public static mostrarSeriesTableAdapter gAdaptadorListaSeries = new mostrarSeriesTableAdapter();
        public static ListarClientesTableAdapter gAdaptadorListarClientes = new ListarClientesTableAdapter();
    }
}
