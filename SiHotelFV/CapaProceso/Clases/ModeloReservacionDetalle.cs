using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaProceso.Clases
{
    public class ModeloReservacionDetalle
    {
        public int idDetalle { get; set; }
        public int idReserva { get; set; }
        public int numeroHabitacion { get; set; }
        public string fechaActual { get; set; }
        public float valor { get; set; }
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
