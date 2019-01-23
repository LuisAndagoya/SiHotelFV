using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ReportePersonaTableAdapters;

namespace CapaProceso.Clases
{
   public class ReporteCliente
    {
        private static clienteTableAdapter CCliente = new clienteTableAdapter();

        public static CapaDatos.Clases.ReportePersona.clienteDataTable Reporte(string Id)
        {
            return CCliente.Reporte(Id);
        }

    }
}
