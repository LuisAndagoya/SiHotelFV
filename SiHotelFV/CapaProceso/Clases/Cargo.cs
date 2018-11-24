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

        //public static CapaDatos.Clases.Cargo.cargoDataTable ListaActualizar(short idCargo)
        //{
          //  return CCargo.GetListaActualizar(idCargo);
        //}


        public static CapaDatos.Clases.Cargo.cargoDataTable Buscar(string buscar)
        {
            String buscarAux = "%" + buscar.Trim() + "%";
            return CCargo.GetBuscar(buscarAux);
        }

    }
}
