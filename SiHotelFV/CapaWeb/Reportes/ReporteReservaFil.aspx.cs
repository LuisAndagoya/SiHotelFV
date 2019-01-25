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
    public partial class ReporteReservaFil : System.Web.UI.Page
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
            ListaUsuario.DataSource = CapaProceso.Clases.Usuario.Lista();
            ListaUsuario.DataTextField = "usernameUsuario";
            ListaUsuario.DataValueField = "idUsuario";
            ListaUsuario.DataBind();

            ListaEstado.DataSource = CapaProceso.Clases.EstadoReserva.Lista();
            ListaEstado.DataTextField = "nombreEstado";
            ListaEstado.DataValueField = "idEstadoReserva";
            ListaEstado.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           string Fecha = fechEntrada.Text;
            
            ReportParameter[] parametros = new ReportParameter[1];
            
            parametros[0] = new ReportParameter("Fecha", Fecha);
           
            this.ReportViewer1.LocalReport.SetParameters(parametros);

            this.ReportViewer1.LocalReport.Refresh();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string Id = ListaUsuario.SelectedValue.ToString();
            //1 primero creo un objeto Clave/Valor de QueryString 
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();

            //2 voy a agregando los valores que deseo
            qs.Add("TRN", "INS");
            qs.Add("Id", Id.ToString());
            Response.Redirect("ReservaUsuario.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string Id = ListaEstado.SelectedValue.ToString();
            //1 primero creo un objeto Clave/Valor de QueryString 
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();

            //2 voy a agregando los valores que deseo
            qs.Add("TRN", "INS");
            qs.Add("Id", Id.ToString());
            Response.Redirect("ReservaEstado.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            string Id = Cliente.Text;
            //1 primero creo un objeto Clave/Valor de QueryString 
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();

            //2 voy a agregando los valores que deseo
            qs.Add("TRN", "INS");
            qs.Add("Id", Id.ToString());
            Response.Redirect("ReservaCliente.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());

        }
    }
}