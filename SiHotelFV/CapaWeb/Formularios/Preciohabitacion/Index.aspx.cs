using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb.Formularios.Preciohabitacion
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CargarGrilla();
            }
        }



        private void CargarGrilla()
        {
            Grid.DataSource = CapaProceso.Clases.PrecioHabitacion.Lista();



            Grid.DataBind();
            Grid.Height = 100;


        }


        protected void Grid_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            int Id;
            switch (e.CommandName) //ultilizo la variable para la opcion
            {

                case "Editar": //ejecuta el codigo si el usuario ingresa el numero 1
                    Id = Convert.ToInt32(((Label)e.Item.Cells[1].FindControl("LblId")).Text);
                    Response.Redirect("Container.aspx?TRN=UDP&Id=" + Id.ToString());
                    break;//termina la ejecucion del programa despues de ejecutar el codigo
                case "Eliminar": //ejecuta el codigo si el usuario ingresa el numero 2
                    Id = Convert.ToInt32(((Label)e.Item.Cells[1].FindControl("LblId")).Text);
                    Response.Redirect("Container.aspx?TRN=DLT&Id=" + Id.ToString());
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
            Grid.DataSource = CapaProceso.Clases.PrecioHabitacion.Buscar(TxtBuscar.Text);

            Grid.DataBind();
            Grid.Height = 100;

        }


    }
}