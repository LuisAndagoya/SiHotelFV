using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.PrecioHabitacionTableAdapters;

namespace CapaProceso.Clases
{
   public class PrecioHabitacion
    {
        private static precio_habitacionTableAdapter CPrecio = new precio_habitacionTableAdapter();

        public static CapaDatos.Clases.PrecioHabitacion.precio_habitacionDataTable Lista()
        {
            return CPrecio.GetLista();
        }

        public static CapaDatos.Clases.PrecioHabitacion.precio_habitacionDataTable ListaActualizar(short idPrecio)
        {
            return CPrecio.GetListaActualizar(idPrecio);
        }


        public static CapaDatos.Clases.PrecioHabitacion.precio_habitacionDataTable Buscar(string buscar)
        {
            String buscarAux =  buscar.Trim() ;
            return CPrecio.GetBuscar(Convert.ToInt16(buscarAux));
        }

        public static string Insertar(float precioHabitacion, string fechaPrecio, string estadoPrecio)
        {

            string Lista = CPrecio.unico(precioHabitacion).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CPrecio.InsertQuery(precioHabitacion, fechaPrecio, estadoPrecio.Trim().ToUpper());
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




        public static string Actualizar(float precioHabitacion, string fechaPrecio, string estadoPrecio, short idPrecio)
        {

            string mensaje = "";
            int resultado = CPrecio.UpdateQuery(precioHabitacion,fechaPrecio, estadoPrecio.Trim().ToUpper(), idPrecio);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idPrecio)
        {
            string mensaje = "";

            try
            {

                int resultado = CPrecio.DeleteQuery(idPrecio);
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
