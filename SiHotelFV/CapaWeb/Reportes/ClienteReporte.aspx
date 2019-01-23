<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClienteReporte.aspx.cs" Inherits="CapaWeb.Reportes.ClienteReporte" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

         <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">REPORTE CLIENTES</h4>

     <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>



              <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                     
                    <a href="ReporteClientes.aspx" class="btn btn-light">Todos</a>
                        <div class="form-group">
                        <label for="estadoCliente">Estado</label>
                              <asp:DropDownList ID="estadoCliente" class="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                          <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                           
                      </asp:DropDownList>
                    </div>

         
                          <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" 
                          Text="Reporte Cliente" onclick="Button1_Click" />
                      
 
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>



         <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="500px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
             <LocalReport ReportPath="Reportes\Cliente.rdlc">
                 <DataSources>
                     <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                 </DataSources>
             </LocalReport>
         </rsweb:ReportViewer>


   

                     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="Reporte" TypeName="CapaDatos.Clases.ClienteTableAdapters.clienteTableAdapter" UpdateMethod="Update">
                         <DeleteParameters>
                             <asp:Parameter Name="Original_idCliente" Type="Int32" />
                             <asp:Parameter Name="Original_dniCliente" Type="String" />
                             <asp:Parameter Name="Original_nombreCliente" Type="String" />
                             <asp:Parameter Name="Original_apellidoCliente" Type="String" />
                             <asp:Parameter Name="Original_sexoCliente" Type="String" />
                             <asp:Parameter Name="Original_direccionCliente" Type="String" />
                             <asp:Parameter Name="Original_telefonoCliente" Type="String" />
                             <asp:Parameter Name="Original_correoCliente" Type="String" />
                             <asp:Parameter Name="Original_estadoCliente" Type="String" />
                         </DeleteParameters>
                         <InsertParameters>
                             <asp:Parameter Name="dniCliente" Type="String" />
                             <asp:Parameter Name="nombreCliente" Type="String" />
                             <asp:Parameter Name="apellidoCliente" Type="String" />
                             <asp:Parameter Name="sexoCliente" Type="String" />
                             <asp:Parameter Name="direccionCliente" Type="String" />
                             <asp:Parameter Name="telefonoCliente" Type="String" />
                             <asp:Parameter Name="correoCliente" Type="String" />
                             <asp:Parameter Name="estadoCliente" Type="String" />
                         </InsertParameters>
                         <SelectParameters>
                             <asp:ControlParameter ControlID="estadoCliente" Name="Id" PropertyName="SelectedValue" Type="String" />
                         </SelectParameters>
                         <UpdateParameters>
                             <asp:Parameter Name="dniCliente" Type="String" />
                             <asp:Parameter Name="nombreCliente" Type="String" />
                             <asp:Parameter Name="apellidoCliente" Type="String" />
                             <asp:Parameter Name="sexoCliente" Type="String" />
                             <asp:Parameter Name="direccionCliente" Type="String" />
                             <asp:Parameter Name="telefonoCliente" Type="String" />
                             <asp:Parameter Name="correoCliente" Type="String" />
                             <asp:Parameter Name="estadoCliente" Type="String" />
                             <asp:Parameter Name="Original_idCliente" Type="Int32" />
                             <asp:Parameter Name="Original_dniCliente" Type="String" />
                             <asp:Parameter Name="Original_nombreCliente" Type="String" />
                             <asp:Parameter Name="Original_apellidoCliente" Type="String" />
                             <asp:Parameter Name="Original_sexoCliente" Type="String" />
                             <asp:Parameter Name="Original_direccionCliente" Type="String" />
                             <asp:Parameter Name="Original_telefonoCliente" Type="String" />
                             <asp:Parameter Name="Original_correoCliente" Type="String" />
                             <asp:Parameter Name="Original_estadoCliente" Type="String" />
                         </UpdateParameters>
         </asp:ObjectDataSource>


   

                     </form>
            </div>
        </div>
    </div>
</asp:Content>
