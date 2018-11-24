using CapaDatos.Clases.HabitacionEstadoTableAdapters;
using System;

namespace CapaProceso.Clases
{
    public class HabitacionEstado
    {

        private static Habitacion_EstadoTableAdapter CHabitacionEstado = new Habitacion_EstadoTableAdapter();

        public static CapaDatos.Clases.HabitacionEstado.Habitacion_EstadoDataTable Lista()
        {
            return CHabitacionEstado.GetLista();
        }

        //  public static CapaDatos.Clases.HabitacionEstado.Habitacion_EstadoDataTable ListaActualizar(short idHabitacion_Estado)
        // {
        //   return CHabitacionEstado.GetListaActualizar(idHabitacion_Estado);
        //}


        public static CapaDatos.Clases.HabitacionEstado.Habitacion_EstadoDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CHabitacionEstado.GetBuscar( buscarAux);
        }



    }
}
