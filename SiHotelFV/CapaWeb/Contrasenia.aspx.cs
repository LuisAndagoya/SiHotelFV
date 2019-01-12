using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using CapaProceso.Clases;

namespace CapaWeb
{
    public partial class Contrasenia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();
        }

        private static Codificar codificar = new Codificar();
        public QSencriptadoCSharp.QueryString ulrDesencriptada()
        {
            //1- guardo el Querystring encriptado que viene desde el request en mi objeto
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString(Request.QueryString);

            ////2- Descencripto y de esta manera obtengo un array Clave/Valor normal
            qs = QSencriptadoCSharp.Encryption.DecryptQueryString(qs);
            return qs;
        }
        public void enviar()
        {

            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();
            string error = "Contraseña no coincide con la anterior";
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            string contraseniaEncriptada = codificar.Base64Encode(actual.Text);

            CapaDatos.Clases.Usuario.usuarioDataTable DataTable = Usuario.ListaContrasenia(UsuarioId);
            int contar = 0;

            foreach (DataRow row in DataTable.Rows)
            {
                contar++;
            }

            if (contar > 0)
            {


                string contrasenia = "";

                foreach (DataRow row in DataTable.Rows)
                {
                    contrasenia = row["passwordUsuario"].ToString();


                }

                if (contrasenia == contraseniaEncriptada)
                {
                    CapaProceso.Clases.Usuario.ActualizarContrasenia(UsuarioId, nueva.Text);
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    Response.Redirect("Contrasenia.aspx");
                }



            }



                
            
            }


        protected void Button1_Click(object sender, EventArgs e)
        {
            enviar();

        }
    }
}