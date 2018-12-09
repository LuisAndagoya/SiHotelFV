using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;

namespace CapaWeb.Formularios.Estadohabitacion
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


        protected void LlenarFormulario()
        {
            if (!IsPostBack)
            {
                QSencriptadoCSharp.QueryString qs = ulrDesencriptada();

                short Id = short.Parse(qs["Id"].ToString());
                //Carga datos para actualizacion           
                CapaDatos.Clases.Estadohabitacion.estado_habitacionDataTable DataTable = CapaProceso.Clases.EstadoHabitacion.ListaActualizar(Id);

                foreach (DataRow row in DataTable.Rows)
                {
                    NombreEstado.Text = row["NombreEstado"].ToString();

                    lblId.Text = row["IdEstadoHabitacion"].ToString();
                }
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
        protected void BloquerFormulario()
        {
            NombreEstado.Enabled = false;

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
                    error = CapaProceso.Clases.EstadoHabitacion.Insertar(NombreEstado.Text);

                    if (string.IsNullOrEmpty(error))
                    {

                        CapaProceso.Clases.Auditoria.Insertar("EstadoHabitacion", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "UDP":

                    error = CapaProceso.Clases.EstadoHabitacion.Actualizar(NombreEstado.Text, short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("EstadoHabitacion", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT":

                    error = CapaProceso.Clases.EstadoHabitacion.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("EstadoHabitacion", "Eliminar", UsuarioId);
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