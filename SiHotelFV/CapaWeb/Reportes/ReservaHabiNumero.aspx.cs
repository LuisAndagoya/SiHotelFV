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
    public partial class ReservaHabiNumero : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {

            string Id = ListaHabitacion.SelectedValue.ToString();
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();

            //2 voy a agregando los valores que deseo
            qs.Add("TRN", "INS");
            qs.Add("Id", Id.ToString());
            Response.Redirect("ReservacionFechaH.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString()); ;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string Inicio = fechaDesde.Text;
            string Fin = fechaHasta.Text;
            ReportParameter[] parametros = new ReportParameter[2];
            //ObjectDataSource1.SelectParameters.Add("Id", Inicio, "Fin", Fin);
            parametros[0] = new ReportParameter("Inicio", Inicio);
            parametros[1] = new ReportParameter("Fin", Fin);
            this.ReportViewer1.LocalReport.SetParameters(parametros);

            this.ReportViewer1.LocalReport.Refresh();


        }

    }
}