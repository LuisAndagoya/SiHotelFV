using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;

namespace CapaWeb.Formularios.Hotel
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

                string Id = (qs["Id"].ToString());

                //Carga datos para actualizacion           
                CapaDatos.Clases.Hotel.hotelDataTable DataTable = CapaProceso.Clases.Hotel.ListaActualizar(Id);

                foreach (DataRow row in DataTable.Rows)
                {
                    codHotel.Text = row["codHotel"].ToString();
                    nombreHotel.Text = row["nombreHotel"].ToString();
                    numeroHabitaciones.Text = row["numeroHabitaciones"].ToString();
                    categoriaHotel.Text = row["categoriaHotel"].ToString();
                    ciudadHotel.Text = row["ciudadHotel"].ToString();
                    direccionHotel.Text = row["direccionHotel"].ToString();
                    telefonoHotel.Text = row["telefonoHotel"].ToString();
                    
                    correoHotel.Text = row["correoHotel"].ToString();
                    descripcionHotel.Text = row["descripcionHotel"].ToString();

                    lblId.Text = row["codHotel"].ToString();
                }
            }
        }

        protected void BloquerFormulario()
        {
            codHotel.Enabled = false;
            nombreHotel.Enabled = false;
            categoriaHotel.Enabled = false;
            ciudadHotel.Enabled = false;
            direccionHotel.Enabled = false;
            telefonoHotel.Enabled = false;
            correoHotel.Enabled = false;
            numeroHabitaciones.Enabled = false;
            descripcionHotel.Enabled = false;
            


            LblErro.Text = "Confirme la eliminación de los datos";
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();
            string error = "";
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            //DateTime fechaNacimiento = DateTime.Parse(fnacimiento.Text);
            switch (qs["TRN"].Substring(0, 3)) //ultilizo la variable para la opcion
            {

                case "INS":
                    error = CapaProceso.Clases.Hotel.Insertar(codHotel.Text, nombreHotel.Text,short.Parse(numeroHabitaciones.Text), categoriaHotel.Text, ciudadHotel.Text, direccionHotel.Text, telefonoHotel.Text,correoHotel.Text, direccionHotel.Text);

                    if (string.IsNullOrEmpty(error))
                    {

                        CapaProceso.Clases.Auditoria.Insertar("Hotel", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "UDP":

                    error = CapaProceso.Clases.Hotel.Actualizar(codHotel.Text, nombreHotel.Text,short.Parse(numeroHabitaciones.Text), categoriaHotel.Text, ciudadHotel.Text, direccionHotel.Text, telefonoHotel.Text, correoHotel.Text, direccionHotel.Text);
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Hotel", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT":

                    error = CapaProceso.Clases.Hotel.Eliminar(lblId.Text);
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Hotel", "Eliminar", UsuarioId);
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