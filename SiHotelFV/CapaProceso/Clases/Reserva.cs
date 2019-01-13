using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ReservaTableAdapters;

namespace CapaProceso.Clases
{
    public class Reserva
    {
        private static reservasTableAdapter CReserva = new reservasTableAdapter();

        public static CapaDatos.Clases.Reserva.reservasDataTable ListaReservaRe()
        {
            return CReserva.GetListaReservaRe();
        }

        public static CapaDatos.Clases.Reserva.reservasDataTable Factura(short Id)
        {
            return CReserva.GetFactura(Id);
        }
        public static CapaDatos.Clases.Reserva.reservasDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CReserva.GetBuscar( buscarAux, buscarAux);
        }
    }
}
