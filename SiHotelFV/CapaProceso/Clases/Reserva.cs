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
    }
}
