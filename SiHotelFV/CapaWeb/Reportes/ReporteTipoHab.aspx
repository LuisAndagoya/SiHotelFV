<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteTipoHab.aspx.cs" Inherits="CapaWeb.Reportes.ReporteTipoHab" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>

        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="500px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
            <LocalReport ReportPath="Reportes\ListaTipoHabitacion.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetListaHabitacion" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetLista" TypeName="CapaDatos.Clases.TipoHabitacionTableAdapters.tipo_habitacionTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_idtipo" Type="Int32" />
                <asp:Parameter Name="Original_nombreTipo" Type="String" />
                <asp:Parameter Name="Original_idPrecio" Type="Int32" />
                <asp:Parameter Name="Original_imagenTipo" Type="String" />
                <asp:Parameter Name="Original_estadoTipo" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="nombreTipo" Type="String" />
                <asp:Parameter Name="idPrecio" Type="Int32" />
                <asp:Parameter Name="imagenTipo" Type="String" />
                <asp:Parameter Name="estadoTipo" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="nombreTipo" Type="String" />
                <asp:Parameter Name="idPrecio" Type="Int32" />
                <asp:Parameter Name="imagenTipo" Type="String" />
                <asp:Parameter Name="estadoTipo" Type="String" />
                <asp:Parameter Name="Original_idtipo" Type="Int32" />
                <asp:Parameter Name="Original_nombreTipo" Type="String" />
                <asp:Parameter Name="Original_idPrecio" Type="Int32" />
                <asp:Parameter Name="Original_imagenTipo" Type="String" />
                <asp:Parameter Name="Original_estadoTipo" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        </form>
</asp:Content>
