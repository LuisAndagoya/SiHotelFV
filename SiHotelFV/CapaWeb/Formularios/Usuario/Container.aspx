<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Usuario.Container" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-8 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">USUARIO</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="form-group">
                        <label for="usernameUsuario">Usuario</label>
                        <asp:TextBox ID="usernameUsuario" class="form-control" required="required" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="passwordUsuario">Contraseña</label>
                        <asp:TextBox ID="passwordUsuario" class="form-control" type="password" pattern="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$" placeholder="Ejm: Carlos@12" required="required" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="ListaEmpleado">Empleado</label>
                        <asp:DropDownList class="form-control" ID="ListaEmpleado" runat="server">
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="ListaCargo">Cargo</label>
                        <asp:DropDownList class="form-control" ID="ListaCargo" runat="server">
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="DropDownList1">Estado</label>
                        <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                            <asp:ListItem Selected="True" Value="A">ACTIVO</asp:ListItem>
                            <asp:ListItem Value="I">INACTIVO</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <asp:Label Visible="false" ID="lblId" runat="server" Text=""></asp:Label>

                    <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
                    <a href="Index.aspx" class="btn btn-light">Cancelar</a>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
