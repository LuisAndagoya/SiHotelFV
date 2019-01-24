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


         <table style="border-top: hidden">
             <tr>
                 <td>


                     <label for="estadoCliente">Estado</label></td>

                 <td>
                     <asp:DropDownList ID="estadoCliente" class="form-control" runat="server">
                         <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                         <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>

                     </asp:DropDownList>
                 </td>
                 <td>
                     <asp:Button class="btn btn-gradient-info btn-sm" ID="Button1" runat="server"
                         Text="Filtrar" OnClick="Button1_Click" />
                 </td>
                 <td>
                     <a href="ReporteClientes.aspx" class="btn btn-gradient-dark btn-sm">Listar Todos</a></td>
             </tr>

             <tr>
                 <td colspan="4">
                     <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="500px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="700px">
                         <LocalReport ReportPath="Reportes\Cliente.rdlc">
                             <DataSources>
                                 <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                             </DataSources>
                         </LocalReport>
                     </rsweb:ReportViewer>

                     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="Reporte" TypeName="CapaDatos.Clases.ClienteTableAdapters.clienteTableAdapter" UpdateMethod="Update">

                         <SelectParameters>
                             <asp:ControlParameter ControlID="estadoCliente" Name="Id" PropertyName="SelectedValue" Type="String" />
                         </SelectParameters>

                     </asp:ObjectDataSource>
                 </td>
             </tr>

         </table>

   

                     </form>
            </div>
        </div>
    </div>
</asp:Content>
