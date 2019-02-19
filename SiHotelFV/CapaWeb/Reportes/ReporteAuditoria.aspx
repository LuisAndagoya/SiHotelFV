<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteAuditoria.aspx.cs" Inherits="CapaWeb.Reportes.ReporteAuditoria" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div class="col-md-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">AUDITORÍA</h4>
      <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>

             
                    <table style="border-top: hidden">
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

                            <td>

                                <a href="GeneralAuditoria.aspx" class="btn btn-gradient-dark btn-sm">Listar Todos</a></td>
                            </tr>
                        <tr>
                            <td>
                                <label for="ListaEmpleado">Fecha Inicio:</label></td>
                            
                        
                            <td>

                                <asp:TextBox type="date"  ID="fechInicio" class="form-control" runat="server"></asp:TextBox>
                            </td>

                             <td>
                                <label for="ListaEmpleado">Fecha Fin:</label></td>

                            <td>

                                <asp:TextBox type="date"  ID="fechaFin" class="form-control" runat="server"></asp:TextBox>
                            </td>

                            <td>
                                <asp:Button class="btn btn-gradient-info btn-sm" ID="Button1" runat="server"
                                    Text="Buscar" OnClick="Button1_Click" />
                            </td>
                            

         
                        </tr>                

                        <tr>
                            <td  colspan="4">
                                <asp:Label Visible="false" ID="lblId" runat="server" Text=""></asp:Label>
                                <asp:TextBox Visible="false" ID="TextBox1" runat="server"></asp:TextBox>
                                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="550px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="600px">
                                    <LocalReport ReportPath="Reportes\ReporteAuditoria.rdlc">
                                        <DataSources>
                                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                                        </DataSources>
                                    </LocalReport>
                                </rsweb:ReportViewer>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="Reporte" TypeName="CapaDatos.Clases.AuditoriaTableAdapters.auditoriaTableAdapter" UpdateMethod="Update">
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
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="fechInicio" Name="Inicio" PropertyName="Text" Type="DateTime" />
                                        <asp:ControlParameter ControlID="fechaFin" Name="Fin" PropertyName="Text" Type="DateTime" />
                                    </SelectParameters>
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
                            </td>
                        </tr>

                    </table>

          </form>
                        </div>
        </div>
    </div>
</asp:Content>
