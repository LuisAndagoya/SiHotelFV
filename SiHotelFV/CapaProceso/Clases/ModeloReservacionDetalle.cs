using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaProceso.Clases
{
    public class ModeloReservacionDetalle
    {       
        
        public int numeroHabitacion { get; set; }
        
        public Decimal valor { get; set; }

        public string Tipo { get; set; }
        public  ModeloReservacionDetalle(int numeroHabitacion, Decimal valor, string Tipo)
        {            
            this.numeroHabitacion = numeroHabitacion;           
            this.valor = valor;
            this.Tipo = Tipo;
        }

        public ModeloReservacionDetalle()
        {

        }



    }
}
