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
            
            CargarCombo();
           

        }
        protected void CargarCombo()
        {
            if (!IsPostBack)
            {
                //Llenar un combo box dinamicamente con tabla adapter

                
                idEstadoReserva.DataSource = CapaProceso.Clases.EstadoReserva.GetEstadoReserva12();
                idEstadoReserva.DataTextField = "nombreEstado";
                idEstadoReserva.DataValueField = "idEstadoReserva";
                idEstadoReserva.DataBind();

                ListaHabitacion.AppendDataBoundItems = true;
                ListaHabitacion.Items.Add("Seleccione habitación...");

                ListaHabitacion.DataSource = CapaProceso.Clases.Habitacion.Lista();

                ListaHabitacion.DataTextField = "numeroHabitacion";
                ListaHabitacion.DataValueField = "numeroHabitacion";                
                ListaHabitacion.DataBind();

                Session.Remove("total");
                Session.Remove("datos");
                Session["total"] = 0;

                DateTime hoy = DateTime.Today;
                DateTime maniana = hoy.AddDays(1);

                fechaEntrada.Text = DateTime.Today.ToString("yyyy-MM-dd");
                fechaReservacion.Text = DateTime.Today.ToString("yyyy-MM-dd");
                fechaSalida.Text = maniana.ToString("yyyy-MM-dd");
                totalReservacion.Text = "0";
            }

        }
        
       
        protected void Grid_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            Decimal pago = Math.Round(Decimal.Parse(PagadoReserva.Text.Replace(".",",")),2);
            Decimal total = Math.Round(Decimal.Parse(Session["total"].ToString()),2);
            Decimal saldo = 0;          
            
            total = Math.Round(total - Decimal.Parse(((Label)e.Item.Cells[2].FindControl("valor")).Text), 2);

            saldo = Math.Round(total - pago,2);

            SaldoReserva.Text = saldo.ToString();
            totalReservacion.Text = total.ToString();
            Session["total"] = total;

            modeloReservacionDetalle = (Session["datos"] as List<ModeloReservacionDetalle>);
            modeloReservacionDetalle.RemoveAt(e.Item.ItemIndex);
            Session["datos"] = modeloReservacionDetalle;
            modeloReservacionDetalle = (Session["datos"] as List<ModeloReservacionDetalle>);
            Grid.DataSource = modeloReservacionDetalle;
            Grid.DataBind();

        }


        public void InsertarDetalle()
        {
            bool existe = false;
            string Tipo = "";
                       
                if (ListaHabitacion.SelectedValue.ToString() != "Seleccione habitación...")
                {
                CapaDatos.Clases.Habitacion.habitacionDataTable DataTable = CapaProceso.Clases.Habitacion.BuscarPrecio(short.Parse(ListaHabitacion.SelectedValue.ToString()));


                foreach (DataRow row in DataTable.Rows)
                {

                    Tipo = row["nombreTipo"].ToString();
                }

                if (Session["datos"] == null)
                {
                    ModeloReservacionDetalle item = new ModeloReservacionDetalle(int.Parse(ListaHabitacion.SelectedValue.ToString()), Decimal.Parse(valor.Text.Replace(".", ",")), Tipo);
                    modeloReservacionDetalle = new List<ModeloReservacionDetalle>();
                    modeloReservacionDetalle.Add(item);
                    Session["datos"] = modeloReservacionDetalle;

                    Decimal pago = Math.Round(Decimal.Parse(PagadoReserva.Text.Replace(".", ",")), 2);
                    Decimal total = Math.Round(Decimal.Parse(Session["total"].ToString()), 2);
                    Decimal saldo = 0;

                    total = Math.Round(Decimal.Parse(valor.Text.Replace(".", ",")) + total, 2);

                    Session["total"] = total;

                    saldo = Math.Round(total - pago, 2);

                    SaldoReserva.Text = saldo.ToString();
                    totalReservacion.Text = total.ToString();
                }
                else
                {
                    modeloReservacionDetalle = (Session["datos"] as List<ModeloReservacionDetalle>);

                    foreach (var item1 in modeloReservacionDetalle)
                    {
                        if (item1.numeroHabitacion == int.Parse(ListaHabitacion.SelectedValue.ToString()))
                        {
                            existe = true;

                        }
                    }

                    if (!existe)
                    {
                        ModeloReservacionDetalle item = new ModeloReservacionDetalle(int.Parse(ListaHabitacion.SelectedValue.ToString()), Decimal.Parse(valor.Text.Replace(".", ",")), Tipo);
                        
                        modeloReservacionDetalle.Add(item);

                        Decimal pago = Math.Round(Decimal.Parse(PagadoReserva.Text.Replace(".", ",")), 2);
                        Decimal total = Math.Round(Decimal.Parse(Session["total"].ToString()), 2);
                        Decimal saldo = 0;

                        total = Math.Round(Decimal.Parse(valor.Text.Replace(".", ",")) + total, 2);

                        Session["total"] = total;

                        saldo = Math.Round(total - pago,2);

                        SaldoReserva.Text = saldo.ToString();
                        totalReservacion.Text = total.ToString();

                    }
                    else
                            {
                                ListaHabitacion.SelectedValue = "Seleccione habitación...";
                                valor.Text = "0";
                                Decimal total = Math.Round(Decimal.Parse(Session["total"].ToString()), 2);
                                totalReservacion.Text = total.ToString();
                            this.Page.Response.Write("<script language='JavaScript'>window.alert('La habitación ya fue agregada');</script>");
                        }


                    }   
           

                    Grid.DataSource = modeloReservacionDetalle;
                    Grid.DataBind();



                    ListaHabitacion.SelectedValue = "Seleccione habitación...";
                    valor.Text = "0";
                }
                else
                {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('Seleccione la habitación');</script>");
                }
            

           


        } 

              


        public void Guardar()
        {
            /* Inserto la cabecera de la reservación */
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());           
            ReservaGuardar reservaGuardar = new ReservaGuardar();           
            reservaGuardar.idCliente = int.Parse(idCliente.Text);
            reservaGuardar.idUsuario = UsuarioId;
            reservaGuardar.fechaReservacion = fechaReservacion.Text;
            reservaGuardar.fechaEntrada = fechaEntrada.Text;
            reservaGuardar.fechaSalida = fechaSalida.Text;
            reservaGuardar.idEstadoReserva = int.Parse(idEstadoReserva.SelectedValue);
            reservaGuardar.totalReservacion = Decimal.Parse(Session["total"].ToString());
            reservaGuardar.SaldoReserva = Decimal.Parse(SaldoReserva.Text.Replace(".", ","));
            reservaGuardar.PagadoReserva = Decimal.Parse(PagadoReserva.Text.Replace(".", ","));
            CapaProceso.Clases.Reserva.Insertar(reservaGuardar);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
               
            {
                DateTime fechaReserva = DateTime.Parse(fechaReservacion.Text);
                DateTime fechaSalid = DateTime.Parse(fechaSalida.Text);
                DateTime hoy = DateTime.Today;
                
                
                if (DateTime.Compare(fechaReserva, hoy) < 0)
                    {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('La fecha no puede ser menor a la actua');</script>");
                }
                else
                {                  

                    if (DateTime.Compare(fechaSalid, fechaReserva) < 0)
                    {
                        this.Page.Response.Write("<script language='JavaScript'>window.alert('La fecha de reserva no puede ser mayor que la de salida');</script>");
                    }
                    else
                    {                        
                        if ( Decimal.Parse(SaldoReserva.Text.Replace(".",",")) < 0)
                        {
                            this.Page.Response.Write("<script language='JavaScript'>window.alert('El pago no puede ser mayor que la reserva');</script>");

                        }
                        else
                        {
                           
                            modeloReservacionDetalle = (Session["datos"] as List<ModeloReservacionDetalle>);
                            if (modeloReservacionDetalle.Count > 0)
                            {
                                Guardar();
                                short IdReserva = CapaProceso.Clases.Reserva.IdReserva();

                                foreach (var item in modeloReservacionDetalle)
                                {
                                    DetalleReserva.Insertar(IdReserva, fechaReservacion.Text, item);
                                    if (int.Parse(idEstadoReserva.SelectedValue) == 2)
                                    {                                        
                                        CapaProceso.Clases.Habitacion.ActualizarEstado(short.Parse(item.numeroHabitacion.ToString()), 2);
                                       
                                    }
                                }

                                enviar();
                                Session.Remove("total");
                                Session.Remove("datos");

                                Response.Redirect("Index.aspx");
                            }
                            else
                            {
                                this.Page.Response.Write("<script language='JavaScript'>window.alert('Ingrese el detalle de la raserva');</script>");
                            }
                        }

                    }
                }


            }
            catch (Exception)
            {

                this.Page.Response.Write("<script language='JavaScript'>window.alert('Error al guardar');</script>");
            }         
           


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
                if (Session["total"] != null)
                {
                    Decimal total = Decimal.Parse(Session["total"].ToString());
                    totalReservacion.Text = total.ToString();
                }
               

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
            Decimal pago = Math.Round(Decimal.Parse(PagadoReserva.Text.Replace(".", ",")), 2);
            Decimal total = Math.Round(Decimal.Parse(Session["total"].ToString()), 2);
            Decimal saldo = 0;
            saldo = Math.Round(total - pago, 2);
            SaldoReserva.Text = saldo.ToString();
        }

        protected void ListaHabitacion_TextChanged(object sender, EventArgs e)
        {
            Decimal total = Math.Round(Decimal.Parse(Session["total"].ToString()), 2);            
            totalReservacion.Text = total.ToString();

            if (ListaHabitacion.SelectedValue.ToString() != "Seleccione habitación...")
            {
               
                CapaDatos.Clases.Habitacion.habitacionDataTable DataTable = CapaProceso.Clases.Habitacion.BuscarPrecio(short.Parse(ListaHabitacion.SelectedValue.ToString()));


            foreach (DataRow row in DataTable.Rows)
            {
                
                valor.Text = row["precioHabitacion"].ToString();
                }
            }
            else
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Seleccione la habitacion');</script>");
            }

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Session.Remove("total");
            Session.Remove("datos");

            Response.Redirect("Index.aspx");
        }

        protected void GuardarCliente(object sender, EventArgs e)
        {
                string error = "";
                short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
                error = CapaProceso.Clases.Cliente.Insertar(dniClienteM.Text, nombreClienteM.Text, apellidoClienteM.Text, sexoCliente.Text, direccionCliente.Text, telefonoCliente.Text, correoCliente.Text, estadoCliente.Text);

                if (string.IsNullOrEmpty(error))
                {

                    CapaProceso.Clases.Auditoria.Insertar("Cliente", "Insertar", UsuarioId);
                dniClienteM.Text = "";
                nombreClienteM.Text = "";
                apellidoClienteM.Text = "";
                sexoCliente.Text = "";
                direccionCliente.Text = "";
                telefonoCliente.Text = "";
                correoCliente.Text = "";
                estadoCliente.Text = "";
                }
                else
                {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + error + "');</script>");
                }
           
        }


        public void enviar()
        {
            CapaDatos.Clases.Cliente.clienteDataTable DataTable = CapaProceso.Clases.Cliente.ClienteId(short.Parse(idCliente.Text));

            int contar = 0;

            foreach (DataRow row in DataTable.Rows)
            {
                contar++;
            }

            if (contar > 0)
            {
                Email email = new Email();
                string nombre = "";
                string apellido = "";
                string correo = "";
               
                foreach (DataRow row in DataTable.Rows)
                {
                    nombre = row["apellidoCliente"].ToString();
                    apellido = row["nombreCliente"].ToString();
                    correo = row["correoCliente"].ToString();                   

                }

               
                String mensaje = "<strong> Estimado(a): </strong>" + apellido.ToUpper() + " " + nombre.ToUpper() + "<br/>" + "Su reserva a sido confrimada para el dia " + fechaReservacion.Text;
                email.enviarcorreo("Confirmación de reservación", mensaje, correo);
               
            }
        }


    }
}