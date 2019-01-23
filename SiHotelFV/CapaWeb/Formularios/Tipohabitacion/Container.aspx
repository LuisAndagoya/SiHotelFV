<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Tipohabitacion.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




     <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">TIPO HABITACIÓN</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
         
                    <div class="form-group">
                        <label for="nombreTipo">Tipo</label>
                        <asp:TextBox ID="nombreTipo" class="form-control"  required ="required" runat="server"></asp:TextBox>
                        
                    </div>


                    <div class="form-group">
                        <label for="ListaPrecio">Precio</label>
                       <asp:DropDownList ID="ListaPrecio" required ="required" class="form-control" runat="server">
                      </asp:DropDownList>
                    </div>
            
                  
                 

                     <div class="form-group">
                            <label for="imagenEmpleado">Imagen</label>
                            <asp:TextBox ID="txtfot" class="form-control" runat="server"></asp:TextBox>
                             <asp:FileUpload ID="FileUpload1"  class="form-control" runat="server" />
                            <div><asp:Image ID="Image1" runat="server"  class="form-control" /></div>
                            
                            <asp:Button ID="btnSubir"  class="btn btn-light" runat="server" Text="Subir Imágen" OnClick="btnSubir_Click1" />
                    </div>

                     <div class="form-group">
                        <label for="maximoTipo">Máximo Personas</label>
                        <asp:TextBox ID="maximoTipo" class="form-control" type="number" required ="required" runat="server"></asp:TextBox>
                        
                    </div>

                       <div class="form-group">
                        <label for="estadoEmpleado">Estado</label>
                          <asp:DropDownList ID="estadoTipo"  class="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                          <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                      </asp:DropDownList>
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
