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
                if (!CapaProceso.Clases.Menucargo.ExisteMenu("Reporte Habitación", int.Parse(Session["idCargo"].ToString())))
                {
                    Response.Redirect("../../Index.aspx");
                }

                CargarCombo();
                this.ReportViewer1.LocalReport.Refresh();
            }
        }

        protected void CargarCombo()
        {

            //Llenar un combo box dinamicamente con tabla adapter
            ListaHabitacion.DataSource = CapaProceso.Clases.TipoHabitacion.Lista();
            ListaHabitacion.DataTextField = "nombreTipo";
            ListaHabitacion.DataValueField = "idtipo";
            ListaHabitacion.DataBind();

            ListaEstado.DataSource = CapaProceso.Clases.EstadoHabitacion.Lista();
            ListaEstado.DataTextField = "nombreEstadoHabitacion";
            ListaEstado.DataValueField = "idEstadoHabitacion";
            ListaEstado.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string Id = ListaEstado.SelectedValue.ToString();
            //Response.Redirect("EstadoHabitacion.aspx" + Id);

            //1 primero creo un objeto Clave/Valor de QueryString 
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();

            //2 voy a agregando los valores que deseo
            qs.Add("TRN", "INS");
            qs.Add("Id", Id.ToString());
            Response.Redirect("EstadoHabitacion.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());

           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string Id = ListaHabitacion.SelectedValue.ToString();
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("idtipo", Id);
            this.ReportViewer1.LocalReport.SetParameters(parametros);
            this.ReportViewer1.LocalReport.Refresh();

        }
    }

}