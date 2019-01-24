using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ClienteTableAdapters;

namespace CapaProceso.Clases
{
    public class Cliente
    {

        private static clienteTableAdapter CCliente = new clienteTableAdapter();

        public static CapaDatos.Clases.Cliente.clienteDataTable Lista()
        {
            return CCliente.GetLista();
        }

       /* public static CapaDatos.Clases.Cliente.clienteDataTable Reporte(string Id)
        {
            //return CCliente.Reporte(Id);
        }*/

        public static CapaDatos.Clases.Cliente.clienteDataTable ListaActualizar(short idCliente)
        {
            return CCliente.GetListaActualizar(idCliente);
        }


        public static CapaDatos.Clases.Cliente.clienteDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CCliente.GetBuscar(buscarAux, buscarAux, buscarAux);
        }

        public static CapaDatos.Clases.Cliente.clienteDataTable BuscarCi(string buscar)
        {
           
            return CCliente.GetBuscarCi(buscar.Trim());
        }

        public static string Insertar(string dniCliente, string nombreCliente, string apellidoCliente, string sexoCliente, string direccionCliente, string telefonoCliente, string correoCliente, string estadoCliente)
        {

            string Lista = CCliente.unico(dniCliente).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CCliente.InsertQuery(dniCliente.Trim(), nombreCliente.Trim().ToUpper(), apellidoCliente.Trim().ToUpper(), sexoCliente.Trim(), direccionCliente.Trim(), telefonoCliente.Trim(), correoCliente.Trim(), estadoCliente.Trim());
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




        public static string Actualizar(string dniCliente, string nombreCliente, string apellidoCliente, String sexoCliente, string direccionCliente, string telefonoCliente, string correoCliente, string estadoCliente, short idCliente)
        {

            string mensaje = "";
            int resultado = CCliente.UpdateQuery(dniCliente.Trim(), nombreCliente.Trim().ToUpper(), apellidoCliente.Trim().ToUpper(), sexoCliente.Trim(), direccionCliente.Trim(), telefonoCliente.Trim(), correoCliente.Trim(), estadoCliente.Trim(), idCliente);
            if (resultado == 0)
            {
                return mensaje = "Error al actualizar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Eliminar(short idCliente)
        {
            string mensaje = "";

            try
            {

                int resultado = CCliente.DeleteQuery(idCliente);
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
