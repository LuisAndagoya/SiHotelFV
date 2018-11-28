using CapaDatos.Clases.MenucargoTableAdapters;
using System;

namespace CapaProceso.Clases
{
    public class Menucargo
    {

        private static menu_cargoTableAdapter CMenucargo = new menu_cargoTableAdapter();

        public static CapaDatos.Clases.Menucargo.menu_cargoDataTable Lista()
        {
            return CMenucargo.GetLista();
        }

        //  public static CapaDatos.Clases.Cliente.ClienteDataTable ListaActualizar(short idCliente)
        // {
        //   return CCliente.GetListaActualizar(idCliente);
        //}


        public static CapaDatos.Clases.Menucargo.menu_cargoDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CMenucargo.GetBuscar(buscarAux);
        }

    }
}
