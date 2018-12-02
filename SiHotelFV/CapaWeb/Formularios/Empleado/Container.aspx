<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Empleado.Container" %>
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
        <div class="panel-heading">EMPLEADO</div>
          <br />
          <br />

         
          <table  class="table table-hover" style="width: 100%;">
              <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label1" runat="server" Text="Label">Cédula:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="dniEmpleado"    pattern="^[0-9]{10}$"   required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>            
              

              <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label2" runat="server" Text="Label">Nombre:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="nombreEmpleado"    pattern="^[\ s A-z ]*$" required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>  


               <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label3" runat="server" Text="Label">Apellido:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="apellidoEmpleado"   pattern="^[\ s A-z ]*$"  required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>  


               <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label4" runat="server" Text="Label">Fecha Nacimiento:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox type="date" ID="fnacimiento" required ="required"  runat="server"></asp:TextBox>
                  
                      &nbsp;
                  </td>
              </tr>  
        

                  <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label5" runat="server" Text="Label">Sexo:</asp:Label>
                  </td>
                  <td>
                     
                      &nbsp;

                       <asp:DropDownList ID="sexoEmpleado" runat="server">
                          <asp:ListItem Selected="True" Value="M">MASCULINO</asp:ListItem>
                          <asp:ListItem Value="F">FEMENINO</asp:ListItem>
                      </asp:DropDownList>



                  </td>
              </tr>  



                    <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label6" runat="server" Text="Label">Estado civil:</asp:Label>
                  </td>
                  <td>
                      
                      
                       
                      &nbsp;

                       <asp:DropDownList ID="estadocivilEmpleado" runat="server">
                          <asp:ListItem Selected="True" Value="CASADO">CASADO</asp:ListItem>
                          <asp:ListItem Value="DIVORCIADO">DIVORCIADO</asp:ListItem>
                           <asp:ListItem Value="SOLTERO">SOLTERO</asp:ListItem>
                           <asp:ListItem Value="UNION LIBRE">UNION LIBRE</asp:ListItem>
                      </asp:DropDownList>



                  </td>
              </tr>  



                    <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label7" runat="server" Text="Label">Domicilio:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="domicilioEmpleado"    required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>  



                    <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label8" runat="server" Text="Label">Celular:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="telefmovilEmpleado"   pattern="^[0-9]{10}$" placeholder="Ejm: 0992333333" required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>  


                <tr>
                  <td>
                      &nbsp;
                     <asp:Label ID="Label9"  runat="server" Text="Label">Fecha registro:</asp:Label>
                  </td>
                  <td>
                       <asp:TextBox Type="date" ID="fecharegistroEmpleado"   visible="true" required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr>

  
                      
                  
                     
                



                  <tr>
                  <td>
                      &nbsp;
                      <asp:Label ID="Label10" runat="server" Text="Label">Email:</asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="emailEmpleado"  type="email"  required ="required"  runat="server"></asp:TextBox>
                      &nbsp;
                  </td>
              </tr> 




              <tr>
                  <td>
                      &nbsp;
                      <asp:Button class = "btn btn-primary" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx" class="btn btn-primary">Cancelar</a>
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
