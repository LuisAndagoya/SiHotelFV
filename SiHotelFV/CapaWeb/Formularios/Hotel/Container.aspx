<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Hotel.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">HOTEL</h4>

                <form id="form1" class="forms-sample" runat="server" name="form1" >
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>


                     <div class="form-group">
                        <label for="codHotel">Código</label>
                       <asp:TextBox ID="codHotel"   class="form-control"    required ="required"  runat="server"></asp:TextBox>
                    </div>
         
    
                       <div class="form-group">
                        <label for="nombreHotel">Hotel</label>
                       <asp:TextBox ID="nombreHotel"  class="form-control"  pattern="^[\ s A-z ]*$" required ="required"  runat="server"></asp:TextBox>
                    </div>
                

                    
                       <div class="form-group">
                        <label for="numeroHabitaciones">N° Habitaciones</label>
                       <asp:TextBox ID="numeroHabitaciones" class="form-control"  type="number" pattern="^[0-9]$" required ="required"  runat="server"></asp:TextBox>
                    </div>
             
                      
                      <div class="form-group">
                        <label for="categoriaHotel">Categoría</label>
                        <asp:TextBox  ID="categoriaHotel" class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>
                
                  
                      <div class="form-group">
                        <label for="ciudadHotel">Ciudad</label>
                        <asp:TextBox ID="ciudadHotel" class="form-control" pattern="^[\ s A-z ]*$" required ="required"  runat="server"></asp:TextBox>
                    </div>


                      <div class="form-group">
                        <label for="direccionHotel">Dirección</label>
                        <asp:TextBox ID="direccionHotel" class="form-control" required ="required" runat="server"></asp:TextBox>
                    </div>


                      <div class="form-group">
                        <label for="telefonoHotel">Teléfono</label>
                        <asp:TextBox ID="telefonoHotel" pattern="^[0-9]{9}$"  class="form-control" placeholder="Ejm: 022292092"  runat="server"></asp:TextBox>
                    </div>


                      <div class="form-group">
                        <label for="correoHotel">Correo</label>
                          <asp:TextBox ID="correoHotel"  class="form-control"  required ="required" type="email" runat="server"></asp:TextBox>
                    </div>


                     <div class="form-group">
                        <label for="descripcionHotel">Descripción</label>
                          <asp:TextBox ID="descripcionHotel"  class="form-control"  required ="required"  runat="server"></asp:TextBox>
                    </div>
                    

                      <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx" class="btn btn-light">Cancelar</a>
                
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
               </form>
            </div>
        </div>
    </div>

</asp:Content>
