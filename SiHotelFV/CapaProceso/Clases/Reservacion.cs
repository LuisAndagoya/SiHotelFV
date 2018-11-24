using CapaDatos.Clases.ReservacionTableAdapters;
using System;
namespace CapaProceso.Clases
{
    public class Reservacion
    {


        private static ReservacionTableAdapter CReservacion = new ReservacionTableAdapter();

        public static CapaDatos.Clases.Reservacion.ReservacionDataTable Lista()
        {
            return CReservacion.GetLista();
        }

        //  public static CapaDatos.Clases.Reservacion.ReservacionDataTable ListaActualizar(short idReservacion)
        // {
        //   return CReservacion.GetListaActualizar(idReservacion);
        //}


        public static CapaDatos.Clases.Reservacion.ReservacionDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CReservacion.GetBuscar( buscarAux, buscarAux);
        }


    }
}
