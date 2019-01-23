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
    public partial class ClienteReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                
                this.ReportViewer1.LocalReport.Refresh();
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            string Id = estadoCliente.SelectedValue.ToString();
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("estadoCliente", Id);
            this.ReportViewer1.LocalReport.SetParameters(parametros);

            this.ReportViewer1.LocalReport.Refresh();


        }
    }
}