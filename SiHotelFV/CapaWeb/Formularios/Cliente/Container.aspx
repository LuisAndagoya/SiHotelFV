<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Cliente.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <script type="text/javascript" src="../Empleado/ValidarCedula.js"></script>
  <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">CLIENTE</h4>

                <form id="form1" class="forms-sample" runat="server" name="form1" >
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>


                     <div class="form-group">
                        <label for="dniCliente">Cédula</label>
                       <asp:TextBox ID="dniCliente"   class="form-control" pattern="^[0-9]{10}$"   required ="required"  runat="server"></asp:TextBox>
                    </div>
         
    
                       <div class="form-group">
                        <label for="nombreCliente">Nombre</label>
                       <asp:TextBox ID="nombreCliente"  class="form-control"  pattern="^[\ s A-z ]*$" required ="required"  runat="server"></asp:TextBox>
                    </div>
                

                    
                       <div class="form-group">
                        <label for="apellidoCliente">Apellido</label>
                       <asp:TextBox ID="apellidoCliente" class="form-control"  pattern="^[\ s A-z ]*$"  required ="required"  runat="server"></asp:TextBox>
                    </div>
             
                      
                                
                  
                      <div class="form-group">
                        <label for="sexoCliente">Sexo</label>
                          <asp:DropDownList ID="sexoCliente"  class="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="M">MASCULINO</asp:ListItem>
                          <asp:ListItem Value="F">FEMENINO</asp:ListItem>
                      </asp:DropDownList>
                    </div>



             
                    <div class="form-group">
                        <label for="direccionCliente">Dirección</label>
                           <asp:TextBox ID="direccionCliente"  class="form-control"  required ="required"  runat="server"></asp:TextBox>   
                    </div>
                  
                      <div class="form-group">
                        <label for="telefonoCliente">Teléfono</label>
                        <asp:TextBox ID="telefonoCliente" class="form-control"  pattern="^[0-9]{10}$" placeholder="Ejm: 0992333333" required ="required"  runat="server"></asp:TextBox>   
                    </div>


                  
                       <div class="form-group">
                        <label for="correoCliente">Email</label>
                         <asp:TextBox ID="correoCliente"  type="email" class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>



                    
                      <div class="form-group">
                        <label for="estadoCliente">Estado civil</label>
                              <asp:DropDownList ID="estadoCliente" class="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                          <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                           
                      </asp:DropDownList>
                    </div>

                      <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx" class="btn btn-light">Cancelar</a>
                
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
               </form>
            </div>
        </div>
    </div>

</asp:Content>
