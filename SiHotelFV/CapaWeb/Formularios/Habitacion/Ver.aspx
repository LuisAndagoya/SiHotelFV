﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ver.aspx.cs" Inherits="CapaWeb.Formularios.Habitacion.Ver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">HABITACIÓN</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
         
                    <div class="form-group">
                        <label for="numeroHabitacion">N° Habitación</label>
                        <asp:TextBox ID="numeroHabitacion" class="form-control" type="number" required ="required" runat="server"></asp:TextBox>
                        
                    </div>


                    <div class="form-group">
                        <label for="ListaTipo">Tipo Habitación</label>
                       <asp:DropDownList ID="ListaTipo" required ="required" class="form-control" runat="server">
                      </asp:DropDownList>
                    </div>
            
                  
                 

                   <div class="form-group">
                        <label for="ListaHotel">Hotel</label>
                         <asp:DropDownList ID="ListaHotel" required ="required" class="form-control" runat="server">
                      </asp:DropDownList>
                    </div>


                    
                        <div class="form-group">
                            <label for="imagenEmpleado">Imagen</label>
                            <asp:Image ID="imagenTipo" runat="server"  class="form-control" ImageUrl='<%# Eval("imagenTipo", "imagen.ashx?id={0}") %>' Width="400px" Height="200px"  />   
                    </div>
                  
                      <div class="form-group">
                        <label for="ListaEstado">Estado</label>
                         <asp:DropDownList ID="ListaEstado" required ="required" class="form-control" runat="server">
                      </asp:DropDownList>
                    </div>
                      
   
                      
                      <a href="Index.aspx" class="btn btn-light">Salir</a>
 
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>

              </form>
            </div>
        </div>
    </div>
</asp:Content>