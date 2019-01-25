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

        public static CapaDatos.Clases.Auditoria.auditoriaDataTable General()
        {
            return CAuditoria.General();
        }
        public static CapaDatos.Clases.Auditoria.auditoriaDataTable Reporte(DateTime Inicio, DateTime Fin)
        {
            return CAuditoria.Reporte(Inicio, Fin);
        }
        public static void Insertar(string AuditoriaTabla, string AuditoriaAccion, short UsuarioId)
        {

            DateTime AuditoriaFecha = System.DateTime.Now;
            string name = System.Net.Dns.GetHostName();
            string ip = System.Net.Dns.GetHostAddresses(name)[0].ToString();
           
            int resultado = CAuditoria.SetInsertar(ip, AuditoriaTabla, AuditoriaAccion, UsuarioId, AuditoriaFecha);

        }


        public static CapaDatos.Clases.Auditoria.auditoriaDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CAuditoria.GetBuscar(buscarAux);
        }
    }
}
