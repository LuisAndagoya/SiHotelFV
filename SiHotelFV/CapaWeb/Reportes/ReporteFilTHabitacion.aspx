﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteFilTHabitacion.aspx.cs" Inherits="CapaWeb.Reportes.ReporteFilTHabitacion" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <div class="col-md-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">REPORTE TIPO HABITACIÓN</h4>

     <form id="form1" class="forms-sample" runat="server">

        <asp:ScriptManager runat="server"></asp:ScriptManager>
       

           <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                     
                                          <table style="border-top: hidden">
                        <tr>
                            <td>
                             
								 <label for="ListaHabitacion">Por Tarifa</label></td>

                            <td>

                                    <asp:DropDownList ID="ListaHabitacion" class="form-control" runat="server">
                                    </asp:DropDownList>
                            </td>
                            <td>
							        <asp:Button class="btn btn-gradient-info btn-sm" ID="Button1" runat="server" 
                                   Text="Filtrar" onclick="Button1_Click" />
                            </td>
                            <td>
								 
								 <a href="ReporteTipoHab.aspx" class="btn btn-gradient-dark btn-sm">Listar Todos</a></td>
                         </tr>

                        <tr>
                            <td  colspan="4">
                 <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
                    <asp:TextBox Visible="false" ID="TextBox1" runat="server"></asp:TextBox>
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="550px" Width="700px">
                        <LocalReport ReportPath="Reportes\TipoHabitacionR.rdlc">
                             <DataSources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                            </DataSources>
                        </LocalReport>
                     </rsweb:ReportViewer>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Reporte1"
                        TypeName="CapaProceso.Clases.ReporteTipoHabitacion" OldValuesParameterFormatString="original_{0}">
                   <SelectParameters>
                             <asp:ControlParameter ControlID="ListaHabitacion" Name="Id" PropertyName="SelectedValue" Type="Int16" />
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

