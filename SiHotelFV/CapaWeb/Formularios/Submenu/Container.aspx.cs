using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CapaWeb.Formularios.Submenu
{
    public partial class Container : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request.QueryString["TRN"])
            {

                case "INS":
                    CargarCombo();


                    break;

                case "UDP":
                    CargarCombo();

                    LlenarFormulario();

                    break;

                case "DLT":
                    CargarCombo();

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
                CapaDatos.Clases.Submenu.submenuDataTable submenuDataTable = CapaProceso.Clases.Submenu.ListaActualizar(Id);

                foreach (DataRow row in submenuDataTable.Rows)
                {

                    ListaMenu.SelectedValue = row["IdMenu"].ToString();
                    nombreSubMenu.Text = row["nombreSubMenu"].ToString();
                   
                    urlSubMenu.Text = row["urlSubMenu"].ToString();
                    iconoSubMenu.Text = row["iconoSubMenu"].ToString();
                    lblId.Text = row["idSubMenu"].ToString();
                }
            }
        }


        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter
                ListaMenu.DataSource = CapaProceso.Clases.Menu.Lista();
                ListaMenu.DataTextField = "nombreMenu";
                ListaMenu.DataValueField = "idMenu";
                ListaMenu.DataBind();

             

            }

        }

        protected void BloquerFormulario()
        {

            ListaMenu.Enabled = false;
            nombreSubMenu.Enabled = false;
            urlSubMenu.Enabled = false;
            iconoSubMenu.Enabled = false;
            LblErro.Text = "Confirme la eliminación de los datos";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string error = "";
             short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            switch (Request.QueryString["TRN"]) //ultilizo la variable para la opcion
            {

                case "INS": //ejecuta el codigo si el usuario ingresa el numero 1
                    error = CapaProceso.Clases.Submenu.Insertar(Convert.ToInt16(ListaMenu.SelectedValue.ToString()),nombreSubMenu.Text, urlSubMenu.Text, iconoSubMenu.Text);

                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Submenu", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;//termina la ejecucion del programa despues de ejecutar el codigo
                case "UDP": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.Submenu.Actualizar(Convert.ToInt16(ListaMenu.SelectedValue.ToString()), nombreSubMenu.Text, urlSubMenu.Text, iconoSubMenu.Text,   short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Submenu", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.Submenu.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Submenu", "Eliminar", UsuarioId);

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