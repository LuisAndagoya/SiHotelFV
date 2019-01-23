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
        public List<ModeloReservacionDetalle> modeloReservacionDetalle;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            DateTime maniana = hoy.AddDays(1);
            
            fechaEntrada.Text = DateTime.Today.ToString("yyyy-MM-dd");
            fechaReservacion.Text = DateTime.Today.ToString("yyyy-MM-dd");
            fechaSalida.Text = maniana.ToString("yyyy-MM-dd");
            totalReservacion.Text = "0";
            CargarCombo();
           

        }
        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter

                /*
                ListaCliente.DataSource = CapaProceso.Clases.Cliente.Lista();
                ListaCliente.DataTextField = "dniCliente";
                ListaCliente.DataValueField = "idCliente";
                ListaCliente.DataBind();
                */

                /*ListaEstado.DataSource = CapaProceso.Clases.EstadoReserva.Lista();
                ListaEstado.DataTextField = "nombreEstado";
                ListaEstado.DataValueField = "idEstadoReserva";
                ListaEstado.DataBind();*/

                ListaHabitacion.AppendDataBoundItems = true;
                ListaHabitacion.Items.Add("Seleccione habitación...");

                ListaHabitacion.DataSource = CapaProceso.Clases.Habitacion.Lista();

                ListaHabitacion.DataTextField = "numeroHabitacion";
                ListaHabitacion.DataValueField = "numeroHabitacion";                
                ListaHabitacion.DataBind();              

            }

        }
        
       
        protected void Grid_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            float pago = float.Parse(PagadoReserva.Text);
            float total = float.Parse(totalReservacion.Text);
            float saldo = 0;
            float total1 = 0;

            total1 = total - float.Parse(((Label)e.Item.Cells[2].FindControl("valor")).Text);

            saldo = total1 - pago;

            SaldoReserva.Text = saldo.ToString();
            totalReservacion.Text = total.ToString();

            modeloReservacionDetalle = (Session["datos"] as List<ModeloReservacionDetalle>);
            modeloReservacionDetalle.RemoveAt(e.Item.ItemIndex);
            Session["datos"] = modeloReservacionDetalle;
            modeloReservacionDetalle = (Session["datos"] as List<ModeloReservacionDetalle>);
            Grid.DataSource = modeloReservacionDetalle;
            Grid.DataBind();

        }


        public void InsertarDetalle()
        {
            if (ListaHabitacion.SelectedValue.ToString() != "Seleccione habitación...")
            {
                float pago = float.Parse(PagadoReserva.Text);
                float total = float.Parse(totalReservacion.Text);
                float saldo = 0;

                total += float.Parse(valor.Text);

                saldo = total - pago;

                SaldoReserva.Text = saldo.ToString();
                totalReservacion.Text = total.ToString();

                ModeloReservacionDetalle item = new ModeloReservacionDetalle(int.Parse(ListaHabitacion.SelectedValue.ToString()), float.Parse(valor.Text));

            if (Session["datos"] == null) {
                modeloReservacionDetalle = new List<ModeloReservacionDetalle>();
                modeloReservacionDetalle.Add(item);
                Session["datos"] = modeloReservacionDetalle;
            }
            else
            {
                modeloReservacionDetalle = (Session["datos"] as List<ModeloReservacionDetalle>);
                modeloReservacionDetalle.Add(item);
            }

            Grid.DataSource = modeloReservacionDetalle;
            Grid.DataBind();


              
                ListaHabitacion.SelectedValue = "Seleccione habitación...";
                valor.Text = "0";
            }
            else
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Seleccione la habitacion');</script>");
            }


        } 
       


        public void Guardar()
        {
            /* Inserto la cabecera de la reservación */
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());           
            ReservaGuardar reservaGuardar = new ReservaGuardar();           
            //reservaGuardar.idCliente = int.Parse(ListaCliente.SelectedValue.ToString());
            reservaGuardar.idUsuario = UsuarioId;
            reservaGuardar.fechaReservacion = fechaReservacion.Text;
            reservaGuardar.fechaEntrada = fechaEntrada.Text;
            reservaGuardar.fechaSalida = fechaSalida.Text;
            //reservaGuardar.idEstadoReserva = int.Parse(ListaEstado.SelectedValue);
            reservaGuardar.totalReservacion = float.Parse( totalReservacion.Text);
            reservaGuardar.SaldoReserva = decimal.Parse(SaldoReserva.Text);
            reservaGuardar.PagadoReserva = decimal.Parse(PagadoReserva.Text);

            CapaProceso.Clases.Reserva.Insertar(reservaGuardar);           
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            // Guardar();
            //modeloReservacionDetalle;
            /*foreach (var item in modeloReservacionDetalle)
            {
               
            }*/

        }
        protected void Button2_Click(object sender, EventArgs e)
        {            InsertarDetalle();

        }

        protected void dniCliente_TextChanged(object sender, EventArgs e)
        {
            int error = 0;
               
            if (dniCliente.Text!= "")
            {
                CapaDatos.Clases.Cliente.clienteDataTable DataTable = CapaProceso.Clases.Cliente.BuscarCi(dniCliente.Text);

               
                    foreach (DataRow row in DataTable.Rows)
                    {
                        nombreCliente.Text = row["nombreCliente"].ToString();
                        apellidoCliente.Text = row["apellidoCliente"].ToString();
                        idCliente.Text = row["idCliente"].ToString();
                    error++;
                    }
                if (error == 0)
                {
                    nombreCliente.Text = "";
                    apellidoCliente.Text = "";
                    idCliente.Text = "";
                    dniCliente.Text = "";
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('No existe el cliente');</script>");
                }
              
            }
            else
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Ingrese el cliente');</script>");
                nombreCliente.Text = "";
                apellidoCliente.Text = "";
                idCliente.Text = "";
                dniCliente.Text = "";
            }

        }

        protected void PagadoReserva_TextChanged(object sender, EventArgs e)
        {
            float pago = float.Parse(PagadoReserva.Text);
            float total = float.Parse(totalReservacion.Text);
            float saldo = 0;
            saldo = total - pago;
            SaldoReserva.Text = saldo.ToString();
        }

        protected void ListaHabitacion_TextChanged(object sender, EventArgs e)
        {
            if (ListaHabitacion.SelectedValue.ToString() != "Seleccione habitación...")
            {

                CapaDatos.Clases.Habitacion.habitacionDataTable DataTable = CapaProceso.Clases.Habitacion.BuscarPrecio(short.Parse(ListaHabitacion.SelectedValue.ToString()));


            foreach (DataRow row in DataTable.Rows)
            {
                
                valor.Text = row["precioHabitacion"].ToString(); ;
                }
            }
            else
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Seleccione la habitacion');</script>");
            }

        }
    }
}