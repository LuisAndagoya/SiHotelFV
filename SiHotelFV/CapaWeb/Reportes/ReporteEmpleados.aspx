<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteEmpleados.aspx.cs" Inherits="CapaWeb.Reportes.ReporteEmpleados" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" DocumentMapWidth="100%" Font-Names="Verdana" Font-Size="8pt" Height="500px" style="margin-right: 4px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
            <LocalReport ReportPath="Reportes\ListaEmpleados.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetListaEmpleado" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetLista" TypeName="CapaDatos.Clases.EmpleadoTableAdapters.empleadoTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_idEmpleado" Type="Int32" />
                <asp:Parameter Name="Original_dniEmpleado" Type="String" />
                <asp:Parameter Name="Original_nombreEmpleado" Type="String" />
                <asp:Parameter Name="Original_apellidoEmpleado" Type="String" />
                <asp:Parameter Name="Original_fnacimientoEmpleado" Type="DateTime" />
                <asp:Parameter Name="Original_sexoEmpleado" Type="String" />
                <asp:Parameter Name="Original_estadocivilEmpleado" Type="String" />
                <asp:Parameter Name="Original_domicilioEmpleado" Type="String" />
                <asp:Parameter Name="Original_telefmovilEmpleado" Type="String" />
                <asp:Parameter Name="Original_fecharegistroEmpleado" Type="DateTime" />
                <asp:Parameter Name="Original_emailEmpleado" Type="String" />
                <asp:Parameter Name="Original_imagenEmpleado" Type="String" />
                <asp:Parameter Name="Original_estadoEmpleado" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="dniEmpleado" Type="String" />
                <asp:Parameter Name="nombreEmpleado" Type="String" />
                <asp:Parameter Name="apellidoEmpleado" Type="String" />
                <asp:Parameter Name="fnacimientoEmpleado" Type="DateTime" />
                <asp:Parameter Name="sexoEmpleado" Type="String" />
                <asp:Parameter Name="estadocivilEmpleado" Type="String" />
                <asp:Parameter Name="domicilioEmpleado" Type="String" />
                <asp:Parameter Name="telefmovilEmpleado" Type="String" />
                <asp:Parameter Name="fecharegistroEmpleado" Type="DateTime" />
                <asp:Parameter Name="emailEmpleado" Type="String" />
                <asp:Parameter Name="imagenEmpleado" Type="String" />
                <asp:Parameter Name="estadoEmpleado" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="dniEmpleado" Type="String" />
                <asp:Parameter Name="nombreEmpleado" Type="String" />
                <asp:Parameter Name="apellidoEmpleado" Type="String" />
                <asp:Parameter Name="fnacimientoEmpleado" Type="DateTime" />
                <asp:Parameter Name="sexoEmpleado" Type="String" />
                <asp:Parameter Name="estadocivilEmpleado" Type="String" />
                <asp:Parameter Name="domicilioEmpleado" Type="String" />
                <asp:Parameter Name="telefmovilEmpleado" Type="String" />
                <asp:Parameter Name="fecharegistroEmpleado" Type="DateTime" />
                <asp:Parameter Name="emailEmpleado" Type="String" />
                <asp:Parameter Name="imagenEmpleado" Type="String" />
                <asp:Parameter Name="estadoEmpleado" Type="String" />
                <asp:Parameter Name="Original_idEmpleado" Type="Int32" />
                <asp:Parameter Name="Original_dniEmpleado" Type="String" />
                <asp:Parameter Name="Original_nombreEmpleado" Type="String" />
                <asp:Parameter Name="Original_apellidoEmpleado" Type="String" />
                <asp:Parameter Name="Original_fnacimientoEmpleado" Type="DateTime" />
                <asp:Parameter Name="Original_sexoEmpleado" Type="String" />
                <asp:Parameter Name="Original_estadocivilEmpleado" Type="String" />
                <asp:Parameter Name="Original_domicilioEmpleado" Type="String" />
                <asp:Parameter Name="Original_telefmovilEmpleado" Type="String" />
                <asp:Parameter Name="Original_fecharegistroEmpleado" Type="DateTime" />
                <asp:Parameter Name="Original_emailEmpleado" Type="String" />
                <asp:Parameter Name="Original_imagenEmpleado" Type="String" />
                <asp:Parameter Name="Original_estadoEmpleado" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        </form>
</asp:Content>
