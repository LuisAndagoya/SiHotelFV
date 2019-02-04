﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ver.aspx.cs" Inherits="CapaWeb.Formularios.Empleado.Ver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">EMPLEADO</h4>

                <form id="form1" class="forms-sample" runat="server" name="form1" >
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>


                     <div class="form-group">
                        <label for="dniEmpleado">Cédula</label>
                       <asp:TextBox ID="dniEmpleado"   class="form-control" pattern="^[0-9]{10}$"   required ="required"  runat="server"></asp:TextBox>
                    </div>
         
    
                       <div class="form-group">
                        <label for="nombreEmpleado">Nombre</label>
                       <asp:TextBox ID="nombreEmpleado"  class="form-control"  pattern="^[\ s A-z ]*$" required ="required"  runat="server"></asp:TextBox>
                    </div>
                

                    
                       <div class="form-group">
                        <label for="apellidoEmpleado">Apellido</label>
                       <asp:TextBox ID="apellidoEmpleado" class="form-control"  pattern="^[\ s A-z ]*$"  required ="required"  runat="server"></asp:TextBox>
                    </div>
             
                      
                      <div class="form-group">
                        <label for="fnacimiento">Fecha Nacimiento</label>
                        <asp:TextBox type="date" ID="fnacimiento" class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>
                
                  
                      <div class="form-group">
                        <label for="sexoEmpleadoo">Sexo</label>
                          <asp:DropDownList ID="sexoEmpleado"  class="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="M">MASCULINO</asp:ListItem>
                          <asp:ListItem Value="F">FEMENINO</asp:ListItem>
                      </asp:DropDownList>
                    </div>


                      <div class="form-group">
                        <label for="estadocivilEmpleado">Estado civil</label>
                              <asp:DropDownList ID="estadocivilEmpleado" class="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="CASADO">CASADO</asp:ListItem>
                          <asp:ListItem Value="DIVORCIADO">DIVORCIADO</asp:ListItem>
                           <asp:ListItem Value="SOLTERO">SOLTERO</asp:ListItem>
                           <asp:ListItem Value="UNION LIBRE">UNION LIBRE</asp:ListItem>
                      </asp:DropDownList>
                    </div>

             
                    <div class="form-group">
                        <label for="domicilioEmpleado">Domicilio</label>
                           <asp:TextBox ID="domicilioEmpleado"  class="form-control"  required ="required"  runat="server"></asp:TextBox>   
                    </div>
                  
                      <div class="form-group">
                        <label for="telefmovilEmpleado">Celular</label>
                        <asp:TextBox ID="telefmovilEmpleado" class="form-control"  pattern="^[0-9]{10}$" placeholder="Ejm: 0992333333" required ="required"  runat="server"></asp:TextBox>   
                    </div>


                      <div class="form-group">
                        <label for="fecharegistroEmpleado">Fecha registro</label>
                        <asp:TextBox Type="date" ID="fecharegistroEmpleado"   class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>

                       <div class="form-group">
                        <label for="emailEmpleado">Email</label>
                         <asp:TextBox ID="emailEmpleado"  type="email" class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                            <label for="imagenEmpleadoss">Imagen</label>
                            <asp:Image ID="imagenEmpleado" runat="server"  class="form-control" ImageUrl='<%# Eval("imagenEmpleado", "imagen.ashx?id={0}") %>' Width="200px" Height="200px"  />   
                    </div>



                    <div class="form-group">
                        <label for="estadoEmpleado">Estado</label>
                          <asp:DropDownList ID="estadoEmpleado"  class="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                          <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                      </asp:DropDownList>
                    </div>


                  
                      <a href="Index.aspx" class="btn btn-light">Salir</a>
                
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
               </form>
            </div>
        </div>
    </div>
</asp:Content>