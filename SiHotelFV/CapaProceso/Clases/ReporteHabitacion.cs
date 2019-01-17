using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ReporteHabitacionTableAdapters;

namespace CapaProceso.Clases
{
   public  class ReporteHabitacion
    {
        private static habitacionTableAdapter CReporte = new habitacionTableAdapter();

        public static CapaDatos.Clases.ReporteHabitacion.habitacionDataTable Reporte(short Id)
        {
            return CReporte.Reporte(Id);
        }

        public static CapaDatos.Clases.ReporteHabitacion.habitacionDataTable Lista()
        {
            return CReporte.Lista();
        }
    }
}
