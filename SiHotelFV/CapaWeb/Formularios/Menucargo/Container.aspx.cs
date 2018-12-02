using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace CapaWeb.Formularios.Menucargo
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
                CapaDatos.Clases.Menucargo.menu_cargoDataTable menu_cargoDataTable = CapaProceso.Clases.Menucargo.ListaActualizar(Id);

                foreach (DataRow row in menu_cargoDataTable.Rows)
                {
                    
                    ListaCargo.SelectedValue = row["IdCargo"].ToString();
                    ListaSubmenu.SelectedValue = row["idSubMenu"].ToString();
                    lblId.Text = row["idMenu_Cargo"].ToString();
                }
            }
        }

    
        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter
                ListaCargo.DataSource = CapaProceso.Clases.Cargo.Lista();
                ListaCargo.DataTextField = "nombreCargo";
                ListaCargo.DataValueField = "idCargo";
                ListaCargo.DataBind();

                ListaSubmenu.DataSource = CapaProceso.Clases.Submenu.Lista();
                ListaSubmenu.DataTextField = "nombreSubMenu";
                ListaSubmenu.DataValueField = "idSubMenu";
                ListaSubmenu.DataBind();

            }
           
        }

        protected void BloquerFormulario()
        {
            
            ListaCargo.Enabled = false;
            ListaSubmenu.Enabled = false;
            LblErro.Text = "Confirme la eliminación de los datos";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string error = "";
           // short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            switch (Request.QueryString["TRN"]) //ultilizo la variable para la opcion
            {

                case "INS": //ejecuta el codigo si el usuario ingresa el numero 1
                    error = CapaProceso.Clases.Menucargo.Insertar(Convert.ToInt16(ListaCargo.SelectedValue.ToString()), Convert.ToInt16(ListaSubmenu.SelectedValue.ToString()));
                   
                    if (string.IsNullOrEmpty(error))
                    {
                        //CapaProceso.Clases.Auditoria.Insertar("Usuario", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;//termina la ejecucion del programa despues de ejecutar el codigo
                case "UDP": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.Menucargo.Actualizar(Convert.ToInt16(ListaCargo.SelectedValue.ToString()), Convert.ToInt16(ListaSubmenu.SelectedValue.ToString()), short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        //CapaProceso.Clases.Auditoria.Insertar("Usuario", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.Menucargo.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        //CapaProceso.Clases.Auditoria.Insertar("Usuario", "Eliminar", UsuarioId);
                        
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