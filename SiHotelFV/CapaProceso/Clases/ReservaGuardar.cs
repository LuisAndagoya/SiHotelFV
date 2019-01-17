using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaProceso.Clases
{
    class ReservaGuardar
    {
        private short idCliente;
        private short idUsuario;
        private DateTime fechaReservacion;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private short idEstadoReserva;
        private float totalReservacion;

        public ReservaGuardar()
          {
            idCliente = 0;
            idUsuario = 0;
           // fechaReservacion = 
           // fechaEntrada = 
            //fechaSalida = 
            idEstadoReserva =0;
            totalReservacion = 0;
        }
        public  ReservaGuardar(short Cliente, short Usuario, DateTime FchReserva, DateTime FchEntrada, DateTime FchSalida, short Estado, float Total)
        {
            idCliente = Cliente;
            idUsuario = Usuario;
            fechaReservacion = FchReserva;
            fechaEntrada = FchEntrada;
            fechaSalida = FchSalida;
            idEstadoReserva = Estado;
            totalReservacion = Total;
            
        }

        public short Idusuario
        {

            get { return idUsuario; }
            set { idUsuario= value; }
        }
        public short Idcliente
        {

            get { return idCliente; }
            set { idCliente = value; }
        }

        public DateTime FechaReserva
        {

            get { return fechaReservacion; }
            set { fechaReservacion = value; }
        }

        public DateTime FechaEntrada
        {

            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }

        public DateTime FechaSalida
        {

            get { return fechaSalida; }
            set { fechaSalida = value; }
        }

        public short EstadoReserva
        {

            get { return idEstadoReserva; }
            set { idEstadoReserva = value; }
        }
        public float TotalReservacion
        {

            get { return totalReservacion; }
            set { totalReservacion = value; }
        }
    }
}

