using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;

namespace CapaWeb.Formularios.Menu
{
    public partial class Container : System.Web.UI.Page
    {
        private static Codificar codificar = new Codificar();
        protected void Page_Load(object sender, EventArgs e)
        {
            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();


            switch (qs["TRN"].Substring(0, 3))
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

        public QSencriptadoCSharp.QueryString ulrDesencriptada()
        {
            //1- guardo el Querystring encriptado que viene desde el request en mi objeto
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString(Request.QueryString);

            ////2- Descencripto y de esta manera obtengo un array Clave/Valor normal
            qs = QSencriptadoCSharp.Encryption.DecryptQueryString(qs);
            return qs;
        }

        protected void LlenarFormulario()
        {
            if (!IsPostBack)
            {
                QSencriptadoCSharp.QueryString qs = ulrDesencriptada();

                short Id = short.Parse(qs["Id"].ToString());
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
            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();
            string error = "";
              short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            switch (qs["TRN"].Substring(0, 3)) //ultilizo la variable para la opcion
            {

                case "INS":
                    error = CapaProceso.Clases.Menu.Insertar(nombreMenu.Text, urlMenu.Text, iconoMenu.Text);

                    if (string.IsNullOrEmpty(error))
                    {

                         CapaProceso.Clases.Auditoria.Insertar("Menu", "Insertar", UsuarioId);
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
                        CapaProceso.Clases.Auditoria.Insertar("Menu", "Actualizar", UsuarioId);
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
                         CapaProceso.Clases.Auditoria.Insertar("Menu", "Eliminar", UsuarioId);
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