<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteReservaFil.aspx.cs" Inherits="CapaWeb.Reportes.ReporteReservaFil" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">RESERVACIÓN</h4>

                <form id="form1" class="forms-sample" runat="server">

                    <asp:ScriptManager runat="server"></asp:ScriptManager>
                       <table style="border-top: hidden">
                        <tr>
                            <td>
                                <label for="FechaEntrada">Fecha Entrada:</label></td>

                            <td>

                                <asp:TextBox type="date"  ID="fechEntrada" class="form-control" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button class="btn btn-gradient-info btn-sm" ID="Button1" runat="server"
                                    Text="Filtrar" OnClick="Button1_Click" />
                            </td>
                         
                        </tr>                
                               <tr>
                            <td>
                                 <label for="ListaUsuario">Usuario:</label></td>

                            <td>

                                   <asp:DropDownList ID="ListaUsuario" class="form-control" runat="server">
                                  </asp:DropDownList>
                            </td>
                            <td>
                              
									  <asp:Button class="btn btn-gradient-info btn-sm" ID="Button2" runat="server" 
                                  Text="Filtrar" onclick="Button2_Click" />
                            </td>
                            
                         </tr>

                                        <tr>
                            <td>
                                 <label for="ListaUsuario">Estado:</label></td>

                            <td>

                                   <asp:DropDownList ID="ListaEstado" class="form-control" runat="server">
                                  </asp:DropDownList>
                            </td>
                            <td>
                              
									  <asp:Button class="btn btn-gradient-info btn-sm" ID="Button3" runat="server" 
                                  Text="Filtrar" onclick="Button3_Click" />
                            </td>
                            
                         </tr>

                           
                                        <tr>
                            <td>
                                 <label for="ListaUsuario">Cliente CI:</label></td>

                            <td>
                                <asp:TextBox ID="Cliente" class="form-control" runat="server"></asp:TextBox>
                                   
                            </td>
                            <td>
                              
									  <asp:Button class="btn btn-gradient-info btn-sm" ID="Button4" runat="server" 
                                  Text="Filtrar" onclick="Button4_Click" />
                            </td>
                            
                         </tr>
                        <tr>
                            <td  colspan="4">
                                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="550px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="800px">
                                    <LocalReport ReportPath="Reportes\ReservaFecha.rdlc">
                                        <DataSources>
                                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetFecha" />
                                        </DataSources>
                                    </LocalReport>
                                </rsweb:ReportViewer>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="Fecha" TypeName="CapaDatos.Clases.ReporteReservaTableAdapters.reservasTableAdapter" UpdateMethod="Update">
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
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="fechEntrada" Name="Fecha1" PropertyName="Text" Type="String" />
                                    </SelectParameters>
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
                            </td>
                        </tr>

                    </table>





                    </form>
                            </div>
        </div>
    </div>
</asp:Content>
