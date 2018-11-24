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

        //  public static CapaDatos.Clases.Usuario.usuarioDataTable ListaActualizar(short idEmplado)
        // {
        //   return CUsuario.GetListaActualizar(idEmplado);
        //}


        public static CapaDatos.Clases.Usuario.usuarioDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CUsuario.GetBuscar(buscarAux);
        }


    }
}
