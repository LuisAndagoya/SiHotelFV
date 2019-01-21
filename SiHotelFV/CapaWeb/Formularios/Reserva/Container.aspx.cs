using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;
using System.IO;

namespace CapaWeb.Formularios.Reserva
{
    public partial class Container : System.Web.UI.Page
    {
        public List<ModeloReservacionDetalle> modeloReservacionDetalle = new List<ModeloReservacionDetalle>();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCombo();

        }
        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter


                ListaCliente.DataSource = CapaProceso.Clases.Cliente.Lista();
                ListaCliente.DataTextField = "dniCliente";
                ListaCliente.DataValueField = "idCliente";
                ListaCliente.DataBind();

                ListaEstado.DataSource = CapaProceso.Clases.EstadoReserva.Lista();
                ListaEstado.DataTextField = "nombreEstado";
                ListaEstado.DataValueField = "idEstadoReserva";
                ListaEstado.DataBind();


                ListaHabitacion.DataSource = CapaProceso.Clases.Habitacion.Lista();
                ListaHabitacion.DataTextField = "numeroHabitacion";
                ListaHabitacion.DataValueField = "numeroHabitacion";
                ListaHabitacion.DataBind();              

            }

        }
        
       
        protected void Grid_ItemCommand(object source, DataGridCommandEventArgs e)
        {
           
        }


        public void InsertarDetalle()
        {
            ModeloReservacionDetalle item = new ModeloReservacionDetalle(int.Parse(ListaHabitacion.SelectedValue.ToString()), float.Parse(valor.Text));
                       
           
            
            modeloReservacionDetalle.Add(item);

            GridView1.DataSource = null;
            GridView1.DataSource = modeloReservacionDetalle;


        } 
       


        public void Guardar()
        {
            /* Inserto la cabecera de la reservación */
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());           
            ReservaGuardar reservaGuardar = new ReservaGuardar();           
            reservaGuardar.idCliente = int.Parse(ListaCliente.SelectedValue.ToString());
            reservaGuardar.idUsuario = UsuarioId;
            reservaGuardar.fechaReservacion = fechaReservacion.Text;
            reservaGuardar.fechaEntrada = fechaEntrada.Text;
            reservaGuardar.fechaSalida = fechaSalida.Text;
            reservaGuardar.idEstadoReserva = int.Parse(ListaEstado.SelectedValue);
            reservaGuardar.totalReservacion = float.Parse( totalReservacion.Text);
            reservaGuardar.SaldoReserva = decimal.Parse(SaldoReserva.Text);
            reservaGuardar.PagadoReserva = decimal.Parse(PagadoReserva.Text);

            CapaProceso.Clases.Reserva.Insertar(reservaGuardar);           
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Guardar();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {            InsertarDetalle();

        }
    }
}