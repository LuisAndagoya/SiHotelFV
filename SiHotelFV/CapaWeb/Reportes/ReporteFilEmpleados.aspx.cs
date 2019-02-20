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
    public partial class ReporteFilEmpleados : System.Web.UI.Page
    {
        private static Codificar codificar = new Codificar(); // Clase para emcriptar
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (!CapaProceso.Clases.Menucargo.ExisteMenu("Reporte Empleado", int.Parse(Session["idCargo"].ToString())))
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
            ListaEmpleado.DataSource = CapaProceso.Clases.Cargo.Lista();
                ListaEmpleado.DataTextField = "nombreCargo";
                ListaEmpleado.DataValueField = "idCargo";
                ListaEmpleado.DataBind();
            
        }
        protected void bloquear()
        {
            ListaEmpleado.Enabled = false;
            TextBox1.Enabled = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string Id = ListaEmpleado.SelectedValue.ToString();
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("idCargo", Id);
            this.ReportViewer1.LocalReport.SetParameters(parametros);

            this.ReportViewer1.LocalReport.Refresh();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string Id = fechInicio.Text;
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();

            //2 voy a agregando los valores que deseo
            qs.Add("TRN", "INS");
            qs.Add("Id", Id);
            Response.Redirect("EmpleadoFecha.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());

        }
    }
}