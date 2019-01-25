<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="CapaWeb.Reportes.Factura" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>

              <asp:ImageButton ID="imgEliminar" runat="server" OnClick="imgEliminar_Click"
            ImageUrl="~/img/Atras.png" Width="30" />
             <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="500px" Width="100%">
                 <LocalReport ReportPath="Reportes\Cabecera.rdlc">
                       <DataSources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetCabecera" />
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource3" Name="DataSetDetalle" />
                            </DataSources>
                 </LocalReport>
             </rsweb:ReportViewer>
              <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Detalle" TypeName="CapaDatos.Clases.DetalleReservaTableAdapters.detalle_reservaTableAdapter">
                
                 
             </asp:ObjectDataSource>
             <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Cabecera" TypeName="CapaDatos.Clases.ReporteReservaTableAdapters.reservasTableAdapter">
                
                 
             </asp:ObjectDataSource>

             </form>
</asp:Content>
