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

        public void reporte()
        {
             
          
            CargarCombo();
        }
    }
}