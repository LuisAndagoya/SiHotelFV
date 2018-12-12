using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaDatos;
using CapaProceso.Clases;

namespace CapaWeb
{
    public partial class ContrasenaEmail : System.Web.UI.Page
    {
        Email email = new Email();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioId"] != null)
            {
                Response.Redirect("inicio.aspx");
            }
        }


       
        protected void Email()
        {
            string DatosEmail = CapaProceso.Clases.Email.Lista();
            string Mensaje = "Se envió sus datos a su  correo antes registrado. Gracias";
           
         
                CapaDatos.Clases.Usuario.usuarioDataTable DataTable = CapaProceso.Clases.Usuario.DatosUsuario(TxtUsu.Text);


                foreach (DataRow row in DataTable.Rows)
                {
                    Session["UsuarioId"] = row["idUsuario"];
                    Session["UsuarioNomApe"] = row["nombreEmpleado"].ToString() + " " + row["apellidoEmpleado"].ToString();
                    Session["idCargo"] = row["idCargo"];
                    Session["estadoUsuario"] = row["estadoUsuario"];
                }
                short idUsuario = short.Parse(Session["UsuarioId"].ToString());
                
                Response.Redirect("Index.aspx");
            }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            bool respuesta;

            respuesta = email.enviarcorreo(TxtUsu.Text);

            this.Page.Response.Write("<script language='JavaScript'>window.alert('Se a enviado una nueva contraseña al email del usuario.');</script>");
        }
    }
    }

