using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.MenuTableAdapters;

namespace CapaProceso.Clases
{
    public class Menu
    {

        private static menuTableAdapter CMenu = new menuTableAdapter();

        public static CapaDatos.Clases.Menu.menuDataTable Lista()
        {
            return CMenu.GetLista();
        }

        public static CapaDatos.Clases.Menu.menuDataTable ListaActualizar(short idMenu)
        {
            return CMenu.GetListaActualizar(idMenu);
        }


        public static CapaDatos.Clases.Menu.menuDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CMenu.GetBuscar(buscarAux);
        }

        public static string Insertar(string nombreMenu, string urlMenu, string iconoMenu)
        {

            string Lista = CMenu.unico(nombreMenu).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CMenu.InsertQuery(nombreMenu.Trim(), urlMenu.Trim(), iconoMenu.Trim());
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




        public static string Actualizar(string nombreMenu,string urlMenu,  string iconoMenu, short idMenu)
        {

            string mensaje = "";
            int resultado = CMenu.UpdateQuery(nombreMenu.Trim(),urlMenu.Trim(), iconoMenu.Trim(), idMenu);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idMenu)
        {
            string mensaje = "";

            try
            {

                int resultado = CMenu.DeleteQuery(idMenu);
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
