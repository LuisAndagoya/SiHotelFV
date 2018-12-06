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
                    camaIndividual.Checked = true;

                    camaMatrimonial.Checked =true;
                    camaKing.Checked = true;

                    television.SelectedValue = row["televisionCable"].ToString();
                    aire.SelectedValue = row["aireAcondicionado"].ToString();
                    ventilador1.SelectedValue = row["ventilador"].ToString();
                    wifi1.SelectedValue = row["wifi"].ToString();
                    toallas1.SelectedValue = row["toallas"].ToString();
                    banio1.SelectedValue = row["banioPrivado"].ToString();

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
                

            switch (Request.QueryString["TRN"]) //ultilizo la variable para la opcion
            {

                case "INS": //ejecuta el codigo si el usuario ingresa el numero 1
                    error = CapaProceso.Clases.DistribucionHabitacion.Insertar(Convert.ToInt16(camaIndividual.Checked.ToString()), Convert.ToInt16(camaMatrimonial.Checked.ToString()),Convert.ToInt16(camaKing.Checked.ToString()), Maximo,televisionCable.SelectedValue.ToString(), aireAcondicionado.SelectedValue.ToString(),ventilador.SelectedValue.ToString(), wifi.SelectedValue.ToString(), toallas.SelectedValue.ToString(), banioPrivado.SelectedValue.ToString());

                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Usuario", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;//termina la ejecucion del programa despues de ejecutar el codigo
                case "UDP": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.DistribucionHabitacion.Actualizar(Convert.ToInt16(camaIndividual.Checked.ToString()), Convert.ToInt16(camaMatrimonial.Checked.ToString()), Convert.ToInt16(camaKing.Checked.ToString()), Maximo, televisionCable.SelectedValue.ToString(), aireAcondicionado.SelectedValue.ToString(), ventilador.SelectedValue.ToString(), wifi.SelectedValue.ToString(), toallas.SelectedValue.ToString(), banioPrivado.SelectedValue.ToString(),short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Usuario", "Actualizar", UsuarioId);
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
                        CapaProceso.Clases.Auditoria.Insertar("Usuario", "Eliminar", UsuarioId);

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