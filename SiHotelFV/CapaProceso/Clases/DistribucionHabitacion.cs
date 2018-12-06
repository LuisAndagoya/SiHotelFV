using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.DistribucionhabitacionTableAdapters;

namespace CapaProceso.Clases
{
   public class DistribucionHabitacion
    {

        private static distribucion_habitacionTableAdapter CDistribucion = new distribucion_habitacionTableAdapter();

        public static CapaDatos.Clases.Distribucionhabitacion.distribucion_habitacionDataTable Lista()
        {
            return CDistribucion.GetLista();
        }

        public static CapaDatos.Clases.Distribucionhabitacion.distribucion_habitacionDataTable ListaActualizar(short idDistribucion)
        {
            return CDistribucion.GetListaActualizar(idDistribucion);
        }


        public static CapaDatos.Clases.Distribucionhabitacion.distribucion_habitacionDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CDistribucion.GetBuscar(buscarAux);
        }

        public static string Insertar(string camaIndividual, string camaMatrimonial, string camaKing, short maximoPersonas, string televisionCable, string aireAcondicionado, string ventilador, string wifi, string toallas, string banioPrivado, string descripcion)
        {

            string Lista = CDistribucion.unico(descripcion).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CDistribucion.InsertQuery(camaIndividual.Trim(), camaMatrimonial.Trim(), camaKing.Trim(), maximoPersonas, televisionCable.Trim(), aireAcondicionado.Trim(), ventilador.Trim(), wifi.Trim(), toallas.Trim(), banioPrivado.Trim(), descripcion.Trim());
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




        public static string Actualizar(string camaIndividual, string camaMatrimonial, string camaKing, short maximoPersonas, string televisionCable, string aireAcondicionado, string ventilador, string wifi, string toallas, string banioPrivado, string descripcion, short idDistribucion)
        {

            string mensaje = "";
            int resultado = CDistribucion.UpdateQuery(camaIndividual.Trim(), camaMatrimonial.Trim(), camaKing.Trim(), maximoPersonas, televisionCable.Trim(), aireAcondicionado.Trim(), ventilador.Trim(), wifi.Trim(), toallas.Trim(), banioPrivado.Trim(), descripcion.Trim(), idDistribucion);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idDistribucion)
        {
            string mensaje = "";

            try
            {

                int resultado = CDistribucion.DeleteQuery(idDistribucion);
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
