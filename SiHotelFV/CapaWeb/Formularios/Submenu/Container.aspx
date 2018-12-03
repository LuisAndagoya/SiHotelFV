<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Submenu.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


      <div class="col-lg-12 grid-margin stretch-card">
      <div class="card">
         <div class="card-body">


               <h4 class="card-title">SUBMENÚ</h4>

                <form id="form2" class="forms-sample" runat="server">
                   <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                <div class="form-group">
                        <label for="ListaMenu">Menú</label>
                     
                       <asp:DropDownList ID="ListaMenu"  class="form-control" runat="server">
                      </asp:DropDownList>
                </div>


                    <div class="form-group">
                        <label for="nombreSubMenu">Submenú</label>
                        <asp:TextBox ID="nombreSubMenu"   class="form-control" required ="required"  runat="server"></asp:TextBox>
                    </div>
 

                     <div class="form-group">
                        <label for="urlSubMenu">Url</label>
                        <asp:TextBox ID="urlSubMenu"  class="form-control"  required ="required"  runat="server"></asp:TextBox>
                    </div>
  
                      
                   <div class="form-group">
                        <label for="iconoSubMen">Icono</label>
                        <asp:TextBox ID="iconoSubMenu"  class="form-control"  required ="required"  runat="server"></asp:TextBox>
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
