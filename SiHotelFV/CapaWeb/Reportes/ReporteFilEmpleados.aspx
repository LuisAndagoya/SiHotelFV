<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteFilEmpleados.aspx.cs" Inherits="CapaWeb.Reportes.ReporteFilEmpleados" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-header">Reporte Empleados</h4>

                <form id="form1" class="forms-sample" runat="server">

                    <asp:ScriptManager runat="server"></asp:ScriptManager>
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </div>


                    <table style="border-top: hidden">
                        <tr>
                            <td>
                                <label for="ListaEmpleado">Cargo:</label></td>

                            <td>

                                <asp:DropDownList ID="ListaEmpleado" class="form-control" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Button class="btn btn-gradient-info btn-sm" ID="Button1" runat="server"
                                    Text="Filtrar" OnClick="Button1_Click" />
                            </td>
                            <td>

                                <a href="ReporteEmpleados.aspx" class="btn btn-gradient-info btn-sm">Listar Todos</a></td>
                        </tr>    
                        <tr>

                            
                            <td>
                                <label for="ListaEmpleado">Fecha Ingreso:</label></td>
                            
                        
                            <td>

                                <asp:TextBox type="date"  ID="fechInicio" class="form-control" runat="server"></asp:TextBox>
                            </td>
                             <td>
                                <asp:Button class="btn btn-gradient-info btn-sm" ID="Button2" runat="server"
                                    Text="Buscar" OnClick="Button2_Click" />
                            </td>

                        </tr>            

                        <tr>
                            <td  colspan="4">
                                <asp:Label Visible="false" ID="lblId" runat="server" Text=""></asp:Label>
                                <asp:TextBox Visible="false" ID="TextBox1" runat="server"></asp:TextBox>
                                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="550px" Width="100%">
                                    <LocalReport ReportPath="Reportes\Empleado.rdlc">
                                        <DataSources>
                                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetCargo" />
                                        </DataSources>
                                    </LocalReport>
                                </rsweb:ReportViewer>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Cargo"
                                    TypeName="CapaProceso.Clases.ReporteEmpleado" OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="ListaEmpleado" Name="Id" PropertyName="SelectedValue" Type="Int16" />
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
