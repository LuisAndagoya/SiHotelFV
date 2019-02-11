<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contrasenia.aspx.cs" Inherits="CapaWeb.Contrasenia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="col-md-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-header">Actualizar Contraseña</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="form-group">
                        <label for="nombreTipo">Contraseña Actual</label>
                        <asp:TextBox ID="actual" class="form-control" type="password" required="required" runat="server"></asp:TextBox>

                    </div>


                    <div class="form-group">
                        <label for="ListaPrecio">Nueva Contraseña</label>
                        <asp:TextBox ID="nueva" class="form-control" type="password" pattern="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$" placeholder="Ejm: Carlos@12" required="required" runat="server"></asp:TextBox>
                    </div>



                    <%--<asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server"  Text="Guardar" onclick="Button1_Click" />--%>
                    <asp:LinkButton ID="Button1" runat="server" required="required" CssClass="btn btn-icon-text btn-gradient-info btn-sm" Text="<span class='mdi mdi-content-save btn-icon-prepend mdi-24px'>&nbsp;Guardar</span>" OnClick="Button1_Click" />
                    <a href="inicio.aspx" class="btn btn-secondary text-dark btn-icon-text btn-sm">
                        <i class=" mdi mdi-cancel btn-icon-prepend mdi-24px"></i>Cancelar
                    </a>



                    <asp:Label Visible="false" ID="lblId" runat="server" Text=""></asp:Label>

                </form>
            </div>
        </div>
    </div>


</asp:Content>
