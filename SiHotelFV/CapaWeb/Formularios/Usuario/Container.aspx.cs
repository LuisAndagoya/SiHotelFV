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

namespace CapaWeb.Formularios.Usuario
{
    public partial class Container : System.Web.UI.Page
    {
        private static Codificar codificar = new Codificar();

        protected void Page_Load(object sender, EventArgs e)
        {

            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();


            switch (qs["TRN"].Substring(0,3))
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
                CapaDatos.Clases.Usuario.usuarioDataTable usuarioDataTable = CapaProceso.Clases.Usuario.ListaActualizar(Id);



                foreach (DataRow row in usuarioDataTable.Rows)
                {

                    ListaEmpleado.SelectedValue = row["idEmpleado"].ToString();
                    ListaCargo.SelectedValue = row["idCargo"].ToString();
                    usernameUsuario.Text = row["usernameUsuario"].ToString();

                    passwordUsuario.Text = codificar.Base64Decode(row["passwordUsuario"].ToString());
                    DropDownList1.SelectedValue = row["estadoUsuario"].ToString();

                    lblId.Text = row["idUsuario"].ToString();
                }
            }
        }
        
        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter
                ListaEmpleado.DataSource = CapaProceso.Clases.Empleado.Lista();
                ListaEmpleado.DataTextField = "nombreEmpleado";
                ListaEmpleado.DataValueField = "idEmpleado";
                ListaEmpleado.DataBind();



                ListaCargo.DataSource = CapaProceso.Clases.Cargo.Lista();
                ListaCargo.DataTextField = "nombreCargo";
                ListaCargo.DataValueField = "idCargo";
                ListaCargo.DataBind();

            }

        }

        protected void BloquerFormulario()
        {

            ListaCargo.Enabled = false;
            ListaEmpleado.Enabled = false;
            usernameUsuario.Enabled = false;
            passwordUsuario.Enabled = false;
            DropDownList1.Enabled = false;
            
            LblErro.Text = "Confirme la eliminación de los datos";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            QSencriptadoCSharp.QueryString qs = ulrDesencriptada();

            string error = "";
             short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            switch (qs["TRN"].Substring(0, 3)) //ultilizo la variable para la opcion
            {

                case "INS": //ejecuta el codigo si el usuario ingresa el numero 1
                    error = CapaProceso.Clases.Usuario.Insertar(usernameUsuario.Text, passwordUsuario.Text, DropDownList1.SelectedValue.ToString(), Convert.ToInt16(ListaEmpleado.SelectedValue.ToString()),Convert.ToInt16(ListaCargo.SelectedValue.ToString()));

                    if (string.IsNullOrEmpty(error))
                    {
                       CapaProceso.Clases.Auditoria.Insertar("Usuario", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;//termina la ejecucion del programa despues de ejecutar el codigo
                case "UDP": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.Usuario.Actualizar(usernameUsuario.Text, passwordUsuario.Text, DropDownList1.SelectedValue.ToString(), Convert.ToInt16(ListaEmpleado.SelectedValue.ToString()), Convert.ToInt16(ListaCargo.SelectedValue.ToString()), short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Usuario", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT": //ejecuta el codigo si el usuario ingresa el numero 2

                    error = CapaProceso.Clases.Usuario.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Usuario", "Eliminar", UsuarioId);

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