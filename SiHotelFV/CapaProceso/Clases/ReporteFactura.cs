using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ReporteFacturaTableAdapters;
namespace CapaProceso.Clases
{
    public class ReporteFactura
    {

        private static reservasTableAdapter CReporte = new reservasTableAdapter();

        public static CapaDatos.Clases.ReporteFactura.reservasDataTable Reporte()
        {
            return CReporte.Factura();
        }
    }
}
