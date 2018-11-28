using CapaDatos.Clases.SubmenuTableAdapters;
using System;

namespace CapaProceso.Clases
{
   public  class Submenu
    {

        private static submenuTableAdapter CSubmenu = new submenuTableAdapter();

        public static CapaDatos.Clases.Submenu.submenuDataTable Lista()
        {
            return CSubmenu.GetLista();
        }

        //  public static CapaDatos.Clases.Cliente.ClienteDataTable ListaActualizar(short idCliente)
        // {
        //   return CCliente.GetListaActualizar(idCliente);
        //}


        public static CapaDatos.Clases.Submenu.submenuDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CSubmenu.GetBuscar(buscarAux);
        }

    }
}
