<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Menu.Container" %>
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
        <div class="panel-heading">MENÚ</div>
          <br />
          <br />
         
          <table  class="table table-hover" style="width: 100%;">
              <tr>
                  <td>
                      
                      <asp:Label ID="Label1" runat="server" Text="Label">Menú:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="nombreMenu"  class="form-control"  required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>            


                  <tr>
                  <td>
                      
                      <asp:Label ID="Label2" runat="server" Text="Label">Url:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="urlMenu"   class="form-control" required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>   
              

                 <tr>
                  <td>
                      
                      <asp:Label ID="Label3" runat="server" Text="Label">Icono:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="iconoMenu"  class="form-control"  required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>
        
              <tr>
                  <td>
                      &nbsp;
                      <asp:Button class = "btn btn-primary" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx" class="btn btn-light">Cancelar</a>
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
