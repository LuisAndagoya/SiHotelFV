using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaProceso.Clases;

namespace CapaWeb.Formularios.Habitacion
{
    public partial class Index : System.Web.UI.Page
    {
        private static Codificar codificar = new Codificar(); // Clase para emcriptar
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!CapaProceso.Clases.Menucargo.ExisteMenu("Habitación", int.Parse(Session["idCargo"].ToString())))
                {
                    Response.Redirect("../../Index.aspx");
                }


                CargarGrilla();
            }

        }

        private void CargarGrilla()
        {
            Grid.DataSource = CapaProceso.Clases.Habitacion.Lista();



            Grid.DataBind();
            Grid.Height = 100;


        }

        protected void Grid_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            //1 primero creo un objeto Clave/Valor de QueryString 
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();

            int Id;

            switch (e.CommandName) //ultilizo la variable para la opcion
            {

                case "Editar": //ejecuta el codigo si el usuario ingresa el numero 1
                    Id = Convert.ToInt32(((Label)e.Item.Cells[1].FindControl("LblId")).Text);

                    //2 voy a agregando los valores que deseo
                    qs.Add("TRN", "UDP");
                    qs.Add("Id", Id.ToString());

                    Response.Redirect("Container.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());
                    break;//termina la ejecucion del programa despues de ejecutar el codigo

                case "Eliminar": //ejecuta el codigo si el usuario ingresa el numero 2
                    Id = Convert.ToInt32(((Label)e.Item.Cells[1].FindControl("LblId")).Text);

                    //2 voy a agregando los valores que deseo
                    qs.Add("TRN", "DLT");
                    qs.Add("Id", Id.ToString());

                    Response.Redirect("Container.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());
                    break;
                case "Ver": //ejecuta el codigo si el usuario ingresa el numero 2
                    Id = Convert.ToInt32(((Label)e.Item.Cells[1].FindControl("LblId")).Text);

                    //2 voy a agregando los valores que deseo
                    qs.Add("TRN", "VER");
                    qs.Add("Id", Id.ToString());

                    Response.Redirect("Ver.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());
                    break;
            }
        }


        protected void Grid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            // paginar la grilla asegurarse que la obcion que la propiedad AllowPaging sea True.
            Grid.CurrentPageIndex = 0;
            Grid.CurrentPageIndex = e.NewPageIndex;
            CargarGrilla();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            short Id = short.Parse(TxtBuscar.Text);
            Grid.DataSource = CapaProceso.Clases.Habitacion.Buscar(Id);

            Grid.DataBind();
            Grid.Height = 100;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //1 primero creo un objeto Clave/Valor de QueryString 
            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();

            //2 voy a agregando los valores que deseo
            qs.Add("TRN", "INS");
            qs.Add("Id", "");
            Response.Redirect("Container.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());
        }
    }
}