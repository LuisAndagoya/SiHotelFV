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

        public static CapaDatos.Clases.Submenu.submenuDataTable SubmenuAsigando(short idCargo, short idMenu )
        {
            return CSubmenu.GetSubmenuAsiganado(idMenu, idCargo);
        }

        public static CapaDatos.Clases.Submenu.submenuDataTable ListaActualizar(short idSubMenu)
         {
          return CSubmenu.GetListaActualizar(idSubMenu);
       }


        public static CapaDatos.Clases.Submenu.submenuDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CSubmenu.GetBuscar(buscarAux);
        }



     


        public static CapaDatos.Clases.Submenu.submenuDataTable ListaMenu()
        {
            return CSubmenu.GetListaMenu();
        }




        public static string Insertar(short idMenu, string nombreSubMenu, string urlSubMenu, string iconoSubMenu)
        {

            string Lista = CSubmenu.unico(nombreSubMenu).ToString();


            string mensaje = "";

             if (Lista == "0")
             {
            int resultado = CSubmenu.InsertQuery(idMenu, nombreSubMenu.Trim(), urlSubMenu.Trim(), iconoSubMenu.Trim());
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




        public static string Actualizar(short idMenu, string nombreSubMenu, string urlSubMenu, string iconoSubMenu,short idSubMenu)
        {

            string mensaje = "";
            int resultado = CSubmenu.UpdateQuery(idMenu, nombreSubMenu.Trim(), urlSubMenu.Trim(), iconoSubMenu.Trim(), idSubMenu);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idSubMenu)
        {
            string mensaje = "";

            try
            {

                int resultado = CSubmenu.DeleteQuery(idSubMenu);
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
