using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.MenuCargoTableAdapters;

namespace CapaProceso.Clases
{
    public class MenuCargo
    {


        private static menu_cargoTableAdapter CMenuCargo = new menu_cargoTableAdapter();

        public static CapaDatos.Clases.MenuCargo.menu_cargoDataTable Lista()
        {
            return CMenuCargo.GetLista();
        }

        //public static CapaDatos.Clases.MenuCargo.menu_cargoDataTable ListaActualizar(short idMenu_Cargo)
        //{
          //return CMenuCargo.GetListaActualizar(idMenu_Cargo);
        //}


       public static CapaDatos.Clases.MenuCargo.menu_cargoDataTable Buscar(string buscar)
        {
          String buscarAux = "%" + buscar.Trim() + "%";
            return CMenuCargo.GetBuscar(buscarAux);
        }
    }
}
