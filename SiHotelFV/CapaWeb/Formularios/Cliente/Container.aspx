<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Cliente.Contairner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


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
        <div class="panel-heading">CLIENTE</div>
         
          <table  class="table table-hover" style="width: 100%;">
              <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label1" runat="server" Text="Label">Cédula:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="CedulaCliente"    pattern="^[0-9]{10}$"   required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>            
              

              <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label2" runat="server" Text="Label">Nombre:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="NombreCliente"    pattern="^[\ s A-z ]*$" required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>  


               <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label3" runat="server" Text="Label">Apellido:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="ApellidoCliente"   pattern="^[\ s A-z ]*$"  required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>  


               <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label4" runat="server" Text="Label">Dirección:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="DireccionCliente"    required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>  
        

                



                    <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label8" runat="server" Text="Label">Celular:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="Telefono"   pattern="^[0-9]{10}$" placeholder="Ejm: 0992333333" required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>  


                  <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label10" runat="server" Text="Label">Email:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="Email"    required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr> 




              <tr>
                  <td>
                      &nbsp;
                      <asp:Button class = "btn btn-primary" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx"  "btn btn-primary">Cancelar</a>
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





</asp:Content>
