using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CapaWeb.Formularios.Cliente
{
    public partial class Contairner : System.Web.UI.Page
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
                CapaDatos.Clases.Cliente.ClienteDataTable DataTable = CapaProceso.Clases.Cliente.ListaActualizar(Id);

                foreach (DataRow row in DataTable.Rows)
                {
                    CedulaCliente.Text = row["CedulaCliente"].ToString();
                    NombreCliente.Text = row["NombreCliente"].ToString();
                    ApellidoCliente.Text = row["ApellidoCliente"].ToString();
                    DireccionCliente.Text = row["DireccionCliente"].ToString();
                    Telefono.Text = row["Telefono"].ToString();
                    Email.Text = row["Email"].ToString();
                   

                    lblId.Text = row["idCliente"].ToString();
                }
            }
        }

        protected void BloquerFormulario()
        {
            CedulaCliente.Enabled = false;
            NombreCliente.Enabled = false;
            ApellidoCliente.Enabled = false;
            Telefono.Enabled = false;
            Email.Enabled = false;
            


            LblErro.Text = "Confirme la eliminación de los datos";
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string error = "";
            //  short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            switch (Request.QueryString["TRN"])
            {

                case "INS":
                    error = CapaProceso.Clases.Cliente.Insertar(CedulaCliente.Text, NombreCliente.Text, ApellidoCliente.Text, DireccionCliente.Text, Telefono.Text, Email.Text);

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

                    error = CapaProceso.Clases.Cliente.Actualizar(CedulaCliente.Text,NombreCliente.Text, ApellidoCliente.Text,DireccionCliente.Text ,Telefono.Text, Email.Text, short.Parse(lblId.Text));
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

                    error = CapaProceso.Clases.Cliente.Eliminar(short.Parse(lblId.Text));
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