﻿using System;
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


       /* public static CapaDatos.Clases.Distribucionhabitacion.distribucion_habitacionDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CDistribucion.GetBuscar(buscarAux);
        }*/

        public static string Insertar(short camaIndividual, short camaMatrimonial, short camaKing, short maximoPersonas, string televisionCable, string aireAcondicionado, string ventilador, string wifi, string toallas, string banioPrivado)
        {

            //string Lista = CCargo.unico(nombreCargo).ToString();


            string mensaje = "";

            //if (Lista == "0")
           // {
                int resultado = CDistribucion.InsertQuery(camaIndividual, camaMatrimonial, camaKing, maximoPersonas, televisionCable.Trim(), aireAcondicionado.Trim(), ventilador.Trim(), wifi.Trim(), toallas.Trim(), banioPrivado.Trim());
                if (resultado == 0)
                {
                    return mensaje = "Error al insertar los registros";
                }
                else
                {
                    return mensaje = "";

                }

            //}
            //else
            //{
              //  return mensaje = "La CI ya existe";
            //}
        }




        public static string Actualizar(short camaIndividual, short camaMatrimonial, short camaKing, short maximoPersonas, string televisionCable, string aireAcondicionado, string ventilador, string wifi, string toallas, string banioPrivado,short idDistribucion)
        {

            string mensaje = "";
            int resultado = CDistribucion.UpdateQuery(camaIndividual, camaMatrimonial, camaKing, maximoPersonas, televisionCable.Trim(), aireAcondicionado.Trim(), ventilador.Trim(), wifi.Trim(), toallas.Trim(), banioPrivado.Trim(), idDistribucion);
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
