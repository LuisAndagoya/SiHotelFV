﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.ReporteEmpleadoTableAdapters;

namespace CapaProceso.Clases
{
   public class ReporteEmpleado
    {
        private static empleadoTableAdapter CReporte = new empleadoTableAdapter();

        public static CapaDatos.Clases.ReporteEmpleado.empleadoDataTable Reporte(short Id)
        {
            return CReporte.Reporte(Id);
        }
    }
}