using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    public class negociosFacturaCliente
    {
        private int giIdFactura;
        private string gsNIT;
        private byte gbyIdEmpleado;
        private string gsSerie;
        private int giNumero;
        private DateTime gdtFecha;
        private double gduDescuento;
        private decimal gdecSubTotal;
        private decimal gdecTotal;
        private List<negociosDetalleFacturaCliente> glstListaDetalleFactura;

        public int fniInsertarEncabezadoFacturaCliente()
        {
            DataTable tablaTemporal = negociosAdaptadores.gAdaptadorEncabezadoFacturaCliente.GetData(gsNIT, gbyIdEmpleado, gsSerie, gduDescuento, gdecSubTotal, gdecTotal);
            object o = tablaTemporal.Rows[0].ItemArray[0];
            this.giIdFactura = Convert.ToInt32(o);
            this.giNumero = (int)negociosAdaptadores.gAdaptadorDeConsultas.obtenerNumeroFacturaCliente(this.giIdFactura);
            return this.giIdFactura;
        }

    }
}
