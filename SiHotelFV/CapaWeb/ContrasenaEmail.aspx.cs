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
            
        }



        public void enviar() {

             
            
            CapaDatos.Clases.Usuario.usuarioDataTable DataTable = Usuario.ListaRecuperar (TxtUsu.Text);

            int contar = 0;

            foreach (DataRow row in DataTable.Rows)
            {
                contar++;
            }

            if (contar > 0)
            {
                Email email = new Email();
                string nombre = "";
                string apellido = "";
                string correo = "";
                short idUsuario = 0;
                foreach (DataRow row in DataTable.Rows)
                {
                    nombre = row["apellidoEmpleado"].ToString();
                    apellido = row["nombreEmpleado"].ToString();
                    correo = row["emailEmpleado"].ToString();
                    idUsuario = short.Parse(row["idUsuario"].ToString());

                }

                var contrasenia = new Random().Next(0, 1000000000);

                String mensaje = "<strong> Estimado(a): </strong>" + apellido.ToUpper() + " " + nombre.ToUpper() + "<br/>" + "Su nueva contraseña es: " + contrasenia;


                email.enviarcorreo("Envio de  Contraseña", mensaje, correo);
                CapaProceso.Clases.Usuario.ActualizarContrasenia(idUsuario, contrasenia.ToString());
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Se a enviado una nueva contraseña al email del usuario.');</script>");
            }

            else
            {
                Response.Redirect("ContrasenaEmail.aspx");

            }


           

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            enviar();
            
        }
    }
    }

