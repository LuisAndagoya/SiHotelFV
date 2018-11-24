using CapaDatos.Clases.ClienteTableAdapters;
using System;

namespace CapaProceso.Clases
{
    public class Cliente
    {


        private static ClienteTableAdapter CCliente = new ClienteTableAdapter();

        public static CapaDatos.Clases.Cliente.ClienteDataTable Lista()
        {
            return CCliente.GetLista();
        }

      //  public static CapaDatos.Clases.Cliente.ClienteDataTable ListaActualizar(short idCliente)
       // {
         //   return CCliente.GetListaActualizar(idCliente);
        //}


        public static CapaDatos.Clases.Cliente.ClienteDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CCliente.GetBuscar(buscarAux, buscarAux, buscarAux);
        }


       




    }
}
