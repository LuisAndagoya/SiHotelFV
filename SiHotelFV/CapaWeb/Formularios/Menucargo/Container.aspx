<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Menucargo.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-lg-12 grid-margin stretch-card">
      <div class="card">
         <div class="card-body">


      <form id="form1" runat="server">
        <div>
    <table  align="left">
  <tr>
    <td><!-- Cabezera-->
      <br />
     <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
      <!-- Cabezera--></td>
  </tr>
  <tr>
    <td ><br />
   
<!--Detalle-->
      <div class="panel panel-default">
        <div class="panel-heading">MENU CARGO</div>
            <br />
          <br />
         
          <table  class="table table-hover" style="width: 100%;">
              <tr>
                  <td>
                      
                      <asp:Label ID="Label1" runat="server" Text="Label">Cargo:</asp:Label>
                  </td>
                  <td>

                      <asp:DropDownList ID="ListaCargo" runat="server">
                      </asp:DropDownList>
                      
                      &nbsp;
                  </td>
              </tr>  
              
                     <tr>
                  <td>
                      
                      <asp:Label ID="Label2" runat="server" Text="Label">Submenu:</asp:Label>
                  </td>
                  <td>

                      
                    
                      <asp:DropDownList ID="ListaSubmenu" runat="server">
                      </asp:DropDownList>
                    
                      &nbsp;
                  </td>
              </tr>           
              
        
              <tr>
                  <td>
                      &nbsp;
                      <asp:Button class = "btn btn-primary" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx" class= "btn btn-primary">Cancelar</a>
                  </td>
                  <td>
                      &nbsp;
                  </td>
              </tr>
          </table>
      </div>
      <!--Detalle--></td>
  </tr>
  <tr>
    <td><!-- Pie -->
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
      </td>
  </tr>
</table>
            </div>
        </form>

     </div>
    </div>
         </div>
</asp:Content>
