﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteFilEmpleados.aspx.cs" Inherits="CapaWeb.Reportes.ReporteFilEmpleados" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
       <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">EMPLEADOS</h4>

                <form id="form1" class="forms-sample" runat="server">

                     <asp:ScriptManager runat="server"></asp:ScriptManager>
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
         
                    <div class="form-group">
                        <label for="ListaEmpleado">Empleado</label>
                         <asp:DropDownList ID="ListaEmpleado" class="form-control" runat="server">
                      </asp:DropDownList>
                        
                       
                          
                    </div>

   
                          <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" 
                          Text="Reporte Empleado" onclick="Button1_Click" />
                      <a href="ReporteEmpleados.aspx" class="btn btn-light">Reporte General</a>
 
        <asp:Label Visible ="false" ID="lblId" runat="server" Text=""></asp:Label>
                    <asp:TextBox Visible="false" ID="TextBox1" runat="server"></asp:TextBox>
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="500px" Width="100%">
                        <LocalReport ReportPath="Reportes\Nuevo.rdlc">
                             <DataSources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                            </DataSources>
                        </LocalReport>
                     </rsweb:ReportViewer>
                     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Reporte"
                        TypeName="CapaProceso.Clases.ReporteEmpleado" OldValuesParameterFormatString="original_{0}">
                         <SelectParameters>
                             <asp:ControlParameter ControlID="ListaEmpleado" Name="Id" PropertyName="SelectedValue" Type="Int16" />
                         </SelectParameters>
                         
                    </asp:ObjectDataSource>
              </form>
            </div>
        </div>
    </div>
</asp:Content>
