using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CapaWeb.Formularios.Distribucion
{
    public partial class Container : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request.QueryString["TRN"])
            {

                case "INS":
                   


                    break;

                case "UDP":
                   

                    LlenarFormulario();

                    break;

                case "DLT":
                   

                    LlenarFormulario();
                    BloquerFormulario();
                    break;
            }

        }

       
        protected void LlenarFormulario()
        {
            if (!IsPostBack)
            {

                short Id = short.Parse(Request.QueryString["Id"]);
                
                //Carga datos para actualizacion           
                CapaDatos.Clases.Distribucionhabitacion.distribucion_habitacionDataTable distribucion_habitacionDataTable = CapaProceso.Clases.DistribucionHabitacion.ListaActualizar(Id);

                foreach (DataRow row in distribucion_habitacionDataTable.Rows)
                {
                    //camaIndividual.Checked = true;

                   // camaIndividual.Text = row["camaIndividual"].ToString();
                     
                    /* television.SelectedValue = row["televisionCable"].ToString();
                     aire.SelectedValue = row["aireAcondicionado"].ToString();
                     ventilador1.SelectedValue = row["ventilador"].ToString();
                     wifi1.SelectedValue = row["wifi"].ToString();
                     toallas1.SelectedValue = row["toallas"].ToString();
                     banio1.SelectedValue = row["banioPrivado"].ToString();*/
                    maximoPersonas.Text = row["maximoPersonas"].ToString();
                    descripcion.Text = row["descripcion"].ToString();
                    lblId.Text = row["idDistribucion"].ToString();
                }
            }
        }





        protected void BloquerFormulario()
        {

            camaIndividual.Enabled = false;
            camaMatrimonial.Enabled = false;
            camaKing.Enabled = false;
            maximoPersonas.Enabled = false;
            television.Enabled = false;
            aire.Enabled = false;
            ventilador1.Enabled = false;
            wifi1.Enabled = false;
            toallas1.Enabled = false;
            banio1.Enabled = false;
            LblErro.Text = "Confirme la eliminación de los datos";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string error = "";
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            short Maximo = short.Parse(maximoPersonas.Text);

            string individual = camaIndividual.Checked.ToString();
            if (individual == "True")
            {
                individual = "S";
            }
             else  { individual = "N"; }

            string matrimonial = camaMatrimonial.Checked.ToString();
            if (matrimonial == "True")
            { matrimonial = "S"; }
            else { matrimonial = "N"; }

            string king = camaKing.Checked.ToString();
            if (king == "True") { king = "S"; }
            else { king = "N"; }

            string tv = television.Checked.ToString();
            if (tv == "true") { tv = "S"; }
            else { tv = "N"; }


            string acondicionado = aire.Checked.ToString();
            if (acondicionado == "True") { acondicionado = "S"; }
            else { acondicionado = "N"; }


            string vent = ventilador1.Checked.ToString();
            if (vent == "True") { vent = "S"; }
            else { vent = "N"; }

            string wf = wifi1.Checked.ToString();
            if( wf == "True")
            { wf = "S"; }
            else { wf = "N"; }

            string to = toallas1.Checked.ToString();
            if (to == "True") { to = "S"; }
            else { to = "N"; }


            string privado = banio1.Checked.ToString();
            if (privado == "True") { privado = "S"; }
            else { privado = "N"; }


            switch (Request.QueryString["TRN"]) //ultilizo la variable para la opcion
            {

                case "INS": //ejecuta el codigo si el usuario ingresa el numero 1
                    error = CapaProceso.Clases.DistribucionHabitacion.Insertar(individual, matrimonial,king, Maximo,tv, acondicionado,vent, wf, to, privado, descripcion.Text);

                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Distribucion", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;//termina la ejecucion del programa despues de ejecutar el codigo
                case "UDP": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.DistribucionHabitacion.Actualizar(individual, matrimonial, king, Maximo, tv, acondicionado, vent, wf, to, privado, descripcion.Text,short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Distribucion", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.DistribucionHabitacion.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Distribuición", "Eliminar", UsuarioId);

                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
            }
        }
    }
}