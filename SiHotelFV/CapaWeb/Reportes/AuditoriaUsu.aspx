<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AuditoriaUsu.aspx.cs" Inherits="CapaWeb.Reportes.AuditoriaUsu" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>

        <asp:ImageButton ID="imgEliminar" runat="server" OnClick="imgEliminar_Click"
            ImageUrl="~/img/Atras.png" Width="30" />
          <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="500px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
              <LocalReport ReportPath="Reportes\AuditoriaUsu.rdlc">
                  <DataSources>
                      <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetUsuario" />
                  </DataSources>
              </LocalReport>
          </rsweb:ReportViewer>

            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="Usuario" TypeName="CapaDatos.Clases.AuditoriaTableAdapters.auditoriaTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_idAuditoria" Type="Int32" />
                    <asp:Parameter Name="Original_ipAuditoria" Type="String" />
                    <asp:Parameter Name="Original_tablaAuditoria" Type="String" />
                    <asp:Parameter Name="Original_accionAditoria" Type="String" />
                    <asp:Parameter Name="Original_idUsuario" Type="Int32" />
                    <asp:Parameter Name="Original_fechaAditoria" Type="DateTime" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ipAuditoria" Type="String" />
                    <asp:Parameter Name="tablaAuditoria" Type="String" />
                    <asp:Parameter Name="accionAditoria" Type="String" />
                    <asp:Parameter Name="idUsuario" Type="Int32" />
                    <asp:Parameter Name="fechaAditoria" Type="DateTime" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ipAuditoria" Type="String" />
                    <asp:Parameter Name="tablaAuditoria" Type="String" />
                    <asp:Parameter Name="accionAditoria" Type="String" />
                    <asp:Parameter Name="idUsuario" Type="Int32" />
                    <asp:Parameter Name="fechaAditoria" Type="DateTime" />
                    <asp:Parameter Name="Original_idAuditoria" Type="Int32" />
                    <asp:Parameter Name="Original_ipAuditoria" Type="String" />
                    <asp:Parameter Name="Original_tablaAuditoria" Type="String" />
                    <asp:Parameter Name="Original_accionAditoria" Type="String" />
                    <asp:Parameter Name="Original_idUsuario" Type="Int32" />
                    <asp:Parameter Name="Original_fechaAditoria" Type="DateTime" />
                </UpdateParameters>
          </asp:ObjectDataSource>

            </form>
</asp:Content>
