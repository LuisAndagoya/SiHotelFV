using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.HotelTableAdapters;

namespace CapaProceso.Clases
{
    public class Hotel
    {

        private static hotelTableAdapter CHotel = new hotelTableAdapter();

        public static CapaDatos.Clases.Hotel.hotelDataTable Lista()
        {
            return CHotel.GetLista();
        }

        public static CapaDatos.Clases.Hotel.hotelDataTable ListaActualizar(string codHotel)
        {
            return CHotel.GetListaActualizar(codHotel);
        }


        public static CapaDatos.Clases.Hotel.hotelDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CHotel.GetBuscar(buscarAux);
        }

        public static string Insertar(string codHotel, string nombreHotel, short numeroHabitaciones, string categoriaHotel, string ciudadHotel, string direccionHotel, string telefonoHotel, string correoHotel, string descipcionHotel)
        {

            string Lista = CHotel.unico(nombreHotel, codHotel).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CHotel.InsertQuery(codHotel, nombreHotel.Trim().ToUpper(), numeroHabitaciones,categoriaHotel.Trim().ToUpper(), ciudadHotel.Trim().ToUpper(), direccionHotel.Trim().ToUpper(), telefonoHotel.Trim(), correoHotel.Trim(), descipcionHotel.Trim());
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




        public static string Actualizar(string codHotel, string nombreHotel, short numeroHabitaciones, string categoriaHotel, string ciudadHotel, string direccionHotel, string telefonoHotel, string correoHotel, string descipcionHotel)
        {

            string mensaje = "";
            int resultado = CHotel.UpdateQuery(codHotel, nombreHotel.Trim().ToUpper(), numeroHabitaciones, categoriaHotel.Trim().ToUpper(), ciudadHotel.Trim().ToUpper(), direccionHotel.Trim().ToUpper(), telefonoHotel.Trim(), correoHotel.Trim(), descipcionHotel.Trim());
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(string codHotel)
        {
            string mensaje = "";

            try
            {

                int resultado = CHotel.DeleteQuery(codHotel);
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
