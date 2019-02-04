using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.Clases;

namespace CapaProceso.Clases
{
    public class ReservaGuardar
    {
        public int idReservacion { get; set; }
        public int idCliente { get; set; }
        public int idUsuario { get; set; }

        public String fechaReservacion { get; set; }
        public String fechaEntrada { get; set; }
        public String fechaSalida { get; set; }
        public int idEstadoReserva { get; set; }
        public Decimal totalReservacion { get; set; }
        public Decimal SaldoReserva { get; set; }
        public Decimal PagadoReserva { get; set; }


        public ReservaGuardar(int idReservacion, int idCliente, int idUsuario, String fechaReservacion, String fechaEntrada, String fechaSalida, int idEstadoReserva, Decimal totalReservacion, Decimal SaldoReserva, Decimal PagadoReserva)
        {
            this.idReservacion = idReservacion;
            this.idCliente = idCliente;
            this.idUsuario = idUsuario;
            this.fechaReservacion = fechaReservacion;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.idEstadoReserva = idEstadoReserva;
            this.totalReservacion = totalReservacion;
            this.SaldoReserva = SaldoReserva;
            this.PagadoReserva = PagadoReserva;

        }

        public ReservaGuardar()
        {

        }
    }
       
}

