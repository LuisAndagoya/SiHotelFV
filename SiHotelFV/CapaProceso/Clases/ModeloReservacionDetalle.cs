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
        
        public float valor { get; set; }
        public  ModeloReservacionDetalle(int numeroHabitacion, float valor)
        {            
            this.numeroHabitacion = numeroHabitacion;           
            this.valor = valor;
        }

        public ModeloReservacionDetalle()
        {

        }



    }
}
