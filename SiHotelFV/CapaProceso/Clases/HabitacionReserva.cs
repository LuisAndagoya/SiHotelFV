using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.HabitacionReservaTableAdapters;

namespace CapaProceso.Clases
{
   public  class HabitacionReserva
    {
        private static reservasTableAdapter CReserva = new reservasTableAdapter();

        public static CapaDatos.Clases.HabitacionReserva.reservasDataTable Habitacion()
        {
            return CReserva.Habitacion();
        }

        public static CapaDatos.Clases.HabitacionReserva.reservasDataTable Nuevo()
        {
            return CReserva.Nuevo();
        }

        public static CapaDatos.Clases.HabitacionReserva.reservasDataTable Lista()
        {
            return CReserva.Lista();
        }
    }
}
