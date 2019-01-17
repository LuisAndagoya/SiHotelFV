using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ReporteTipoHabitacionTableAdapters;

namespace CapaProceso.Clases
{
   public class ReporteTipoHabitacion
    {

        private static tipo_habitacionTableAdapter CReporte = new tipo_habitacionTableAdapter();

        public static CapaDatos.Clases.ReporteTipoHabitacion.tipo_habitacionDataTable Reporte(short Id)
        {
            return CReporte.Reporte(Id);
        }
    }
}
