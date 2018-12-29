using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.DescripcionHabitacionTableAdapters;

namespace CapaProceso.Clases
{
    public class DescripcionHabitacion
    {
        private static descripcion_habitacionTableAdapter CDescripcion = new descripcion_habitacionTableAdapter();

        public static CapaDatos.Clases.DescripcionHabitacion.descripcion_habitacionDataTable Lista()
        {
            return CDescripcion.GetLista();
        }


        public static CapaDatos.Clases.DescripcionHabitacion.descripcion_habitacionDataTable ListaHabitacion()
        {
            return CDescripcion.GetListaHabitacion();
        }

        public static CapaDatos.Clases.DescripcionHabitacion.descripcion_habitacionDataTable ListaActualizar(short idDescripcion)
        {
            return CDescripcion.GetListaActualizar(idDescripcion);
        }


        public static CapaDatos.Clases.DescripcionHabitacion.descripcion_habitacionDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CDescripcion.GetBuscar(buscarAux);
        }


        public static string Insertar(string descripcionHabitacion, string estadoDescripcion, short idTipoHabitacion)
        {

            string Lista = CDescripcion.unico(descripcionHabitacion,idTipoHabitacion).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CDescripcion.InsertQuery(descripcionHabitacion.Trim().ToUpper(), estadoDescripcion.Trim().ToUpper(), idTipoHabitacion);
                if (resultado == 0)
                {
                    return mensaje = "Error al insertar los registros";
                }
                else
                {
                    return mensaje = "";
                }

            }
            else
            {
                return mensaje = "La CI ya existe";
            }
        }




        public static string Actualizar(string descripcionHabitacion, string estadoDescripcion, short idTipoHabitacion, short idDescripcion)
        {

            string mensaje = "";
            int resultado = CDescripcion.UpdateQuery(descripcionHabitacion.Trim().ToUpper(), estadoDescripcion.Trim().ToUpper(), idTipoHabitacion, idDescripcion);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idDescripcion)
        {
            string mensaje = "";

            try
            {

                int resultado = CDescripcion.DeleteQuery(idDescripcion);
                if (resultado == 0)
                {
                    return mensaje = "No se puede eliminar una asignación inactiva";
                }
                else
                {
                    return mensaje = "";
                }


            }
            catch
            {
                return mensaje = "No se puede eliminar existen resistros asociados";
            }


        }
    }
}
