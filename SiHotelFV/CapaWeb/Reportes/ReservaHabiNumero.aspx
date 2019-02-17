<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservaHabiNumero.aspx.cs" Inherits="CapaWeb.Reportes.ReservaHabiNumero" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">HABITACIÓN POR FECHA DE RESERVACIÓN  </h4>

                <form id="form1" class="forms-sample" runat="server">
                    <asp:ScriptManager runat="server"></asp:ScriptManager>
                       <table style="border-top: hidden">
                         <tr>
                            <td>
                                 <label for="ListaHabitacion">N° Habitación:</label></td>

                            <td>

                                   <asp:DropDownList ID="ListaHabitacion" class="form-control" runat="server">
                                  </asp:DropDownList>
                            </td>
                            <td>
                              
									  <asp:Button class="btn btn-gradient-info btn-sm" ID="Button2" runat="server" 
                                  Text="Filtrar" onclick="Button2_Click" />
                            </td>
                            
                         </tr>

                           <tr>
                            <td>
                                <label for="Desde">Desde:</label></td>

                            <td>

                                <asp:TextBox type="date"  ID="fechaDesde" class="form-control" runat="server"></asp:TextBox>
                            </td>

                                   <td>
                                <label for="Hasta">Hasta:</label></td>

                            <td>

                                <asp:TextBox type="date"  ID="fechaHasta" class="form-control" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button class="btn btn-gradient-info btn-sm" ID="Button1" runat="server"
                                    Text="Filtrar" OnClick="Button1_Click" />
                            </td>

                               <td>
								 
								 <a href="ReservaListar.aspx" class="btn btn-gradient-dark btn-sm">Listar Todos</a></td>
                         
                        </tr>                
                            <tr>
                            <td  colspan="4">
                 <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
                    <asp:TextBox Visible="false" ID="TextBox1" runat="server"></asp:TextBox>
                                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="550px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="700px">
                                    <LocalReport ReportPath="Reportes\ReservacionFEc.rdlc">
                                        
                                        <DataSources>
                                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetFecha" />
                                        </DataSources>
                                        
                                    </LocalReport>
                                </rsweb:ReportViewer>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="Fecha" TypeName="CapaDatos.Clases.DetalleReservaTableAdapters.detalle_reservaTableAdapter" UpdateMethod="Update">
                                   
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="fechaDesde" Name="Inicio" PropertyName="Text" Type="String" />
                                        <asp:ControlParameter ControlID="fechaHasta" Name="Fin" PropertyName="Text" Type="String" />
                                    </SelectParameters>
                                   
                                </asp:ObjectDataSource>
                            </td>
                        </tr>

                        </table>

                </form>
             </div>
        </div>
    </div>
</asp:Content>
