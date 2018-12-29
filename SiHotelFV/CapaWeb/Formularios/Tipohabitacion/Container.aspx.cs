using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;
using System.IO;


namespace CapaWeb.Formularios.Tipohabitacion
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
                CapaDatos.Clases.TipoHabitacion.tipo_habitacionDataTable tipo_habitacionDataTable = CapaProceso.Clases.TipoHabitacion.ListaActualizar(Id);

                foreach (DataRow row in tipo_habitacionDataTable.Rows)
                {

                    ListaPrecio.SelectedValue = row["idPrecio"].ToString();
                    estadoTipo.SelectedValue = row["estadoTipo"].ToString();
                    nombreTipo.Text = row["nombreTipo"].ToString();
                    txtfot.Text = row["imagenTipo"].ToString();

                    lblId.Text = row["idtipo"].ToString();
                }
            }
        }


        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter
              

                ListaPrecio.DataSource = CapaProceso.Clases.PrecioHabitacion.Lista();
                ListaPrecio.DataTextField = "precioHabitacion";
                ListaPrecio.DataValueField = "idPrecio";
                ListaPrecio.DataBind();

            }

        }

        protected void BloquerFormulario()
        {

           
            ListaPrecio.Enabled = false;
            nombreTipo.Enabled = false;
            txtfot.Enabled = false;
            estadoTipo.Enabled = false;
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
                    error = CapaProceso.Clases.TipoHabitacion.Insertar(nombreTipo.Text,Convert.ToInt16(ListaPrecio.SelectedValue.ToString()),txtfot.Text,estadoTipo.SelectedValue.ToString());

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

                    error = CapaProceso.Clases.TipoHabitacion.Actualizar( nombreTipo.Text,Convert.ToInt16(ListaPrecio.SelectedValue.ToString()), txtfot.Text, estadoTipo.SelectedValue.ToString(), short.Parse(lblId.Text));
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

                            txtfot.Text = foto;

                        }

                        else
                        {

                            string foto = "~/Fotos/" + rutas;

                            FileUpload1.SaveAs(archivo);

                            Image1.ImageUrl = foto;

                            txtfot.Text = foto;

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