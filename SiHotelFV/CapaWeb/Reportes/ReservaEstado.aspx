<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservaEstado.aspx.cs" Inherits="CapaWeb.Reportes.ReservaEstado" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>

        <asp:ImageButton ID="imgEliminar" runat="server" OnClick="imgEliminar_Click"
            ImageUrl="~/img/Atras.png" Width="30" />
         <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="500px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
             <LocalReport ReportPath="Reportes\ReservaEstado.rdlc">
                 <DataSources>
                     <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetEstado" />
                 </DataSources>
             </LocalReport>
         </rsweb:ReportViewer>
         <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="Estado" TypeName="CapaDatos.Clases.ReporteReservaTableAdapters.reservasTableAdapter" UpdateMethod="Update">
             <DeleteParameters>
                 <asp:Parameter Name="Original_idReservacion" Type="Int32" />
                 <asp:Parameter Name="Original_idCliente" Type="Int32" />
                 <asp:Parameter Name="Original_idUsuario" Type="Int32" />
                 <asp:Parameter Name="Original_fechaReservacion" Type="DateTime" />
                 <asp:Parameter Name="Original_fechaEntrada" Type="DateTime" />
                 <asp:Parameter Name="Original_fechaSalida" Type="DateTime" />
                 <asp:Parameter Name="Original_idEstadoReserva" Type="Int32" />
                 <asp:Parameter Name="Original_totalReservacion" Type="Double" />
                 <asp:Parameter Name="Original_SaldoReserva" Type="Decimal" />
                 <asp:Parameter Name="Original_PagadoReserva" Type="Decimal" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="idCliente" Type="Int32" />
                 <asp:Parameter Name="idUsuario" Type="Int32" />
                 <asp:Parameter Name="fechaReservacion" Type="DateTime" />
                 <asp:Parameter Name="fechaEntrada" Type="DateTime" />
                 <asp:Parameter Name="fechaSalida" Type="DateTime" />
                 <asp:Parameter Name="idEstadoReserva" Type="Int32" />
                 <asp:Parameter Name="totalReservacion" Type="Double" />
                 <asp:Parameter Name="SaldoReserva" Type="Decimal" />
                 <asp:Parameter Name="PagadoReserva" Type="Decimal" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="idCliente" Type="Int32" />
                 <asp:Parameter Name="idUsuario" Type="Int32" />
                 <asp:Parameter Name="fechaReservacion" Type="DateTime" />
                 <asp:Parameter Name="fechaEntrada" Type="DateTime" />
                 <asp:Parameter Name="fechaSalida" Type="DateTime" />
                 <asp:Parameter Name="idEstadoReserva" Type="Int32" />
                 <asp:Parameter Name="totalReservacion" Type="Double" />
                 <asp:Parameter Name="SaldoReserva" Type="Decimal" />
                 <asp:Parameter Name="PagadoReserva" Type="Decimal" />
                 <asp:Parameter Name="Original_idReservacion" Type="Int32" />
                 <asp:Parameter Name="Original_idCliente" Type="Int32" />
                 <asp:Parameter Name="Original_idUsuario" Type="Int32" />
                 <asp:Parameter Name="Original_fechaReservacion" Type="DateTime" />
                 <asp:Parameter Name="Original_fechaEntrada" Type="DateTime" />
                 <asp:Parameter Name="Original_fechaSalida" Type="DateTime" />
                 <asp:Parameter Name="Original_idEstadoReserva" Type="Int32" />
                 <asp:Parameter Name="Original_totalReservacion" Type="Double" />
                 <asp:Parameter Name="Original_SaldoReserva" Type="Decimal" />
                 <asp:Parameter Name="Original_PagadoReserva" Type="Decimal" />
             </UpdateParameters>
         </asp:ObjectDataSource>
         </form>
</asp:Content>
