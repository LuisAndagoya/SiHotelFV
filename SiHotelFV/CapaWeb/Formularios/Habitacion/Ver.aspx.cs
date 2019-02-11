using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;

namespace CapaWeb.Formularios.Habitacion
{
    public partial class Ver : System.Web.UI.Page
    {
      
        private static Codificar codificar = new Codificar();
        protected void Page_Load(object sender, EventArgs e)
        {
            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();


            switch (qs["TRN"].Substring(0, 3))
            {

                case "INS":
                    //CargarCombo();


                    break;

                case "UDP":
                    //CargarCombo();

                    //LlenarFormulario();

                    break;

                case "DLT":
                    //CargarCombo();

                    //LlenarFormulario();
                    //BloquerFormulario();
                    break;
                case "VER":
                    //CargarCombo();

                    LlenarFormulario();
                    //BloquerFormulario();
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
                CapaDatos.Clases.Habitacion.habitacionDataTable habitacionDataTable = CapaProceso.Clases.Habitacion.ListaDetalle(Id);

                foreach (DataRow row in habitacionDataTable.Rows)
                {
                    
                    // string varios = "~/";
                    ListaHotel.SelectedValue = row["codHotel"].ToString();
                    ListaEstado.SelectedValue = row["idEstadoHabitacion"].ToString();
                    ListaTipo.SelectedValue = row["idtipo"].ToString();
                    imagenTipo.ImageUrl = row["imagenTipo"].ToString();
                    var imagen = row["imagenTipo"] as Image;
                    numeroHabitacion.Text = row["numeroHabitacion"].ToString();

                    lblHotel.Text = row["nombreHotel"].ToString();
                    lblNumeroHabitacion.Text= row["numeroHabitacion"].ToString();
                    lblTipoHabitacion.Text= row["nombreTipo"].ToString();
                    lblEstadoHabitacion.Text= row["nombreEstadoHabitacion"].ToString();
                    lblDescripcion.Text = row["descripcionHabitacion"].ToString();
                    lblMaximoPersonas.Text= row["maximoTipo"].ToString();
                    lblPrecioHabitacion.Text = row["precioHabitacion"].ToString();

                }
            }
        }


        //protected void CargarCombo()
        //{
        //    if (!IsPostBack)
        //    {
        //        //Llenar un combo box dinamicamente con tabla adapter


        //        ListaHotel.DataSource = CapaProceso.Clases.Hotel.Lista();
        //        ListaHotel.DataTextField = "nombreHotel";
        //        ListaHotel.DataValueField = "codHotel";
        //        ListaHotel.DataBind();
                

        //        ListaTipo.DataSource = CapaProceso.Clases.TipoHabitacion.Lista();
        //        ListaTipo.DataTextField = "nombreTipo";
        //        ListaTipo.DataValueField = "idtipo";
        //        ListaTipo.DataBind();

        //        ListaEstado.DataSource = CapaProceso.Clases.EstadoHabitacion.Lista();
        //        ListaEstado.DataTextField = "nombreEstadoHabitacion";
        //        ListaEstado.DataValueField = "idEstadoHabitacion";
        //        ListaEstado.DataBind();
        //    }

        //}

        //protected void BloquerFormulario()
        //{


        //    ListaEstado.Enabled = false;
        //    ListaEstado.Enabled = false;
        //    ListaHotel.Enabled = false;
        //    numeroHabitacion.Enabled = false;
            
        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    QSencriptadoCSharp.QueryString qs = ulrDesencriptada();
        //    string error = "";
        //    short UsuarioId = short.Parse(Session["UsuarioId"].ToString());

        //    switch (qs["TRN"].Substring(0, 3)) //ultilizo la variable para la opcion
        //    {

        //        case "INS": //ejecuta el codigo si el usuario ingresa el numero 1
        //            error = CapaProceso.Clases.Habitacion.Insertar((short.Parse(numeroHabitacion.Text)), Convert.ToInt16(ListaTipo.SelectedValue.ToString()), ListaHotel.SelectedValue.ToString(), Convert.ToInt16(ListaEstado.SelectedValue.ToString()));

        //            if (string.IsNullOrEmpty(error))
        //            {
        //                CapaProceso.Clases.Auditoria.Insertar("Habitación", "Insertar", UsuarioId);
        //                Response.Redirect("Index.aspx");
        //            }
        //            else
        //            {
        //                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
        //            }

        //            break;//termina la ejecucion del programa despues de ejecutar el codigo
        //        case "UDP": //ejecuta el codigo si el usuario ingresa el numero 2

        //            error = CapaProceso.Clases.Habitacion.Actualizar((short.Parse(numeroHabitacion.Text)), Convert.ToInt16(ListaTipo.SelectedValue.ToString()), ListaHotel.SelectedValue.ToString(), Convert.ToInt16(ListaEstado.SelectedValue.ToString()));
        //            if (string.IsNullOrEmpty(error))
        //            {
        //                CapaProceso.Clases.Auditoria.Insertar("Habitación", "Actualizar", UsuarioId);
        //                Response.Redirect("Index.aspx");
        //            }
        //            else
        //            {
        //                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
        //            }

        //            break;
        //        case "DLT": //ejecuta el codigo si el usuario ingresa el numero 2

        //            error = CapaProceso.Clases.Habitacion.Eliminar(short.Parse(numeroHabitacion.Text));
        //            if (string.IsNullOrEmpty(error))
        //            {
        //                CapaProceso.Clases.Auditoria.Insertar("Habitación", "Eliminar", UsuarioId);

        //                Response.Redirect("Index.aspx");
        //            }
        //            else
        //            {
        //                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
        //            }

        //            break;
        //    }
        //}
    }
    }
