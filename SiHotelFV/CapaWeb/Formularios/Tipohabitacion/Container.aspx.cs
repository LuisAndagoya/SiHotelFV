using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CapaWeb.Formularios.Tipohabitacion
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
                CapaDatos.Clases.Tipohabitacion.tipo_habitacionDataTable tipo_habitacionDataTable = CapaProceso.Clases.TipoHabitacion.ListaActualizar(Id);

                foreach (DataRow row in tipo_habitacionDataTable.Rows)
                {

                    ListaPrecio.SelectedValue = row["idPrecio"].ToString();
                    ListaDistribucion.SelectedValue = row["idDistribucion"].ToString();
                    nombreTipo.Text = row["nombreTipo"].ToString();

                    lblId.Text = row["idMenu_Cargo"].ToString();
                }
            }
        }


        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter
                ListaDistribucion.DataSource = CapaProceso.Clases.DistribucionHabitacion.Lista();
                ListaDistribucion.DataTextField = "camaIndividual";
                ListaDistribucion.DataValueField = "idDistribucion";
                ListaDistribucion.DataBind();

                ListaPrecio.DataSource = CapaProceso.Clases.PrecioHabitacion.Lista();
                ListaPrecio.DataTextField = "precioHabitacion";
                ListaPrecio.DataValueField = "idPrecio";
                ListaPrecio.DataBind();

            }

        }

        protected void BloquerFormulario()
        {

            ListaDistribucion.Enabled = false;
            ListaPrecio.Enabled = false;
            nombreTipo.Enabled = false;
            LblErro.Text = "Confirme la eliminación de los datos";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string error = "";
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            switch (Request.QueryString["TRN"]) //ultilizo la variable para la opcion
            {

                case "INS": //ejecuta el codigo si el usuario ingresa el numero 1
                    error = CapaProceso.Clases.TipoHabitacion.Insertar(nombreTipo.Text,Convert.ToInt16(ListaPrecio.SelectedValue.ToString()), Convert.ToInt16(ListaDistribucion.SelectedValue.ToString()));

                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("TipoHabitación", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;//termina la ejecucion del programa despues de ejecutar el codigo
                case "UDP": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.TipoHabitacion.Actualizar( nombreTipo.Text,Convert.ToInt16(ListaPrecio.SelectedValue.ToString()), Convert.ToInt16(ListaDistribucion.SelectedValue.ToString()), short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("TipoHabitación", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.TipoHabitacion.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("TipoHabitación", "Eliminar", UsuarioId);

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