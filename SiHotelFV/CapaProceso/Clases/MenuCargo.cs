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

         public static CapaDatos.Clases.Menucargo.menu_cargoDataTable ListaActualizar(short idMenu_Cargo)
         {
          return CMenucargo.GetListaActualizar(idMenu_Cargo);
        }


        public static CapaDatos.Clases.Menucargo.menu_cargoDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CMenucargo.GetBuscar(buscarAux);
        }

        public static CapaDatos.Clases.Menucargo.menu_cargoDataTable ListaCargo()
        {
            return CMenucargo.GetListaCargo();
        }


        public static CapaDatos.Clases.Menucargo.menu_cargoDataTable ListaSubmenu()
        {
            return CMenucargo.GetListaSubmenu();
        }

        public static Boolean ExisteMenu(string nombreSubMenu, int idCargo)
        {
            Boolean Existe = false;
            int contar = 0;
            contar = (int) CMenucargo.ExisteMenu(nombreSubMenu, idCargo);
            if (contar > 0)
            {
                Existe = true;
            }
            return Existe;
        }


        public static string Insertar(short idCargo, short idSubMenu)
        {

          string Lista = CMenucargo.unico(idCargo, idSubMenu).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CMenucargo.InsertQuery(idCargo, idSubMenu);
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




        public static string Actualizar(short idCargo, short idSubMenu, short idMenu_Cargo)
        {

            string mensaje = "";
            int resultado = CMenucargo.UpdateQuery(idCargo, idSubMenu, idMenu_Cargo);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idMenu_Cargo)
        {
            string mensaje = "";

            try
            {

                int resultado = CMenucargo.DeleteQuery(idMenu_Cargo);
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
