using CapaDatos.Clases.MenuTableAdapters;
using System;

namespace CapaProceso.Clases
{
    public class Menu
    {
        private static menuTableAdapter CMenu = new menuTableAdapter();

        public static CapaDatos.Clases.Menu.menuDataTable Lista()
        {
            return CMenu.GetLista();
        }

        //  public static CapaDatos.Clases.Cliente.ClienteDataTable ListaActualizar(short idCliente)
        // {
        //   return CCliente.GetListaActualizar(idCliente);
        //}


        public static CapaDatos.Clases.Menu.menuDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CMenu.GetBuscar(buscarAux);
        }


    }
}
