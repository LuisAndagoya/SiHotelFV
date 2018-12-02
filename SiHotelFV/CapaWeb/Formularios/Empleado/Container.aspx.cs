using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CapaWeb.Formularios.Empleado
{
    public partial class Container : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request.QueryString["TRN"])
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


        protected void validarce()
        {
            string cedula = dniEmpleado.Text;
            char[] vector = cedula.ToArray();
            int sumatotal = 0, sumi = 0;
            if (vector.Length == 10)
            {
                for (int i = 0; i < vector.Length - 1; i++)
                {
                    int numero = Convert.ToInt32(vector[i].ToString());
                   // txtnom.Text = "Verificar" + numero.ToString();
                    if ((i % 2) == 1)
                    {
                        sumatotal = sumatotal + numero;
                       // txtfot.Text = "Suma de pares" + sumatotal;
                    }
                    else
                    {
                        numero = numero * 2;
                        if (numero > 9)
                        {
                            numero = numero - 9;
                            sumi = sumi + numero;
                        }
                        else
                        {
                            sumi = sumi + numero;
                        }
                       // txtcod.Text = "Suma de impares" + sumi;


                    }
                }

                sumatotal = sumatotal + sumi;
               // txtgen.Text = Convert.ToString(sumatotal);
                sumatotal = 10 - (sumatotal % 10);
                if (sumatotal == Convert.ToInt32(vector[9].ToString()))
                {
                   // txtnom.Text = Convert.ToString(sumatotal);
                }
                else
                {
                   // txtape.Text = Convert.ToString(sumatotal);
                }
            }
            else
            {
               // txtfot.Text = "Numeros ingresados menos o mas de 10";
            }

        }

        protected void LlenarFormulario()
        {
            if (!IsPostBack)
            {
                short Id = short.Parse(Request.QueryString["Id"]);
                //Carga datos para actualizacion           
                CapaDatos.Clases.Empleado.empleadoDataTable DataTable = CapaProceso.Clases.Empleado.ListaActualizar(Id);

                foreach (DataRow row in DataTable.Rows)
                {
                    dniEmpleado.Text = row["dniEmpleado"].ToString();
                    nombreEmpleado.Text = row["nombreEmpleado"].ToString();
                    apellidoEmpleado.Text = row["apellidoEmpleado"].ToString();
                    fnacimiento.Text = row["fnacimientoEmpleado"].ToString();
                    sexoEmpleado.Text = row["sexoEmpleado"].ToString();
                    estadocivilEmpleado.Text = row["estadocivilEmpleado"].ToString();
                    domicilioEmpleado.Text = row["domicilioEmpleado"].ToString();
                    telefmovilEmpleado.Text = row["telefmovilEmpleado"].ToString();
                    fecharegistroEmpleado.Text = row["fecharegistroEmpleado"].ToString();
                    emailEmpleado.Text = row["emailEmpleado"].ToString();

                    lblId.Text = row["IdEmpleado"].ToString();
                }
            }
        }

        protected void BloquerFormulario()
        {
            dniEmpleado.Enabled = false;
            nombreEmpleado.Enabled = false;
            apellidoEmpleado.Enabled = false;
            fnacimiento.Enabled = false;
            sexoEmpleado.Enabled = false;
            estadocivilEmpleado.Enabled = false;
            domicilioEmpleado.Enabled = false;
            telefmovilEmpleado.Enabled = false;
            fecharegistroEmpleado.Enabled = false;
            emailEmpleado.Enabled = false;
            

            LblErro.Text = "Confirme la eliminación de los datos";
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string error = "";
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
            //DateTime fechaNacimiento = DateTime.Parse(fnacimiento.Text);
            switch (Request.QueryString["TRN"])
            {

                case "INS":
                    error = CapaProceso.Clases.Empleado.Insertar(dniEmpleado.Text, nombreEmpleado.Text, apellidoEmpleado.Text, fnacimiento.Text, sexoEmpleado.Text, estadocivilEmpleado.Text, domicilioEmpleado.Text,telefmovilEmpleado.Text, emailEmpleado.Text, fecharegistroEmpleado.Text);

                    if (string.IsNullOrEmpty(error))
                    {

                        // CapaProceso.Clases.Auditoria.Insertar("Cargo", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "UDP":

                    error = CapaProceso.Clases.Empleado.Actualizar(dniEmpleado.Text, nombreEmpleado.Text, apellidoEmpleado.Text, fnacimiento.Text, sexoEmpleado.Text, estadocivilEmpleado.Text, domicilioEmpleado.Text, telefmovilEmpleado.Text, emailEmpleado.Text, short.Parse(lblId.Text), fecharegistroEmpleado.Text);
                    if (string.IsNullOrEmpty(error))
                    {
                        // CapaProceso.Clases.Auditoria.Insertar("Cargo", "Actualizar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "DLT":

                    error = CapaProceso.Clases.Empleado.Eliminar(short.Parse(lblId.Text));
                    if (string.IsNullOrEmpty(error))
                    {
                        // CapaProceso.Clases.Auditoria.Insertar("Auditoria", "Eliminar", UsuarioId);
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