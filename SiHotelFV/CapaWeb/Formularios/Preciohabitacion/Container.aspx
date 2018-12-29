﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Preciohabitacion.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">PRECIO HABITACIÓN</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
   
                     <div class="form-group">
                        <label for="precioHabitacion">Precio</label>
                        <asp:TextBox ID="precioHabitacion"  type="number" step="0.01" class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>
                      

                     <div class="form-group">
                        <label for="precioHabitacion">Fecha</label>
                        
                         <asp:TextBox type="date" ID="fechaPrecio"  class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>
                  

                       <div class="form-group">
                        <label for="estadoEmpleado">Estado</label>
                          <asp:DropDownList ID="estadoPrecio"  class="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                          <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                      </asp:DropDownList>
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