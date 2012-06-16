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
        public static mostrarPuestosTableAdapter gListarPuestos = new mostrarPuestosTableAdapter();
        public static mostrarTodosTiposUsuariosTableAdapter gListarTiposUsuario = new mostrarTodosTiposUsuariosTableAdapter();
    }
}
