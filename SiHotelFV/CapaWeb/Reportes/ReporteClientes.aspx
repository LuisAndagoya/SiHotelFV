<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteClientes.aspx.cs" Inherits="CapaWeb.Reportes.ReporteClientes" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>
          <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="500px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
              <LocalReport ReportPath="Reportes\ListaClientes.rdlc">
                  <DataSources>
                      <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetListaClientes" />
                  </DataSources>
              </LocalReport>
          </rsweb:ReportViewer>
          <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetLista" TypeName="CapaDatos.Clases.ClienteTableAdapters.clienteTableAdapter" UpdateMethod="Update">
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
</asp:Content>
