using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaWeb.Formularios.Empleado;
using CapaProceso.Clases;
using System.IO;

namespace CapaWeb.Formularios.Empleado
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
                CapaDatos.Clases.Empleado.empleadoDataTable DataTable = CapaProceso.Clases.Empleado.ListaActualizar(Id);

                foreach (DataRow row in DataTable.Rows)
                {
                    DateTime fechaNacimiento = DateTime.Parse(row["fnacimientoEmpleado"].ToString());
                    DateTime fechaRegistro = DateTime.Parse(row["fecharegistroEmpleado"].ToString());
                    dniEmpleado.Text = row["dniEmpleado"].ToString();
                    nombreEmpleado.Text = row["nombreEmpleado"].ToString();
                    apellidoEmpleado.Text = row["apellidoEmpleado"].ToString();
                    fnacimiento.Text = fechaNacimiento.ToString("yyyy-MM-dd");
                    sexoEmpleado.Text = row["sexoEmpleado"].ToString();
                    estadocivilEmpleado.Text = row["estadocivilEmpleado"].ToString();
                    domicilioEmpleado.Text = row["domicilioEmpleado"].ToString();
                    telefmovilEmpleado.Text = row["telefmovilEmpleado"].ToString();
                    fecharegistroEmpleado.Text = fechaRegistro.ToString("yyyy-MM-dd");
                    emailEmpleado.Text = row["emailEmpleado"].ToString();
                    txtfot.Text = row["imagenEmpleado"].ToString();

                    lblId.Text = row["IdEmpleado"].ToString();

                    //ver imagen
                    Image1.ImageUrl = "~/" + row["imagenEmpleado"].ToString();
                    
                    var imagen = row["imagenEmpleado"] as Image;
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
            txtfot.Enabled = false;
          


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
                    error = CapaProceso.Clases.Empleado.Insertar(dniEmpleado.Text, nombreEmpleado.Text, apellidoEmpleado.Text, fnacimiento.Text, sexoEmpleado.Text, estadocivilEmpleado.Text, domicilioEmpleado.Text, telefmovilEmpleado.Text, emailEmpleado.Text, fecharegistroEmpleado.Text, txtfot.Text, estadoEmpleado.Text);

                    if (string.IsNullOrEmpty(error))
                    {

                        CapaProceso.Clases.Auditoria.Insertar("Empleado", "Insertar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
                case "UDP":

                    error = CapaProceso.Clases.Empleado.Actualizar(dniEmpleado.Text, nombreEmpleado.Text, apellidoEmpleado.Text, fnacimiento.Text, sexoEmpleado.Text, estadocivilEmpleado.Text, domicilioEmpleado.Text, telefmovilEmpleado.Text, emailEmpleado.Text, short.Parse(lblId.Text), fecharegistroEmpleado.Text, txtfot.Text, estadoEmpleado.Text);
                    if (string.IsNullOrEmpty(error))
                    {
                        CapaProceso.Clases.Auditoria.Insertar("Empleado", "Actualizar", UsuarioId);
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
                        CapaProceso.Clases.Auditoria.Insertar("Empleado", "Eliminar", UsuarioId);
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                    }

                    break;
            }
        }


        protected void btnSubir_Click1(object sender, EventArgs e)
        {
            try
            {

                if (FileUpload1.HasFile)
                {

                    // Se verifica que la extensión sea de un formato válido

                    string ext = FileUpload1.PostedFile.FileName;

                    string rutas = FileUpload1.FileName;

                    ext = ext.Substring(ext.LastIndexOf(".") + 1).ToLower();

                    string[] formatos = new string[] { "jpg", "jpeg", "bmp", "png", "gif" };

                    if (Array.IndexOf(formatos, ext) < 0)
                    {

                        Response.Write("<script language=javascript>alert('Formato de imagen inválido.');</script>");

                    }

                    else
                    {

                        string ruta = Server.MapPath("~/Fotos");

                        // Si el directorio no existe, crearlo

                        if (!Directory.Exists(ruta))

                            Directory.CreateDirectory(ruta);

                        string archivo = String.Format("{0}\\{1}", ruta, FileUpload1.FileName);

                        // Verificar que el archivo no exista

                        if (File.Exists(archivo))
                        {

                            // MensajeError(String.Format(

                            Response.Write("<script language=javascript>alert('Ya existe una imagen con este nombre " + FileUpload1.FileName + "');</script>");

                            string foto = "~/Fotos/" + rutas;

                            FileUpload1.SaveAs(archivo);

                            Image1.ImageUrl = foto;

                            txtfot.Text = "Fotos/" + rutas;

                        }

                        else
                        {

                            string foto = "~/Fotos/" + rutas;

                            FileUpload1.SaveAs(archivo);

                            Image1.ImageUrl = foto;

                            txtfot.Text = "Fotos/" + rutas; ;

                        }

                    }

                }

                else

                    Response.Write("<script language=javascript>alert('No ha seleccionado  ninguna imagen.');</script>");

            }

            catch (Exception ex)
            {

                Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");

            }
        }
    }
    }
