<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Menu.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">MENÚ</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
   
                      
                    <div class="form-group">
                        <label for="nombreMenu">Menú</label>
                        <asp:TextBox ID="nombreMenu"  class="form-control"  required ="required"  runat="server"></asp:TextBox>
                    </div>

                      <div class="form-group">
                        <label for="urlMenu">Url</label>
                          <asp:TextBox ID="urlMenu"   class="form-control" required ="required"  runat="server"></asp:TextBox>
                        
                    </div>

    
                  
                     
                    
                      <div class="form-group">
                        <label for="iconoMenu">Icono</label>
                         <asp:TextBox ID="iconoMenu"  class="form-control"  required ="required"  runat="server"></asp:TextBox>
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
