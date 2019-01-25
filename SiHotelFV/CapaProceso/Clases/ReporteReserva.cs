using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ReporteReservaTableAdapters;

namespace CapaProceso.Clases
{
   public class ReporteReserva
    {
        private static reservasTableAdapter CReserva = new reservasTableAdapter();

        public static CapaDatos.Clases.ReporteReserva.reservasDataTable Fecha(string Fechas)
        {
            return CReserva.Fecha(Fechas);
        }
        public static CapaDatos.Clases.ReporteReserva.reservasDataTable Cabecera(short Id)
        {
            return CReserva.Cabecera(Id);
        }
        public static CapaDatos.Clases.ReporteReserva.reservasDataTable Usuario(short Id)
        {
            return CReserva.Usuario(Id);
        }
        public static CapaDatos.Clases.ReporteReserva.reservasDataTable Estado(short Id)
        {
            return CReserva.Estado(Id);
        }

        public static CapaDatos.Clases.ReporteReserva.reservasDataTable Cliente(string Id)
        {
            return CReserva.Cliente(Id);
        }
        public static CapaDatos.Clases.ReporteReserva.reservasDataTable Factura()
        {
            return CReserva.Factura();
        }
    }
}
