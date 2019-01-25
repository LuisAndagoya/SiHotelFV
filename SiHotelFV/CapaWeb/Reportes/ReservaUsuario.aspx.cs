using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaProceso.Clases;

namespace CapaWeb.Reportes
{
    public partial class ReservaUsuario : System.Web.UI.Page
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


                    break;

                case "DLT":

                    break;
                case "FAC":
                    break;

            }

            // string Id = "Id".ToString();
            string Id = (qs["Id"]);
            ObjectDataSource1.SelectParameters.Add("Id", Id);
        }

        public QSencriptadoCSharp.QueryString ulrDesencriptada()
        {
            //1- guardo el Querystring encriptado que viene desde el request en mi objeto
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString(Request.QueryString);

            ////2- Descencripto y de esta manera obtengo un array Clave/Valor normal
            qs = QSencriptadoCSharp.Encryption.DecryptQueryString(qs);
            return qs;
        }
        protected void imgEliminar_Click(object sender, EventArgs e)
        {

            Response.Redirect("ReporteReservaFil.aspx");
        }
    }
}