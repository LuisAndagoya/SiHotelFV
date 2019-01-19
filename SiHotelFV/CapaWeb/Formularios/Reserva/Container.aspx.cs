﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaProceso.Clases;

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

                List<ModeloReservacionDetalle> modeloReservacionDetalle = new List<ModeloReservacionDetalle>();

            }

        }


        public void InsertarDetalle()
        {
            ModeloReservacionDetalle item = new ModeloReservacionDetalle();
            item.idReserva = int.Parse(lblId.Text);
            item.fechaActual = DateTime.Today.ToString();
            item.numeroHabitacion = int.Parse(ListaHabitacion.SelectedValue.ToString()); /* aqui vinen del compo numero de abitacion*/
            item.valor = float.Parse(valor.Text); /* aqui va el valor de la abitación que se swelecione*/
            modeloReservacionDetalle.Add(item);

            GridView1.DataSource = null;
            GridView1.DataSource = modeloReservacionDetalle;
           /* ModeloReservacionDetalle detalleGuardar = new ModeloReservacionDetalle();

            detalleGuardar.idReserva = int.Parse(lblId.Text);
            detalleGuardar.numeroHabitacion = int.Parse(ListaHabitacion.SelectedValue.ToString());
            detalleGuardar.fechaActual = DateTime.Today.ToString();
            detalleGuardar.valor = float.Parse(valor.Text);
            CapaProceso.Clases.DetalleReserva.Insertar(detalleGuardar);*/
        } 
       


        public void Guardar()
        {
            short UsuarioId = short.Parse(Session["UsuarioId"].ToString());
           
            ReservaGuardar reservaGuardar = new ReservaGuardar();
            //reservaGuardar.idReservacion = int.Parse(lblId.Text);
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
        {
            InsertarDetalle();

        }
    }
}