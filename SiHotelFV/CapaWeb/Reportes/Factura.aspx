<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="CapaWeb.Reportes.Factura" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>
             <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
                 <LocalReport ReportPath="Reportes\Report1.rdlc">
                       <DataSources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="ListaReserva" />
                            </DataSources>
                 </LocalReport>
             </rsweb:ReportViewer>
              <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Lista"
                        TypeName="CapaProceso.Clases.Factura" OldValuesParameterFormatString="original_{0}">
                    </asp:ObjectDataSource>

             </form>
</asp:Content>
