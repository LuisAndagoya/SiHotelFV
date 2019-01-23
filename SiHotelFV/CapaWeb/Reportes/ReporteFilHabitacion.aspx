<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteFilHabitacion.aspx.cs" Inherits="CapaWeb.Reportes.ReporteFilHabitacion" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title"> REPORTE HABITACIÓN</h4>

                <form id="form1" class="forms-sample" runat="server">

                     <asp:ScriptManager runat="server"></asp:ScriptManager>
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
         
                    <div class="form-group">
                        <label for="ListaHabitacion">Tipo Habitación</label>
                         <asp:DropDownList ID="ListaHabitacion" class="form-control" runat="server">
                      </asp:DropDownList>

                    </div>
                      <div class="form-group">
                        <label for="ListaEstado">Estado Habitación</label>
                         <asp:DropDownList ID="ListaEstado" class="form-control" runat="server">
                      </asp:DropDownList>

                    </div>

   
                          <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" 
                          Text="Reporte Habitacion" onclick="Button1_Click" />
                      <a href="Habitacion.aspx" class="btn btn-light">Todas</a>
      <asp:Button class="btn btn-gradient-primary mr-2" ID="Button2" runat="server" 
                          Text="Reporte Estado" onclick="Button2_Click" />

        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
             
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="500px" Width="100%">
                        <LocalReport ReportPath="Reportes\ReporteHabitacion.rdlc">
                             <DataSources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                            </DataSources>
                        </LocalReport>
                     </rsweb:ReportViewer>
                   


                     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Reporte" TypeName="CapaDatos.Clases.ReporteHabitacionTableAdapters.habitacionTableAdapter" DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
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
                         <SelectParameters>
                             <asp:ControlParameter ControlID="ListaHabitacion" Name="Id" PropertyName="SelectedValue" Type="String" />
                         </SelectParameters>
                      
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
            </div>
        </div>
    </div>
</asp:Content>
