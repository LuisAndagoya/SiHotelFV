using CapaDatos.Clases.UsuarioTableAdapters;
using System;

namespace CapaProceso.Clases
{
    public class Usuario
    {

        private static usuarioTableAdapter CUsuario = new usuarioTableAdapter();

        public static CapaDatos.Clases.Usuario.usuarioDataTable Lista()
        {
            return CUsuario.GetLista();
        }

       

        public static CapaDatos.Clases.Usuario.usuarioDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CUsuario.GetBuscar(buscarAux);
        }


       /* public static int Login(string usernameUsuario, string passwordUsuario)
        {
            int Respuesta;

            return Respuesta = int.Parse(CUsuario.Login(usernameUsuario.Trim(), passwordUsuario.Trim()).ToString());
        }
        */

        /*public static CapaDatos.Clases.Usuario.usuarioDataTable VaribleSecion(string Login)
        {
            return CUsuario.VariablesSecion(Login.Trim());
        }*/

        public static CapaDatos.Clases.Usuario.usuarioDataTable ListaActualizarUsuario(short Id)
        {
            return CUsuario.GetListaActualizar(Id);
        }

      

        public static string Eliminar(short Id)
        {
            string mensaje = "";

            try
            {

                int resultado = CUsuario.DeleteQuery(Id);

                return mensaje;

            }
            catch
            {
                return mensaje = "No se puede eliminar existen resistros asociados";
            }


        }


        public static string Actualizar(string usernameUsuario, string passwordUsuario, string estadoUsuario, short idCargo, short idEmplado)
        {
            string mensaje = "";
            int resultado = CUsuario.UpdateQuery(usernameUsuario.Trim(), passwordUsuario.Trim(), estadoUsuario.Trim(), idCargo, idEmplado);
            if (resultado == 0)
            {
                return mensaje = "Error al insertar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static string Insertar(string usernameUsuario, string passwordUsuario, string estadoUsuario, short idCargo)
        {
            string Lista = CUsuario.unico(usernameUsuario.Trim()).ToString();

            string mensaje = "";

            if (Lista == "0")
            {
                int resultado = 0;//CUsuario.InsertQuery(usernameUsuario.Trim(), passwordUsuario.Trim(), estadoUsuario.Trim(), idCargo,);
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
                return mensaje = "El registro ya existe";
            }


        }

    }
}
