using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.FacTableAdapters;

namespace CapaProceso.Clases
{
   public class Factura
    {

        private static reservasTableAdapter CFactura = new reservasTableAdapter();

        public static CapaDatos.Clases.Fac.reservasDataTable Lista(short Id)
        {
            return CFactura.Lista(Id);
        }

      
    }
}
