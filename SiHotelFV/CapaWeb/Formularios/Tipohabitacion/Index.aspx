<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaWeb.Formularios.Tipohabitacion.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-header">Administrar Tipo Habitación</h4>
                    <form id="Form1" runat="server">
                        <table class="table">
                            <tr>
                                <td>
                                    <!-- Cabezera-->

                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="TxtBuscar" placeholder="Buscar..." runat="server" />
                                        <div class="input-group-append">
                                            <%-- <asp:Button ID="Button1" class="btn btn-sm btn-gradient-primary" required ="required" runat="server" Text="Buscar"
                                                                    OnClick="Button1_Click" />--%>
                                            <asp:LinkButton ID="Button1" runat="server" required="required" CssClass="btn btn-sm btn-gradient-info btn-icon-text" Text="<span class='mdi mdi-account-search btn-icon-prepend mdi-24px'>&nbsp; Buscar</span>" OnClick="Button1_Click" />
                                        </div>
                                        <div class="input-group-append">
                                            <%--<asp:Button ID="Button2" class="btn btn-sm btn-gradient-primary" required ="required" runat="server" Text="Agregar"
                                                                    OnClick="Button2_Click" />  --%>
                                            <asp:LinkButton ID="Button2" runat="server" required="required" CssClass="btn btn-sm btn-gradient-info btn-icon-text" Text="<span class='mdi mdi-account-plus btn-icon-prepend mdi-24px'>&nbsp; Agregar</span>" OnClick="Button2_Click" />
                                        </div>
                                    </div>

                                    <!-- Cabezera-->

                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <!--Detalle-->

                                    <asp:DataGrid ID="Grid" runat="server" onrowcreated="GriTipoUsuario_RowCreated"
                                        onrowcommand="GriTipoUsuario_RowCommand"
                                        AutoGenerateColumns="False" AllowPaging="True" class="table table-hover"
                                        OnItemCommand="Grid_ItemCommand" AllowSorting="True" ShowFooter="True"
                                        OnPageIndexChanged="Grid_PageIndexChanged" PageSize="8" CellPadding="1" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="0px">


                                        <Columns>


                                            <asp:TemplateColumn HeaderText="id" Visible="False">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="lblId" runat="server" Text='<%#Eval("idtipo") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn HeaderText="Tipo">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="nombreTipo" runat="server" Text='<%#Eval("nombreTipo") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>


                                            <asp:TemplateColumn HeaderText="Precio">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="precioHabitacion" runat="server" Text='<%#Eval("precioHabitacion") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>


                                            <asp:TemplateColumn HeaderText="N° Personas">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="maximoTipo" runat="server" Text='<%#Eval("maximoTipo") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            
                                            <asp:TemplateColumn HeaderText="Estado">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="estadoTipo" runat="server" Text='<%#Eval("estadoTipo") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>


                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgEliminar" runat="server" CausesValidation="false" CommandName="Eliminar"
                                                        ImageUrl="~/img/delete_opt.png" ToolTip="Eliminar" Width="16" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgEditar" runat="server" CausesValidation="false" CommandName="Editar"
                                                        ImageUrl="~/img/editregistro.png" ToolTip="Editar" Width="16" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                        </Columns>


                                        <FooterStyle BackColor="White" ForeColor="#00000f" />
                                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                        <ItemStyle ForeColor="#00000f" />
                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
                                        <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />


                                    </asp:DataGrid>
                                </td>
                            </tr>

                        </table>
                    </form>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
