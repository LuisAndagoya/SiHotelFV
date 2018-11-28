<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Cargo.Container" %>
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
        <div class="panel-heading">CARGO</div>
         
          <table  class="table table-hover" style="width: 100%;">
              <tr>
                  <td>
                      &nbsp;
                      &nbsp;
                      &nbsp;
                      <asp:Label ID="Label1" runat="server" Text="Label">Cargo:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="nombreCargo"    required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>            
              
        
              <tr>
                  <td>
                      &nbsp;
                      <asp:Button class = "btn btn-primary" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx" class="btn btn-default">Cancelar</a>
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