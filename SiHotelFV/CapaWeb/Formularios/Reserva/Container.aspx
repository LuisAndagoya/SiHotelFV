﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Reserva.Container" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-12 grid-margin">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">Reservaciones</h4>

                <form id="form1" class="forms-sample" runat="server">

                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <table class=" table">
                        <tr>
                            <td>
                                <table style="border-top: hidden">
                                    <tr>
                                        <td>
                                            <label for="dniCliente">Cliente</label></td>
                                        <td>
                                            <asp:Label ID="idCliente" runat="server" Text="" Visible="False"></asp:Label>
                                            <asp:TextBox required="required" ID="dniCliente" class="form-control" runat="server" OnTextChanged="dniCliente_TextChanged" AutoPostBack="true"></asp:TextBox>
                                        <td>

                                            <label for="nombreCliente">Nombres</label></td>
                                        <td>
                                            <asp:TextBox required="required" ID="nombreCliente" class="form-control" runat="server" ReadOnly="true"></asp:TextBox>

                                        <td>

                                            <label for="apellidoCliente">Apellidos</label></td>
                                        <td>
                                            <asp:TextBox required="required" ID="apellidoCliente" class="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                                    </tr>

                                </table>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <table style="border-top: hidden">
                                    <tr>

                                        <td>
                                            <label for="fechaReservacion">Fecha Reserva</label></td>
                                        <td>
                                            <asp:TextBox type="date" required="required" ID="fechaReservacion" class="form-control" runat="server"></asp:TextBox></td>

                                        <td>

                                            <label for="fechaEntrada">Fecha Entrada</label></td>
                                        <td>
                                            <asp:TextBox type="date" required="required" ID="fechaEntrada" class="form-control" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <label for="fechaSalida">Fecha Salida</label></td>
                                        <td>
                                            <asp:TextBox type="date" required="required" ID="fechaSalida" class="form-control" runat="server"></asp:TextBox></td>


                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <label for="idEstadoReserva">Estado</label>
                                        <td>

                                        <td>
                                            <asp:DropDownList ID="idEstadoReserva" class="form-control" runat="server">
                                            </asp:DropDownList>
                                        </td>

                                        <td>
                                            <label for="PagadoReserva">Pago Reservación</label></td>
                                        <td>

                                            <asp:TextBox type="number" min="0.00" step="0.01" ID="PagadoReserva" required="required" class="form-control" runat="server" OnTextChanged="PagadoReserva_TextChanged" AutoPostBack="true"></asp:TextBox></td>
                                    </tr>
                                </table>

                            </td>

                        </tr>
                        <tr>
                            <td>
                                <table style="border-top: hidden">
                                    <tr>
                                        <td>

                                            <label for="totalReservacion">Total Reservación</label></td>
                                        <td>
                                            <asp:TextBox ID="totalReservacion" ReadOnly="true" required="required" class="form-control" runat="server"></asp:TextBox></td>

                                        <td>
                                            <label for="SaldoReserva">Saldo Reservación</label></td>
                                        <td>
                                            <asp:TextBox ID="SaldoReserva" ReadOnly="true" required="required" class="form-control" runat="server"></asp:TextBox></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table style="border-top: hidden">
                                    <tr>
                                        <td>
                                            <td>
                                                <label for="ListaHabitacion">N° Habitación</label></td>
                                            <td colspan="2">
                                                <asp:DropDownList ID="ListaHabitacion" required="required" class="form-control" runat="server" OnTextChanged="ListaHabitacion_TextChanged" AutoPostBack="true">
                                                </asp:DropDownList></td>
                                            <td>
                                                <label for="valor">Precio</label></td>
                                            <td>
                                                <asp:TextBox type="number" min="0.00" step="0.01" ID="valor" required="required" class="form-control" runat="server"></asp:TextBox></td>
                                            <td>
                                                <asp:Button class="btn btn-gradient-dark btn-icon-text" ID="Button2" runat="server"
                                                    Text="Agregar Habitación" OnClick="Button2_Click" /></td>
                                        </td>
                                    </tr>
                                </table>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <h5 class="card-title">Detalle Reservaciones</h5>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="Grid" runat="server"
                                    AutoGenerateColumns="False" class="table table-hover"
                                    OnItemCommand="Grid_ItemCommand" AllowSorting="True" ShowFooter="True"
                                    PageSize="8" CellPadding="1" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="0px">


                                    <Columns>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:ImageButton ID="imgEliminar" runat="server" CausesValidation="false" CommandName="Eliminar"
                                                    ImageUrl="~/img/ActionDelete.png" ToolTip="Eliminar" Width="16" />
                                            </ItemTemplate>
                                        </asp:TemplateColumn>

                                        <asp:TemplateColumn HeaderText="Numero">
                                            <ItemTemplate>
                                                <span style="float: left;">
                                                    <asp:Label ID="numeroHabitacion" runat="server" Text='<%#Eval("numeroHabitacion") %>'></asp:Label>
                                                </span>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>

                                        <asp:TemplateColumn HeaderText="Valor">
                                            <ItemTemplate>
                                                <span style="float: left;">
                                                    <asp:Label ID="valor" runat="server" Text='<%#Eval("valor") %>'></asp:Label>
                                                </span>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>


                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                    <HeaderStyle BackColor="Gray" Font-Bold="True" ForeColor="White" />
                                    <ItemStyle ForeColor="#000066" />
                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
                                    <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />


                                </asp:DataGrid>

                            </td>
                        </tr>
                        <tr>
                            <td>

                                <table style="border-top: hidden">
                                    <tr>
                                        <td>
                                            <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server"
                                                Text="Guardar" OnClick="Button1_Click" /></td>
                                        <td>
                                           <asp:Button class="btn btn-gradient-light btn-fw" ID="btnCancelar" runat="server" 
                          Text="Cancelar" onclick="Cancelar_Click" />
                                            
                                    </tr>
                                </table>
                            </td>


                        </tr>
                    </table>

                </form>
            </div>
        </div>
    </div>
</asp:Content>
