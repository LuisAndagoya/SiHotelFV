using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.TipohabitacionTableAdapters;

namespace CapaProceso.Clases
{
    public class TipoHabitacion
    {
        private static tipo_habitacionTableAdapter CTipo = new tipo_habitacionTableAdapter();

        public static CapaDatos.Clases.Tipohabitacion.tipo_habitacionDataTable Lista()
        {
            return CTipo.GetLista();
        }

        public static CapaDatos.Clases.Tipohabitacion.tipo_habitacionDataTable ListaActualizar(short idtipo)
        {
            return CTipo.GetListaActualizar(idtipo);
        }


        public static CapaDatos.Clases.Tipohabitacion.tipo_habitacionDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CTipo.GetBuscar(buscarAux);
        }

        public static CapaDatos.Clases.Tipohabitacion.tipo_habitacionDataTable ListaDistribucion()
        {
            return CTipo.GetListaDistribucion();
        }


        public static CapaDatos.Clases.Tipohabitacion.tipo_habitacionDataTable ListaPrecio()
        {
            return CTipo.GetListaPrecio();
        }




        public static string Insertar(string nombreTipo, short precioHabitacion_idPrecio, short distribucionHabitacion_idDistribucion)
        {

            // string Lista = CMenucargo.unico(idCargo, idSubMenu);


            string mensaje = "";

            // if (Lista == "0")
            // {
            int resultado = CTipo.InsertQuery(nombreTipo.Trim().ToUpper(),precioHabitacion_idPrecio, distribucionHabitacion_idDistribucion);
            if (resultado == 0)
            {
                return mensaje = "Error al insertar los registros";
            }
            else
            {
                return mensaje = "";
            }

            /* }
             else
             {
                 return mensaje = "La CI ya existe";
             }*/
        }




        public static string Actualizar(string nombreTipo, short precioHabitacion_idPrecio, short distribucionHabitacion_idDistribucion, short idtipo)
        {

            string mensaje = "";
            int resultado = CTipo.UpdateQuery(nombreTipo.Trim().ToUpper(), precioHabitacion_idPrecio, distribucionHabitacion_idDistribucion, idtipo);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idtipo)
        {
            string mensaje = "";

            try
            {

                int resultado = CTipo.DeleteQuery(idtipo);
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
