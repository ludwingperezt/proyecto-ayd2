using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocios
{
    public class negociosDetalleFacturaCliente
    {
        private int giIdDetalleFacturaCliente;
        private int giIdEncabezadoFacturaCliente;
        private short gshIdProducto;
        private decimal gdecPrecio;
        private double gduCantidad;

        public void fnsInsertarDetalleFacturaCliente()
        {
            negociosAdaptadores.gAdaptadorDeConsultas.insertarDetalleFacturaCliente(this.giIdEncabezadoFacturaCliente, this.gshIdProducto, gdecPrecio, this.gduCantidad);
        }
    }
}
