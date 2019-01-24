using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.DetalleReservaTableAdapters;

namespace CapaProceso.Clases
{
   public class DetalleReserva
    {
        private static detalle_reservaTableAdapter CReserva = new detalle_reservaTableAdapter();

        public static CapaDatos.Clases.DetalleReserva.detalle_reservaDataTable GetListaDetalleReserva()
        {
            return CReserva.GetListaDetalleReserva();
        }


        public static string Insertar( short Id, string fechaActual, ModeloReservacionDetalle detalleGuardar)
        {
            string mensaje = "";


            int resultado = CReserva.InsertarDetalle(Id, detalleGuardar.numeroHabitacion, fechaActual, detalleGuardar.valor);


            if (resultado == 0)
            {
                return mensaje = "Error al insertar los registros";
            }
            else
            {
                return mensaje = "";
            }

        }

       

    }
}
