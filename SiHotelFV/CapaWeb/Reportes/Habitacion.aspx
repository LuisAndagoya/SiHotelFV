<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Habitacion.aspx.cs" Inherits="CapaWeb.Reportes.Habitacion" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>

        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="500px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
            <LocalReport ReportPath="Reportes\ReporHabitacion.rdlc">
                  <DataSources>
                      <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />

                  </DataSources>

            </LocalReport>
        </rsweb:ReportViewer>


         <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Lista" TypeName="CapaDatos.Clases.ReporteHabitacionTableAdapters.habitacionTableAdapter" UpdateMethod="Update" DeleteMethod="Delete" InsertMethod="Insert">
            
             <DeleteParameters>
                 <asp:Parameter Name="Original_numeroHabitacion" Type="Int32" />
                 <asp:Parameter Name="Original_tipoHabitacion_Idtipo" Type="Int32" />
                 <asp:Parameter Name="Original_hotel_CodigoHotel" Type="String" />
                 <asp:Parameter Name="Original_estadoHabitacion_idEstado" Type="Int32" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="numeroHabitacion" Type="Int32" />
                 <asp:Parameter Name="tipoHabitacion_Idtipo" Type="Int32" />
                 <asp:Parameter Name="hotel_CodigoHotel" Type="String" />
                 <asp:Parameter Name="estadoHabitacion_idEstado" Type="Int32" />
             </InsertParameters>
            
             <UpdateParameters>
                 <asp:Parameter Name="tipoHabitacion_Idtipo" Type="Int32" />
                 <asp:Parameter Name="hotel_CodigoHotel" Type="String" />
                 <asp:Parameter Name="estadoHabitacion_idEstado" Type="Int32" />
                 <asp:Parameter Name="Original_numeroHabitacion" Type="Int32" />
                 <asp:Parameter Name="Original_tipoHabitacion_Idtipo" Type="Int32" />
                 <asp:Parameter Name="Original_hotel_CodigoHotel" Type="String" />
                 <asp:Parameter Name="Original_estadoHabitacion_idEstado" Type="Int32" />
             </UpdateParameters>
    
          </asp:ObjectDataSource>
        </form>
</asp:Content>
