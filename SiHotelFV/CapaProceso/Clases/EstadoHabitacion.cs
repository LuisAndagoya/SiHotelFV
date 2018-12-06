using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.EstadohabitacionTableAdapters;

namespace CapaProceso.Clases
{
    public class EstadoHabitacion
    {

        private static estado_habitacionTableAdapter CEstado = new estado_habitacionTableAdapter();

        public static CapaDatos.Clases.Estadohabitacion.estado_habitacionDataTable Lista()
        {
            return CEstado.GetLista();
        }

        public static CapaDatos.Clases.Estadohabitacion.estado_habitacionDataTable ListaActualizar(short idEstadoHabitacion)
        {
            return CEstado.GetListaActualizar(idEstadoHabitacion);
        }


        public static CapaDatos.Clases.Estadohabitacion.estado_habitacionDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CEstado.GetBuscar(buscarAux);
        }

        public static string Insertar(string NombreEstado)
        {

            string Lista = CEstado.unico(NombreEstado).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CEstado.InsertQuery(NombreEstado.Trim().ToUpper());
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




        public static string Actualizar(string NombreEstado, short idEstadoHabitacion)
        {

            string mensaje = "";
            int resultado = CEstado.UpdateQuery(NombreEstado.Trim(), idEstadoHabitacion);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idEstadoHabitacion)
        {
            string mensaje = "";

            try
            {

                int resultado = CEstado.DeleteQuery(idEstadoHabitacion);
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
