<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Distribucion.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">DISTRIBUCIÓN HABITACIÓN</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
   
                     <div class="form-group">
                        <label for="camaIndividual">Cama Individual</label>        
                         <asp:CheckBox ID="camaIndividual" class="form-control" runat="server" />
                        
                    </div>

                    <div class="form-group">
                         <label for="camaMatrimonial">Cama Matrimonial</label>
                         <asp:CheckBox ID="camaMatrimonial" class="form-control" runat="server" />
                        
                    </div>
                      

                    
                    <div class="form-group">
                         <label for="camaKing">Cama King</label>
                         <asp:CheckBox ID="camaKing" class="form-control" value="" runat="server" />
                       
                    </div>

                    
                    <div class="form-group">
                         <label for="camaMatrimonial">Máximo Personas</label>
                        <asp:TextBox ID="maximoPersonas" type="number" step="1" class="form-control" runat="server"></asp:TextBox>
                  
                    </div>


                  <div class="form-group">
                         <label for="televisionCable">Televisión Cable</label>
                        <asp:DropDownList class="form-control" ID="televisionCable" runat="server">
                            <asp:ListItem Selected="True" Value="SI">SI</asp:ListItem>
                            <asp:ListItem Value="NO">NO</asp:ListItem>
                        </asp:DropDownList>
                      
                        
                    </div>
                     
                       <div class="form-group">
                         <label for="aireAcondicionado">Aire Acondicionado</label>
                        <asp:DropDownList class="form-control" ID="aireAcondicionado" runat="server">
                            <asp:ListItem Selected="True" Value="SI">SI</asp:ListItem>
                            <asp:ListItem Value="NO">NO</asp:ListItem>
                        </asp:DropDownList>
                        
                    </div>

                            <div class="form-group">
                         <label for="ventilador">Ventilador</label>
                        <asp:DropDownList class="form-control" ID="ventilador" runat="server">
                            <asp:ListItem Selected="True" Value="SI">SI</asp:ListItem>
                            <asp:ListItem Value="NO">NO</asp:ListItem>
                        </asp:DropDownList>
                        
                    </div>


                    <div class="form-group">
                         <label for="wifi">Wifi</label>
                        <asp:DropDownList class="form-control" ID="wifi" runat="server">
                            <asp:ListItem Selected="True" Value="SI">SI</asp:ListItem>
                            <asp:ListItem Value="NO">NO</asp:ListItem>
                        </asp:DropDownList>
                        
                    </div>

                      <div class="form-group">
                         <label for="toallas">Toallas</label>
                        <asp:DropDownList class="form-control" ID="toallas" runat="server">
                            <asp:ListItem Selected="True" Value="SI">SI</asp:ListItem>
                            <asp:ListItem Value="NO">NO</asp:ListItem>
                        </asp:DropDownList>
                        
                    </div>


                      <div class="form-group">
                         <label for="banioPrivado">Baño Privado</label>
                        <asp:DropDownList class="form-control" ID="banioPrivado" runat="server">
                            <asp:ListItem Selected="True" Value="SI">SI</asp:ListItem>
                            <asp:ListItem Value="NO">NO</asp:ListItem>
                        </asp:DropDownList>
                        
                    </div>


           
                      <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" 
                          Text="Guardar" onclick="Button1_Click" />
                      <a href="Index.aspx"  class="btn btn-light">Cancelar</a>
  
    
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
      </form>
            </div>
        </div>
    </div>
</asp:Content>
