<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaWeb.Formularios.Reserva.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">

        function CambiarReserva() {
            var respuesta;
            if (confirm('¿Desea cambiar de estado la reserva?')){
                respuesta = true;
            }else{
            respuesta = false;
        }

                return respuesta;
                       
        }

        function AnularReserva() {
            var respuesta;
            if (confirm('¿Desea anular la reserva?')) {
                respuesta = true;
            } else {
                respuesta = false;
            }

            return respuesta;          

        }
        </script>

 <div class="row">
        <div class="col-lg-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                     <h4 class="card-title">Reservación</h4>
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
                                                                <asp:Button ID="Button1" class="btn btn-sm btn-gradient-primary" required ="required" runat="server" Text="Buscar"
                                                                    OnClick="Button1_Click" />
                                                            </div>
                                                                <div class="input-group-append">
                                                                   <asp:Button ID="Button2" class="btn btn-sm btn-gradient-primary" required ="required" runat="server" Text="Agregar"
                                                                    OnClick="Button2_Click" />                                                                  
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
                                                    <asp:ImageButton ID="imgEstado" runat="server" CausesValidation="false" CommandName="Estado"
                                                        ImageUrl="~/img/accept.png"  ToolTip="Cambiar estado reserva" Width="16" OnClientClick="if ( !CambiarReserva()) return false;"  />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgFac" runat="server" CausesValidation="false" CommandName="Factura"
                                                        ImageUrl="~/img/Pdf.png" ToolTip="Factura" Width="16" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn HeaderText="id" Visible="False">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="lblId" runat="server" Text='<%#Eval("idReservacion") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                              <asp:TemplateColumn HeaderText="idEstadoHabitacion" Visible="false">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="idEstadoReserva" runat="server" Text='<%#Eval("idEstadoReserva") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                              <asp:TemplateColumn HeaderText="Identificación" >
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="dniCliente" runat="server" Text='<%#Eval("dniCliente") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                            <asp:TemplateColumn HeaderText="Nombre" >
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="nombreCliente" runat="server" Text='<%#Eval("nombreCliente") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>


                                              <asp:TemplateColumn HeaderText="Apellido">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="apellidoCliente" runat="server" Text='<%#Eval("apellidoCliente") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                         
                                                  <asp:TemplateColumn HeaderText="Fecha Reservación">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="fechaReservacion" runat="server" Text='<%#Eval("fechaReservacion") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                             
                                                 <asp:TemplateColumn HeaderText="Estado">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="nombreEstado" runat="server" Text='<%#Eval("nombreEstado") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            
                                              <asp:TemplateColumn HeaderText="Total">
                                                <ItemTemplate>
                                                    <span style="float: left;">
                                                        <asp:Label ID="totalReservacion" runat="server" Text='<%#Eval("totalReservacion") %>'></asp:Label>
                                                    </span>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>

                                          <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgEliminar" runat="server" CausesValidation="false" CommandName="Eliminar"
                                                        ImageUrl="~/img/ActionDelete.png"  ToolTip="Anular reserva" Width="16" OnClientClick="if ( !AnularReserva()) return false;"  />
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
