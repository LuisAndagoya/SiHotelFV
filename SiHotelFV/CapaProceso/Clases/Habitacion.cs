using CapaDatos.Clases.HabitacionTableAdapters;
using System;

namespace CapaProceso.Clases
{
    public class Habitacion
    {
        private static HabitacionTableAdapter CHabitacion = new HabitacionTableAdapter();

        public static CapaDatos.Clases.Habitacion.HabitacionDataTable Lista()
        {
            return CHabitacion.GetLista();
        }

          public static CapaDatos.Clases.Habitacion.HabitacionDataTable ListaActualizar(short idHabitacion)
         {
           return CHabitacion.GetListaActualizar(idHabitacion);
        }


        public static CapaDatos.Clases.Habitacion.HabitacionDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CHabitacion.GetBuscar(buscarAux);
        }

  



   




    }
}
