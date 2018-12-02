using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioId"] != null)
            {
                Response.Redirect("inicio.aspx");
            }
        }

        protected void Login()
        {
            int error;
            string Mensaje = "Usuario o Contraseña incorrectos";
            error = CapaProceso.Clases.Usuario.Login(TxtUsu.Text, TxtCont.Text);
            if (error == 0)
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + Mensaje + "');</script>");
            }
            else
            {
                CapaDatos.Clases.Usuario.usuarioDataTable DataTable = CapaProceso.Clases.Usuario.DatosUsuario(TxtUsu.Text);
              

                foreach (DataRow row in DataTable.Rows)
                {
                    Session["UsuarioId"] = row["idUsuario"];
                    Session["UsuarioNomApe"] = row["nombreEmpleado"].ToString() + " " + row["apellidoEmpleado"].ToString();
                    Session["idCargo"] = row["idCargo"];
                }
                short idUsuario = short.Parse(Session["UsuarioId"].ToString());
                CapaProceso.Clases.Auditoria.Insertar("Usuario", "Ingreso al sistema", idUsuario);
                Response.Redirect("inicio.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}