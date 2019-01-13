using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaProceso.Clases
{
    public class ModeloReservacionDetalle
    {
        private int idDetalle { get; set; }
        private int idReserva { get; set; }
        private int numeroHabitacion { get; set; }
        private string fechaActual { get; set; }
        private float valor { get; set; }
        public void load(int idDetalle, int idReserva, int numeroHabitacion, string fechaActual, float valor)
        {
            this.idDetalle = idDetalle;
            this.idReserva = idReserva;
            this.numeroHabitacion = numeroHabitacion;
            this.fechaActual = fechaActual;
            this.valor = valor;

        }

       


    }
}
