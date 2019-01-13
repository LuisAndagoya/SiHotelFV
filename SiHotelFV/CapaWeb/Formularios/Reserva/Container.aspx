<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Reserva.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    
      <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">RESERVACIÓN</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
         
                    <div class="form-group">
                        <label for="ListaCliente">Cliente</label>
                         <asp:DropDownList ID="ListaCliente" required ="required" class="form-control" runat="server">
                      </asp:DropDownList>
                        
                    </div>


                    <div class="form-group">
                        <label for="ListaPrecio">Usuario</label>
                       <asp:TextBox ID="TextBox1" class="form-control"  required ="required" runat="server"></asp:TextBox>
                    </div>
            
                  
                    <div class="form-group">
                            <label for="fechaReservacion">Fecha Reservación</label>
                            <asp:TextBox type="datetime" ID="fechaReservacion" class="form-control" runat="server"></asp:TextBox>
                            
                    </div>
                 

                     <div class="form-group">
                            <label for="fechaEntrada">Fecha Entrada</label>
                            <asp:TextBox type="datetime" ID="fechaEntrada" class="form-control" runat="server"></asp:TextBox>
                            
                    </div>

                     <div class="form-group">
                            <label for="fechaSalida">Fecha Salida</label>
                            <asp:TextBox type="datetime" ID="fechaSalida" class="form-control" runat="server"></asp:TextBox>
                            
                    </div>
                     

                       <div class="form-group">
                        <label for="ListaEstado">Estado Habitación</label>
                         <asp:DropDownList ID="ListaEstado" required ="required" class="form-control" runat="server">
                      </asp:DropDownList>
                    </div>

                    
                       <div class="form-group">
                        <label for="totalReservacion">Total Reservación</label>
                         <asp:TextBox ID="totalReservacion" required ="required" class="form-control" runat="server"></asp:TextBox>
                    </div>
                  
                      
   
                      <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx" class="btn btn-light">Cancelar</a>
 
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>

              </form>
            </div>
        </div>
    </div>
</asp:Content>
