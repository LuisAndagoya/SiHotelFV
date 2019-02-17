<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservacionFechaH.aspx.cs" Inherits="CapaWeb.Reportes.ReservacionFechaH" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>


           <asp:ImageButton ID="imgEliminar" runat="server" OnClick="imgEliminar_Click"
            ImageUrl="~/img/Atras.png" Width="30" />
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="500px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
            <LocalReport ReportPath="Reportes\ReservaFechaHa.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetHabitacion" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>


        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="Habitacion" TypeName="CapaDatos.Clases.DetalleReservaTableAdapters.detalle_reservaTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_idDetalle" Type="Int32" />
                <asp:Parameter Name="Original_idReserva" Type="Int32" />
                <asp:Parameter Name="Original_numeroHabitacion" Type="Int32" />
                <asp:Parameter Name="Original_fechaActual" Type="DateTime" />
                <asp:Parameter Name="Original_valor" Type="Double" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="idReserva" Type="Int32" />
                <asp:Parameter Name="numeroHabitacion" Type="Int32" />
                <asp:Parameter Name="fechaActual" Type="DateTime" />
                <asp:Parameter Name="valor" Type="Double" />
            </InsertParameters>
           
            <UpdateParameters>
                <asp:Parameter Name="idReserva" Type="Int32" />
                <asp:Parameter Name="numeroHabitacion" Type="Int32" />
                <asp:Parameter Name="fechaActual" Type="DateTime" />
                <asp:Parameter Name="valor" Type="Double" />
                <asp:Parameter Name="Original_idDetalle" Type="Int32" />
                <asp:Parameter Name="Original_idReserva" Type="Int32" />
                <asp:Parameter Name="Original_numeroHabitacion" Type="Int32" />
                <asp:Parameter Name="Original_fechaActual" Type="DateTime" />
                <asp:Parameter Name="Original_valor" Type="Double" />
            </UpdateParameters>
        </asp:ObjectDataSource>


       </form>
</asp:Content>
