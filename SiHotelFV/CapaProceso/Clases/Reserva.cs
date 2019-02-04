using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ReservaTableAdapters;

namespace CapaProceso.Clases
{
    public class Reserva
    {
        private static reservasTableAdapter CReserva = new reservasTableAdapter();

        public static CapaDatos.Clases.Reserva.reservasDataTable ListaReservaRe()
        {
            return CReserva.GetListaReservaRe();
        }

        public static CapaDatos.Clases.Reserva.reservasDataTable GetListaReserva()
        {
            return CReserva.GetListaReserva();
        }

        public static CapaDatos.Clases.Reserva.reservasDataTable Detalle()
        {
            return CReserva.GetDetalle();
        }
        public static CapaDatos.Clases.Reserva.reservasDataTable Factura(short Id)
        {
            return CReserva.GetFactura(Id);
        }

        public static short IdReserva()
        {
            return (short) CReserva.GetIdReserva();
        }

        public static CapaDatos.Clases.Reserva.reservasDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CReserva.GetBuscar(buscarAux, buscarAux);
        }

       
        public static string Insertar(ReservaGuardar reservaGuardar)
        {
            string mensaje = "";


            int resultado = CReserva.InsertarReserva(reservaGuardar.idCliente, reservaGuardar.idUsuario, reservaGuardar.fechaReservacion, reservaGuardar.fechaEntrada, reservaGuardar.fechaSalida, reservaGuardar.idEstadoReserva, (double) reservaGuardar.totalReservacion, reservaGuardar.SaldoReserva, reservaGuardar.PagadoReserva);
            if (resultado == 0)
            {
                return mensaje = "Error al insertar los registros";
            }
            else
            {
                return mensaje = "";
            }

        }

        public static string ActualizarEstado(short idReservacion, short idEstadoReserva)
        {
            string mensaje = "";


            int resultado = CReserva.ActializarEstado(idEstadoReserva, idReservacion);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }

        }

    }
}

