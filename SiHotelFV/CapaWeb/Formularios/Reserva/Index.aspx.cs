using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaProceso.Clases;

namespace CapaWeb.Formularios.Reserva
{
    public partial class Index : System.Web.UI.Page
    {

        private static Codificar codificar = new Codificar(); // Clase para emcriptar
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CargarGrilla();
            }
        }

        private void CargarGrilla()
        {
            Grid.DataSource = CapaProceso.Clases.Reserva.GetListaReserva();



            Grid.DataBind();
            Grid.Height = 100;


        }
        protected void Grid_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            QSencriptadoCSharp.QueryString qs = new QSencriptadoCSharp.QueryString();
            short Id;
            short idEstadoReserva;

            switch (e.CommandName) //ultilizo la variable para la opcion
            {
                                         
                case "Eliminar": //ejecuta el codigo si el usuario ingresa el numero 2
                    Id = short.Parse(((Label)e.Item.Cells[1].FindControl("LblId")).Text);
                    idEstadoReserva = short.Parse(((Label)e.Item.Cells[1].FindControl("idEstadoReserva")).Text);
                    if (idEstadoReserva == 1)
                   {
                        CapaProceso.Clases.Reserva.ActualizarEstado(Id, 4);
                        Grid.DataSource = CapaProceso.Clases.Reserva.GetListaReserva();
                        Grid.DataBind();
                        Grid.Height = 100;
                    }
                    else
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('Solo se puede anular rervas en estado reservado');</script>");
                    }
                   
                    break;

                case "Estado": //ejecuta el codigo si el usuario ingresa el numero 2
                    Id = short.Parse(((Label)e.Item.Cells[1].FindControl("LblId")).Text);
                    idEstadoReserva = short.Parse(((Label)e.Item.Cells[1].FindControl("idEstadoReserva")).Text);
                    CapaDatos.Clases.DetalleReserva.detalle_reservaDataTable detalle = CapaProceso.Clases.DetalleReserva.Detalle(Id);

                    switch (idEstadoReserva)
                    {
                        case 1:
                            CapaProceso.Clases.Reserva.ActualizarEstado(Id, 2);
                            Grid.DataSource = CapaProceso.Clases.Reserva.GetListaReserva();
                            Grid.DataBind();
                            Grid.Height = 100;
                            
                            foreach (var item in detalle)
                            {
                                CapaProceso.Clases.Habitacion.ActualizarEstado((short) item.numeroHabitacion, 2);
                            }
                           
                            break;
                        case 2:
                            CapaProceso.Clases.Reserva.ActualizarEstado(Id, 3);
                            Grid.DataSource = CapaProceso.Clases.Reserva.GetListaReserva();
                            Grid.DataBind();
                            Grid.Height = 100;
                            foreach (var item in detalle)
                            {
                                CapaProceso.Clases.Habitacion.ActualizarEstado((short)item.numeroHabitacion, 3);
                            }
                            break;
                        case 3:
                            CapaProceso.Clases.Reserva.ActualizarEstado(Id, 4);
                            Grid.DataSource = CapaProceso.Clases.Reserva.GetListaReserva();
                            Grid.DataBind();
                            Grid.Height = 100;
                            foreach (var item in detalle)
                            {
                                CapaProceso.Clases.Habitacion.ActualizarEstado((short)item.numeroHabitacion, 4);
                            }
                            break;
                        case 4:
                            this.Page.Response.Write("<script language='JavaScript'>window.alert('La reserva ya se encuentra cerrada');</script>");
                            break;
                    }

                    break;
                case "Factura": 
                    Id = short.Parse(((Label)e.Item.Cells[1].FindControl("LblId")).Text);

                    //2 voy a agregando los valores que deseo
                    qs.Add("TRN", "FAC");
                    qs.Add("Id", Id.ToString());

                    Response.Redirect("../../Reportes/Factura.aspx" + QSencriptadoCSharp.Encryption.EncryptQueryString(qs).ToString());
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
            Grid.DataSource = CapaProceso.Clases.Reserva.Buscar(TxtBuscar.Text);

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