using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;


namespace CapaWeb.Formularios.Empleado
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
                    


                    break;

                case "UDP":
                   

                    LlenarFormulario();

                    break;

                case "DLT":
                   

                    LlenarFormulario();
                    BloquerFormulario();
                    break;
                case "VER":
                   

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

                    imagenEmpleado.ImageUrl = "~/"+ row["imagenEmpleado"].ToString();
                    var imagen = row["imagenEmpleado"] as Image;

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
            

        }


      


      
    }
}