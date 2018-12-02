<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Usuario.Container" %>
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
        <div class="panel-heading">USUARIO</div>
            <br />
          <br />
         
          <table  class="table table-hover" style="width: 100%;">
             
              
                     <tr>
                  <td>
                      
                      <asp:Label ID="Label2" runat="server" Text="Label">Usuario:</asp:Label>
                  </td>
                  <td> 
                  <asp:TextBox ID="usernameUsuario"   class="form-control" required ="required"  runat="server"></asp:TextBox>
                    
                      &nbsp;
                  </td>
              </tr>           
              


                 <tr>
                  <td>
                      
                      <asp:Label ID="Label3" runat="server" Text="Label">Contraseña:</asp:Label>
                  </td>
                  <td> 
                  
                 
                      <asp:TextBox ID="passwordUsuario" class="form-control" type = "password" pattern="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$" placeholder="Ejm: Carlos@12" required ="required"  runat="server"></asp:TextBox>
                    
                      &nbsp;
                  </td>
              </tr>  



              

               <tr>
                  <td>
                      
                      <asp:Label ID="Label1" runat="server" Text="Label">Empleado:</asp:Label>
                  </td>
                  <td>

                      <asp:DropDownList class="form-control"  ID="ListaEmpleado" runat="server">
                      </asp:DropDownList>
                      
                      &nbsp;
                  </td>
              </tr>  
           

                 <tr>
                  <td>
                      
                      <asp:Label ID="Label5" runat="server" Text="Label">Cargo:</asp:Label>
                  </td>
                  <td>

                      <asp:DropDownList class="form-control" ID="ListaCargo" runat="server">
                      </asp:DropDownList>
                      
                      &nbsp;
                  </td>
              </tr>  



                <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label4" runat="server" Text="Label">Estado</asp:Label>
                  </td>
                  <td>
                      &nbsp;
                      <asp:DropDownList class="form-control"  ID="DropDownList1" runat="server">
                          <asp:ListItem Selected="True" Value="A">ACTIVO</asp:ListItem>
                          <asp:ListItem Value="I">INACTIVO</asp:ListItem>
                      </asp:DropDownList>
                  </td>
              </tr>


        
              <tr>
                  <td>
                      &nbsp;
                      <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" 
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
