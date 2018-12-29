﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Estadohabitacion.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">ESTADO HABITACIÓN</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
   
                     <div class="form-group">
                        <label for="nombreCargo">Estado</label>
                        <asp:TextBox ID="nombreEstadoHabitacion"   class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>
                      
                 
                     
           
                      <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx"  class="btn btn-light">Cancelar</a>
  
    
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
      </form>
            </div>
        </div>
    </div>


</asp:Content>