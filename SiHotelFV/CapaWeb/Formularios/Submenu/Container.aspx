<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Submenu.Container" %>
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
        <div class="panel-heading">SUB MENÚ</div>
         
          <table  class="table table-hover" style="width: 100%;">
              <tr>
                  <td>
                      
                      <asp:Label ID="Label1" runat="server" Text="Label">Menú:</asp:Label>
                  </td>
                  <td>

                      <asp:DropDownList ID="ListaMenu" runat="server">
                      </asp:DropDownList>
                      
                      &nbsp;
                  </td>
              </tr>  
              
                     <tr>
                  <td>
                      
                      <asp:Label ID="Label2" runat="server" Text="Label">Submenu:</asp:Label>
                  </td>
                  <td> 
                  <asp:TextBox ID="nombreSubMenu"    required ="required"  runat="server"></asp:TextBox>
                    
                      &nbsp;
                  </td>
              </tr>           
              


                 <tr>
                  <td>
                      
                      <asp:Label ID="Label3" runat="server" Text="Label">Url:</asp:Label>
                  </td>
                  <td> 
                  <asp:TextBox ID="urlSubMenu"    required ="required"  runat="server"></asp:TextBox>
                    
                      &nbsp;
                  </td>
              </tr>  



                                   <tr>
                  <td>
                      
                      <asp:Label ID="Label4" runat="server" Text="Label">Icono:</asp:Label>
                  </td>
                  <td> 
                  <asp:TextBox ID="iconoSubMenu"    required ="required"  runat="server"></asp:TextBox>
                    
                      &nbsp;
                  </td>
              </tr>  


           
        
              <tr>
                  <td>
                      &nbsp;
                      <asp:Button class = "btn btn-primary" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx" class=" btn btn-primary">Cancelar</a>
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
