using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaProceso.Clases;
using Microsoft.Reporting.WebForms;

namespace CapaWeb.Reportes
{
    public partial class ReporteFilHabitacion : System.Web.UI.Page
    {
        private static Codificar codificar = new Codificar(); // Clase para emcriptar
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                CargarCombo();
                this.ReportViewer1.LocalReport.Refresh();
            }
        }

        protected void CargarCombo()
        {

            //Llenar un combo box dinamicamente con tabla adapter
            ListaHabitacion.DataSource = CapaProceso.Clases.Habitacion.Lista();
            ListaHabitacion.DataTextField = "numeroHabitacion";
            ListaHabitacion.DataValueField = "numeroHabitacion";
            ListaHabitacion.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {


            string Id = ListaHabitacion.SelectedValue.ToString();
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("numeroHabitacion", Id);
            this.ReportViewer1.LocalReport.SetParameters(parametros);
            this.ReportViewer1.LocalReport.Refresh();
        }

    }

}