using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaWeb.Formularios.Descripcionhabitacion;
using CapaProceso.Clases;
using System.IO;

namespace CapaWeb.Formularios.Descripcionhabitacion
{
    public partial class Container : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();


            switch (qs["TRN"].Substring(0, 3))
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
                CapaDatos.Clases.DescripcionHabitacion.descripcion_habitacionDataTable DataTable = CapaProceso.Clases.DescripcionHabitacion.ListaActualizar(Id);

                foreach (DataRow row in DataTable.Rows)
                {
                    descripcionHabitacion.Text = row["descripcionHabitacion"].ToString();
                    estadoDescripcion.Text = row["estadoDescripcion"].ToString();
                    ListaHabitacion.SelectedValue= row["idTipoHabitacion"].ToString();
                 

                    lblId.Text = row["idDescripcion"].ToString();
                }
            }
        }

        protected void BloquerFormulario()
        {
            descripcionHabitacion.Enabled = false;
            estadoDescripcion.Enabled = false;
            ListaHabitacion.Enabled = false;
           



            LblErro.Text = "Confirme la eliminación de los datos";
        }

        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter
                ListaHabitacion.DataSource = CapaProceso.Clases.TipoHabitacion.Lista();
                ListaHabitacion.DataTextField = "nombreTipo";
                ListaHabitacion.DataValueField = "idtipo";
                ListaHabitacion.DataBind();



            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();
            string error = "";
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            switch (qs["TRN"].Substring(0, 3)) //ultilizo la variable para la opcion
            {

                case "INS": //ejecuta el codigo si el usuario ingresa el numero 1
                    error = CapaProceso.Clases.DescripcionHabitacion.Insertar(descripcionHabitacion.Text, estadoDescripcion.Text, Convert.ToInt16(ListaHabitacion.SelectedValue.ToString()));

                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Descripción H.", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;//termina la ejecucion del programa despues de ejecutar el codigo
                case "UDP": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.DescripcionHabitacion.Actualizar(descripcionHabitacion.Text,estadoDescripcion.Text, Convert.ToInt16(ListaHabitacion.SelectedValue.ToString()), short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Descripción H.", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.DescripcionHabitacion.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Descripción H", "Eliminar", UsuarioId);

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