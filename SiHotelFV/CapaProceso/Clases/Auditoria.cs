using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.AuditoriaTableAdapters;


namespace CapaProceso.Clases
{
   public  class Auditoria
    {

        private static auditoriaTableAdapter CAuditoria = new auditoriaTableAdapter();

        public static CapaDatos.Clases.Auditoria.auditoriaDataTable Lista()
        {
            return CAuditoria.GetLista();
        }

    


        public static CapaDatos.Clases.Auditoria.auditoriaDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CAuditoria.GetBuscar(buscarAux);
        }
    }
}
