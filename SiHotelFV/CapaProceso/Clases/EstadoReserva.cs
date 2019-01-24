using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.EstadoReservaTableAdapters;

namespace CapaProceso.Clases
{
   public  class EstadoReserva
    {
        private static estado_reservaTableAdapter CReserva = new estado_reservaTableAdapter();

        public static CapaDatos.Clases.EstadoReserva.estado_reservaDataTable Lista()
        {
            return CReserva.GetLista();
        }

        public static CapaDatos.Clases.EstadoReserva.estado_reservaDataTable ListaActualizar(short idEstadoReserva)
        {
            return CReserva.GetListaActualizar(idEstadoReserva);
        }

        public static CapaDatos.Clases.EstadoReserva.estado_reservaDataTable GetEstadoReserva12()
        {
            return CReserva.GetEstadoReserva12();
        }


        public static CapaDatos.Clases.EstadoReserva.estado_reservaDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CReserva.GetBuscar(buscarAux);
        }

        public static string Insertar(string nombreEstado)
        {

            string Lista = CReserva.unico(nombreEstado).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CReserva.InsertQuery(nombreEstado.Trim().ToUpper());
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




        public static string Actualizar(string nombreEstado, short idEstadoReserva)
        {

            string mensaje = "";
            int resultado = CReserva.UpdateQuery(nombreEstado.Trim(), idEstadoReserva);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idEstadoReserva)
        {
            string mensaje = "";

            try
            {

                int resultado = CReserva.DeleteQuery(idEstadoReserva);
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
