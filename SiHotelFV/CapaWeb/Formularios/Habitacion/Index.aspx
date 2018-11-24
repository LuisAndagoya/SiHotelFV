<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaWeb.Formularios.Habitacion.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <div class="row">
        <div class="col-lg-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <form id="Form1" runat="server">
                        <table class="table">
                            <tr>
                                <td>
                                    <!-- Cabezera-->
                                    <div align="right">

                                     
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <asp:TextBox class="form-control" ID="TxtBuscar" placeholder="Buscar..." runat="server" />
                                                            <div class="input-group-append">
                                                                <asp:Button ID="Button1" class="btn btn-sm btn-gradient-primary" runat="server" Text="Buscar"
                                                                    OnClick="Button1_Click" />
                                                            </div>
                                                              <div class="input-group-append">
                                                                   <a href=" Container.aspx?TRN=INS&Id=" class="btn btn-sm btn-gradient-primary"><i class="mdi mdi-database-plus"></i>Agregar</a>
                                                                  </div>
                                                        </div>
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
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgEliminar" runat="server" CausesValidation="false" CommandName="Eliminar"
                                                        ImageUrl="~/img/ActionDelete.png" ToolTip="Editar" Width="16" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgEditar" runat="server" CausesValidation="false" CommandName="Editar"
                                                        ImageUrl="~/img/ActionUpdate.png" ToolTip="Editar" Width="16" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn HeaderText="id" Visible="False">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="lblId" runat="server" Text='<%#Eval("idHabitacion") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn HeaderText="N° Habitación">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="NumeroHab" runat="server" Text='<%#Eval("NumeroHab") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>


                                              <asp:TemplateColumn HeaderText="Piso">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="PisoHabitacion" runat="server" Text='<%#Eval("PisoHabitacion") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            
                                                <asp:TemplateColumn HeaderText="Tipo">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="TipoHab" runat="server" Text='<%#Eval("TipoHab") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                               <asp:TemplateColumn HeaderText="Costo Diario">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="CostoDiarioHab" runat="server" Text='<%#Eval("CostoDiarioHab") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            


                                            <asp:TemplateColumn HeaderText="Descripción">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="DescripcionHab" runat="server" Text='<%#Eval("DescripcionHab") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn HeaderText="Camas">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="NumeroCamasHab" runat="server" Text='<%#Eval("NumeroCamasHab") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            

                                              <asp:TemplateColumn HeaderText="Hotel">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="Hotel_codHotel" runat="server" Text='<%#Eval("NombreHotel") %>'></asp:Label>
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

                        </table>
                    </form>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
