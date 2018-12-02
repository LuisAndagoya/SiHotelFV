using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CapaWeb.Formularios.Menu
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
                CapaDatos.Clases.Menu.menuDataTable DataTable = CapaProceso.Clases.Menu.ListaActualizar(Id);

                foreach (DataRow row in DataTable.Rows)
                {
                    nombreMenu.Text = row["nombreMenu"].ToString();
                    urlMenu.Text = row["urlMenu"].ToString();

                    lblId.Text = row["IdMenu"].ToString();
                }
            }
        }

        protected void BloquerFormulario()
        {
            nombreMenu.Enabled = false;
            urlMenu.Enabled = false;

            LblErro.Text = "Confirme la eliminación de los datos";
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string error = "";
            //  short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            switch (Request.QueryString["TRN"])
            {

                case "INS":
                    error = CapaProceso.Clases.Menu.Insertar(nombreMenu.Text, urlMenu.Text, iconoMenu.Text);

                    if (string.IsNullOrEmpty(error))
                    {

                        // CapaProceso.Clases.Auditoria.Insertar("Cargo", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "UDP":

                    error = CapaProceso.Clases.Menu.Actualizar(nombreMenu.Text,urlMenu.Text, iconoMenu.Text, short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        // CapaProceso.Clases.Auditoria.Insertar("Cargo", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT":

                    error = CapaProceso.Clases.Menu.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        // CapaProceso.Clases.Auditoria.Insertar("Auditoria", "Eliminar", UsuarioId);
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