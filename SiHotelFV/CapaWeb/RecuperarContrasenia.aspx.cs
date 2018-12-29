using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaProceso.Clases;

namespace CapaWeb
{
    public partial class RecuperarContraseña : System.Web.UI.Page
    {
        Email email = new Email();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool respuesta;

           // respuesta = email.enviarcorreo(TextBox1.Text, TextBox2.Text, TextBox3.Text);

            this.Page.Response.Write("<script language='JavaScript'>window.alert('Se a enviado una nueva contraseña al email del usuario.');</script>");
        }
    }
}