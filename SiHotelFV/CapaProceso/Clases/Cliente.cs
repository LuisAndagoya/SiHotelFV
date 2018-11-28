using CapaDatos.Clases.ClienteTableAdapters;
using System;

namespace CapaProceso.Clases
{
    public class Cliente
    {


        private static ClienteTableAdapter CCliente = new ClienteTableAdapter();

        public static CapaDatos.Clases.Cliente.ClienteDataTable Lista()
        {
            return CCliente.GetLista();
        }

       public static CapaDatos.Clases.Cliente.ClienteDataTable ListaActualizar(short idCliente)
        {
           return CCliente.GetListaActualizar(idCliente);
        }


        public static CapaDatos.Clases.Cliente.ClienteDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CCliente.GetBuscar(buscarAux, buscarAux, buscarAux);
        }


        public static string Insertar(string CedulaCliente, string NombreCliente, string ApellidoCliente, string DireccionCliente, string Telefono, string Email)
        {

            string Lista = CCliente.unico(CedulaCliente).ToString();


            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = CCliente.InsertQuery(CedulaCliente.Trim(), NombreCliente.Trim().ToUpper(), ApellidoCliente.Trim().ToUpper(), DireccionCliente.Trim(), Telefono.Trim(), Email.Trim());
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




        public static string Actualizar(string CedulaCliente, string NombreCliente, string ApellidoCliente, string DireccionCliente, string Telefono, string Email, short idCliente)
        {

            string mensaje = "";
            int resultado = CCliente.UpdateQuery(CedulaCliente.Trim(), NombreCliente.Trim().ToUpper(), ApellidoCliente.Trim().ToUpper(), DireccionCliente.Trim(), Telefono.Trim(), Email.Trim(), idCliente);
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
