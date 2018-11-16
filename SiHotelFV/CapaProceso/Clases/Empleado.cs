using CapaDatos.Clases.EmpleadoTableAdapters;

namespace CapaProceso.Clases
{
   public class Empleado
    {
        private static empleadoTableAdapter CEmpleado = new empleadoTableAdapter();

        public static CapaDatos.Clases.Empleado.empleadoDataTable Lista()
        {
            return CEmpleado.GetLista();
        }

    }
}
