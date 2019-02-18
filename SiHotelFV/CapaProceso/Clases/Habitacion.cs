using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.HabitacionTableAdapters;

namespace CapaProceso.Clases
{
   public  class Habitacion
    {

        private static habitacionTableAdapter CHabitacion = new habitacionTableAdapter();

        public static CapaDatos.Clases.Habitacion.habitacionDataTable Lista()
        {
            return CHabitacion.GetLista();
        }

        public static List<ModeloReservacionDetalle> ListaHabitacionesDisponibles(string fechaReservacion)
        {
           
           
           
            CapaDatos.Clases.Habitacion.habitacionDataTable lista;
            CapaDatos.Clases.Habitacion.habitacionDataTable lista2;
            List<ModeloReservacionDetalle> modeloReservacionDetalle;
            modeloReservacionDetalle = new List<ModeloReservacionDetalle>();

            lista = CHabitacion.GetHabitacion(fechaReservacion);
            lista2 = CHabitacion.NumeroHabitacion(4);
            foreach (var item2 in lista2)
            {
                int contador = 0;
                foreach (var item in lista)
                {
                    if (item2.numeroHabitacion == item.numeroHabitacion)
                    {
                        contador++;
                    }                    

                }
                if (contador < 1)
                {
                    ModeloReservacionDetalle itemH = new ModeloReservacionDetalle(item2.numeroHabitacion, 0, "");
                    modeloReservacionDetalle.Add(itemH);

                }
            }
            return modeloReservacionDetalle;

        }

        public static CapaDatos.Clases.Habitacion.habitacionDataTable ListaEstado( short estadoHabitacion_idEstado)
        {
            return CHabitacion.ListaEstado(estadoHabitacion_idEstado);
        }


        public static CapaDatos.Clases.Habitacion.habitacionDataTable ListaActualizar(short numeroHabitacion)
        {
            return CHabitacion.GetListaActualizar(numeroHabitacion);
            
        }

        public static CapaDatos.Clases.Habitacion.habitacionDataTable ListaDetalle(short numeroHabitacion)
        {
            return CHabitacion.GetListaDetalle(numeroHabitacion);
        }


        public static CapaDatos.Clases.Habitacion.habitacionDataTable Buscar(short buscar)
        {
            //short Id = short.Parse(qs["Id"].ToString());
            //short buscarAux = "%" + buscar.Trim() + "%";
            return CHabitacion.GetBuscar(buscar);
        }

        public static CapaDatos.Clases.Habitacion.habitacionDataTable BuscarPrecio(short buscar)
        {
            
            return CHabitacion.GetPrecioHabitacion(buscar);
        }


        public static string Insertar(short numeroHabitacion, short tipoHabitacion_Idtipo, string hotel_CodigoHotel, short estadoHabitacion_idEstado)
        {

            string Lista = CHabitacion.unico(numeroHabitacion).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CHabitacion.InsertQuery(numeroHabitacion, tipoHabitacion_Idtipo, hotel_CodigoHotel, estadoHabitacion_idEstado);
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




        public static string Actualizar(short numeroHabitacion, short tipoHabitacion_Idtipo, string hotel_CodigoHotel, short estadoHabitacion_idEstado)
        {

            string mensaje = "";
            int resultado = CHabitacion.UpdateQuery(numeroHabitacion, tipoHabitacion_Idtipo, hotel_CodigoHotel, estadoHabitacion_idEstado);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string ActualizarEstado(short numeroHabitacion, short estadoHabitacion_idEstado)
        {

            string mensaje = "";
            int resultado = CHabitacion.ActualizarHestado(estadoHabitacion_idEstado, numeroHabitacion);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short numeroHabitacion)
        {
            string mensaje = "";

            try
            {

                int resultado = CHabitacion.DeleteQuery(numeroHabitacion);
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
