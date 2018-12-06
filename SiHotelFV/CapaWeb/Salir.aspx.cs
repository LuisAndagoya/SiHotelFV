using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class Salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            CapaProceso.Clases.Auditoria.Insertar("Usuario", "Salida del sistema", UsuarioId);
            Session.Abandon();
            Response.Redirect("Index.aspx");
        }
    }
}