using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace CapaWeb
{
    public partial class SiteMaster : MasterPage
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
            Login();
            
        }


        protected void Login()
        {

            if (Session["UsuarioId"] == null)
            {
                Response.Redirect("../../Index.aspx");
            } else
            {
                string UsuarioNomApe = Session["UsuarioNomApe"].ToString();
                LblNombre.Text = UsuarioNomApe;               
                
            }

        }

        
    }

}