using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;
using CapaWeb.Formularios.Cliente;

namespace CapaWeb.Formularios.Cliente
{
    public partial class Container : System.Web.UI.Page
    {
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
                CapaDatos.Clases.Cliente.clienteDataTable DataTable = CapaProceso.Clases.Cliente.ListaActualizar(Id);

                foreach (DataRow row in DataTable.Rows)
                {
                    dniCliente.Text = row["dniCliente"].ToString();
                    nombreCliente.Text = row["nombreCliente"].ToString();
                    apellidoCliente.Text = row["apellidoCliente"].ToString();
                    
                    sexoCliente.Text = row["sexoCliente"].ToString();
                    
                   direccionCliente.Text = row["direccionCliente"].ToString();
                    telefonoCliente.Text = row["telefonoCliente"].ToString();
                    estadoCliente.Text = row["estadoCliente"].ToString();
                    correoCliente.Text = row["correoCliente"].ToString();

                    lblId.Text = row["IdCliente"].ToString();
                }
            }
        }

        protected void BloquerFormulario()
        {
            dniCliente.Enabled = false;
            nombreCliente.Enabled = false;
            apellidoCliente.Enabled = false;
            sexoCliente.Enabled = false;
            direccionCliente.Enabled = false;
            telefonoCliente.Enabled = false;
            estadoCliente.Enabled = false;
            correoCliente.Enabled = false;
            


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
                    error = CapaProceso.Clases.Cliente.Insertar(dniCliente.Text, nombreCliente.Text,apellidoCliente.Text, sexoCliente.Text,direccionCliente.Text, telefonoCliente.Text, correoCliente.Text, estadoCliente.Text);

                    if (string.IsNullOrEmpty(error))
                    {

                        CapaProceso.Clases.Auditoria.Insertar("Cliente", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "UDP":

                    error = CapaProceso.Clases.Cliente.Actualizar(dniCliente.Text, nombreCliente.Text, apellidoCliente.Text, sexoCliente.Text, direccionCliente.Text, telefonoCliente.Text, correoCliente.Text, estadoCliente.Text,short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Cliente", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT":

                    error = CapaProceso.Clases.Cliente.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Cliente", "Eliminar", UsuarioId);
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