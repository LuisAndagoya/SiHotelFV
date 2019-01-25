using CapaDatos.Clases.UsuarioTableAdapters;
using System;


namespace CapaProceso.Clases
{
    public class Usuario
    {
        private static Codificar codificar = new Codificar();
        private static usuarioTableAdapter CUsuario = new usuarioTableAdapter();

        public static CapaDatos.Clases.Usuario.usuarioDataTable Lista()
        {
            return CUsuario.GetLista();
        }

        public static CapaDatos.Clases.Usuario.usuarioDataTable ListaRecuperar(string usernameUsuario)
        {
            
            return CUsuario.GetListaRecuperar(usernameUsuario.Trim());
        }

        public static CapaDatos.Clases.Usuario.usuarioDataTable ListaContrasenia(int idUsuario)
        {

            return CUsuario.GetListaContrasenia(idUsuario);
        }

        public static CapaDatos.Clases.Usuario.usuarioDataTable Empleado(short idUsuario)
        {
            return CUsuario.GetEmpleado(idUsuario);
        }



        public static CapaDatos.Clases.Usuario.usuarioDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CUsuario.GetBuscar(buscarAux);
        }


        public static int Login(string usernameUsuario, string passwordUsuario)
        {
            int Respuesta;
            string contraseniaEncriptada = codificar.Base64Encode(passwordUsuario);

            return Respuesta = int.Parse(CUsuario.Login(usernameUsuario.Trim(), contraseniaEncriptada).ToString());
        }

      

        public static CapaDatos.Clases.Usuario.usuarioDataTable DatosUsuario(string Login)
        {
            return CUsuario.GetListaUsuario(Login.Trim());
        }

        public static CapaDatos.Clases.Usuario.usuarioDataTable ListaActualizar(short idUsuario)
        {
            return CUsuario.GetListaActualizar(idUsuario);
        }

        

        public static string Eliminar(short idUsuario)
        {
            string mensaje = "";

            try
            {

                int resultado = CUsuario.DeleteQuery(idUsuario);

                return mensaje;

            }
            catch
            {
                return mensaje = "No se puede eliminar existen resistros asociados";
            }


        }


        public static string Actualizar( string usernameUsuario, string passwordUsuario, string estadoUsuario, short idEmpleado, short idCargo, short idUsuario)
        {
            string mensaje = "";
            string contraseniaEncriptada = codificar.Base64Encode(passwordUsuario);
            int resultado = CUsuario.UpdateQuery( usernameUsuario.Trim(), contraseniaEncriptada, estadoUsuario.Trim(),idEmpleado, idCargo, idUsuario);
            if (resultado == 0)
            {
                return mensaje = "Error al insertar los registros";
            }
            else
            {
                return mensaje = "";
            }
        }

        public static int ActualizarContrasenia(short idUsuario, string passwordUsuario)
        {
            string contraseniaEncriptada = codificar.Base64Encode(passwordUsuario);
            CUsuario.ActualizarContrasenia(contraseniaEncriptada, idUsuario);
            return 1;
        }
            

        public static string Insertar( string usernameUsuario, string passwordUsuario, string estadoUsuario, short idEmpleado, short idCargo)
        {
            string Lista = CUsuario.unico(usernameUsuario.Trim(),idEmpleado).ToString();
           string Empleado = CUsuario.Empleado(idEmpleado).ToString();
            string mensaje = "";
            if (Empleado == "0")
            {

                if (Lista == "0")
                {
                    string contraseniaEncriptada = codificar.Base64Encode(passwordUsuario);

                    int resultado = CUsuario.InsertQuery(usernameUsuario.Trim(), contraseniaEncriptada, estadoUsuario.Trim(), idEmpleado, idCargo);
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
                    return mensaje = "El usuario ya se encuentra registrado";
                }
            }
            else
            {
                return mensaje = "Empleado ya posee usuario";
            }

        }

    }
}
