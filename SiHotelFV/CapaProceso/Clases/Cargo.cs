using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.CargoTableAdapters;

namespace CapaProceso.Clases
{
    public  class Cargo
    {
        private static cargoTableAdapter CCargo = new cargoTableAdapter();

        public static CapaDatos.Clases.Cargo.cargoDataTable Lista()
        {
            return CCargo.GetLista();
        }

        public static CapaDatos.Clases.Cargo.cargoDataTable ListaActualizar(short idCargo)
        {
            return CCargo.GetListaActualizar(idCargo);
        }


        public static CapaDatos.Clases.Cargo.cargoDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CCargo.GetBuscar(buscarAux);
        }

        public static string Insertar(string nombreCargo)
        {

            string Lista = CCargo.unico(nombreCargo).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CCargo.InsertQuery(nombreCargo.Trim().ToUpper());
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




        public static string Actualizar(string nombreCargo,  short idCargo)
        {
            
            string mensaje = "";
            int resultado = CCargo.UpdateQuery(nombreCargo.Trim(), idCargo);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idCargo)
        {
            string mensaje = "";

            try
            {

                int resultado = CCargo.DeleteQuery(idCargo);
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
