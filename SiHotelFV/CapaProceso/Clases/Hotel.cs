using CapaDatos.Clases.HotelTableAdapters;
using System;


namespace CapaProceso.Clases
{
    public class Hotel
    {

        private static HotelTableAdapter CHotel = new HotelTableAdapter();

        public static CapaDatos.Clases.Hotel.HotelDataTable Lista()
        {
            return CHotel.GetLista();
        }

        //  public static CapaDatos.Clases.Cliente.ClienteDataTable ListaActualizar(short idCliente)
        // {
        //   return CCliente.GetListaActualizar(idCliente);
        //}


        public static CapaDatos.Clases.Hotel.HotelDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CHotel.GetBuscar(buscarAux, buscarAux, buscarAux);
        }




    }
}
