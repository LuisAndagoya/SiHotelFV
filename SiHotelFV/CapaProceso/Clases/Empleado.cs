using CapaDatos.Clases.EmpleadoTableAdapters;
using System;

namespace CapaProceso.Clases
{
   public class Empleado
    {
        private static empleadoTableAdapter CEmpleado = new empleadoTableAdapter();

        public static CapaDatos.Clases.Empleado.empleadoDataTable Lista()
        {
            return CEmpleado.GetLista();
        }

        public static CapaDatos.Clases.Empleado.empleadoDataTable ListaActualizar(short idEmpleado)
        {
            return CEmpleado.GetListaActualizar(idEmpleado);
        }


        public static CapaDatos.Clases.Empleado.empleadoDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CEmpleado.GetBuscar(buscarAux, buscarAux, buscarAux);
        }


        public static string Insertar(string dniEmpleado, string nombreEmpleado, string apellidoEmpleado, String fnacimientoEmpleado, string sexoEmpleado, string estadocivilEmpleado, string domicilioEmpleado, string telefmovilEmpleado, string emailEmpleado, String fecharegistroEmpleado)
        {

           string Lista = CEmpleado.unico(dniEmpleado).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CEmpleado.InsertQuery(dniEmpleado.Trim(), nombreEmpleado.Trim().ToUpper(), apellidoEmpleado.Trim().ToUpper(), fnacimientoEmpleado, sexoEmpleado.Trim(), estadocivilEmpleado.Trim(), domicilioEmpleado.Trim().ToUpper(), telefmovilEmpleado.Trim(), fecharegistroEmpleado.Trim(), emailEmpleado.Trim());
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


      

    public static string Actualizar(string dniEmpleado, string nombreEmpleado, string apellidoEmpleado, string fnacimientoEmpleado, string sexoEmpleado, string estadocivilEmpleado, string domicilioEmpleado, string telefmovilEmpleado, string emailEmpleado, short idEmpleado, String fecharegistroEmpleado)
    {
       
        string mensaje = "";
        int resultado = CEmpleado.UpdateQuery(dniEmpleado.Trim(), nombreEmpleado.Trim().ToUpper(), apellidoEmpleado.Trim().ToUpper(), fnacimientoEmpleado, sexoEmpleado.Trim(), estadocivilEmpleado.Trim(), domicilioEmpleado.Trim(), telefmovilEmpleado.Trim(), fecharegistroEmpleado, emailEmpleado.Trim(), idEmpleado);
        if (resultado == 0)
        {
            return mensaje = "Error al actualizar los registros";
        }
        else
        {
            return mensaje = "";
        }
    }

        public static string Eliminar(short idEmpleado)
        {
            string mensaje = "";

            try
            {

                int resultado = CEmpleado.DeleteQuery(idEmpleado);
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
