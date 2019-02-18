<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Reserva.Container" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">

        function FechaReserva() {

            var fechareserva = document.getElementById("<%= fechaReservacion.ClientID %>").value;
            document.getElementById("<%= fechaEntrada.ClientID %>").value = fechareserva;
        }

        function validarFormulario() {
            var respuesta = false;
            var excedula = /^[0-9]{10}$/;
            var exnombre = /^[\ s A-z ]*$/;
            var exemail = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;


            var dniClienteM = $("#<%=dniClienteM.ClientID%>").val();
            if (dniClienteM == null || dniClienteM.length == 0 || /^\s*$/.test(dniClienteM) || !excedula.test(dniClienteM)) {
                alert('Error: El formato de la cedula es incorrecto');
                respuesta = true;
            }

            var nombreClienteM = $("#<%=nombreClienteM.ClientID%>").val();
            if (nombreClienteM == null || nombreClienteM.length == 0 || /^\s*$/.test(nombreClienteM) || !exnombre.test(nombreClienteM)) {
                alert('Error: El formato del nombre es incorrecto');
                respuesta = true;
            }

            var apellidoClienteM = $("#<%=apellidoClienteM.ClientID%>").val();
            if (apellidoClienteM == null || apellidoClienteM.length == 0 || /^\s*$/.test(apellidoClienteM) || !exnombre.test(apellidoClienteM)) {
                alert('Error: El formato del apellido es incorrecto');
                respuesta = true;
            }

            var direccionCliente = $("#<%=direccionCliente.ClientID%>").val();
            if (direccionCliente == null || direccionCliente.length == 0 || /^\s*$/.test(direccionCliente)) {
                alert('Error: Ingrese la dirección');
                respuesta = true;
            }

            var telefonoCliente = $("#<%=telefonoCliente.ClientID%>").val();
            if (telefonoCliente == null || telefonoCliente.length == 0 || /^\s*$/.test(telefonoCliente) || !excedula.test(telefonoCliente)) {
                alert('Error: El formato del telefono es incorrecto');
                respuesta = true;
            }

            var correoCliente = $("#<%=correoCliente.ClientID%>").val();
            if (correoCliente == null || correoCliente.length == 0 || /^\s*$/.test(correoCliente) || !exemail.test(correoCliente)) {
                alert('Error: El formato del email es incorrecto');
                respuesta = true;
            }

            return respuesta;
        }

    </script>
    <div class="col-12 grid-margin">
        <div class="card">
            <div class="card-body">
                <h4 class="card-header">Reservación</h4>

                <form id="form1" class="forms-sample" runat="server">

                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                    <%-- primera fila--%>
                    <div class="row ">
                        <%--primer grupo--%>
                        <div class=" col-12 col-md-6">
                            <div class="row col-12 form-group ">
                                <div class="row col-12 input-group ">
                                    <label for="fechaReservacion" class="col-12 col-md-5">Fecha Reserva:</label>
                                    <asp:TextBox type="date" onkeyup="FechaReserva();" ReadOnly="true" required="required" ID="fechaReservacion" class="col-12 col-md-7 " runat="server" ></asp:TextBox>
                                </div>
                                <div class=" col-12 col-md-6">
                                    <label for="fechaEntrada">Fecha Entrada</label>
                                    <asp:TextBox type="date" required="required" ID="fechaEntrada" class=" form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-12 col-md-6">
                                    <label for="fechaSalida">Fecha Salida</label>
                                    <asp:TextBox type="date" required="required" ID="fechaSalida" class="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class=" col-12 col-md-6">
                            <%--segundo grupo--%>
                            <div class="row col-12 form-group">
                                <div class=" col-12">
                                    <div class="input-group">
                                        <label for="dniCliente">Cliente: &nbsp;</label>
                                        <asp:TextBox placeholder="Cedula" required="required" ID="dniCliente" class=" form-control" runat="server" OnTextChanged="dniCliente_TextChanged" AutoPostBack="true"></asp:TextBox>
                                        <div class="input-group-append">

                                            <asp:LinkButton ID="btnDelete"
                                                runat="server"
                                                CssClass="btn btn-gradient-info btn-icon "
                                                Text="<span class='mdi mdi-account-multiple-outline mdi-36px'></span>"
                                                Visible="true"
                                                ToolTip="Cear cliente"
                                                data-toggle="modal"
                                                data-target="#DeleteModal">
                                                
                                            </asp:LinkButton>
                                        </div>
                                    </div>
                                </div>
                                <asp:Label ID="idCliente" required="required" runat="server" Text="" Visible="False"></asp:Label>
                                <div class="  col-12 col-md-6">
                                    <label for="nombreCliente">Nombres</label>
                                    <asp:TextBox required="required" ID="nombreCliente" class=" form-control" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class=" col-12 col-md-6">
                                    <label for="apellidoCliente">Apellidos</label>
                                    <asp:TextBox required="required" ID="apellidoCliente" class="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            <%--  hasta aqui grupo dos--%>
                        </div>
                    </div>
                    <%-- segunda fila--%>
                    <div class="row">
                        <div class="col-12 col-md-6">
                            <div class="row col-12 form-group">
                                <div class="col-12 col-md 6 input-group">
                                    <label for="ListaHabitacion" class="col-12">Habitación N°</label>
                                    <asp:DropDownList ID="ListaHabitacion" required="required" class="form-control" runat="server" OnTextChanged="ListaHabitacion_TextChanged" AutoPostBack="true">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-12 col-md-6 input-group">
                                    <label for="valor" class="col-12">Precio</label>
                                    <asp:TextBox type="number" min="0.00" step="0.01" ID="valor" class="form-control" runat="server"></asp:TextBox>
                                </div>

                            </div>

                        </div>
                        <div class="col-12 col-md-6">
                            <div class="row col-12 form-group">
                                <div class="col-12 col-md-12 input-group">
                                    <label for="PagadoReserva" class="col-12">Pago Reservación</label>
                                    <asp:TextBox type="number" min="0.00" step="0.01" ID="PagadoReserva" required="required" class="form-control" runat="server" OnTextChanged="PagadoReserva_TextChanged" AutoPostBack="true" TextMode="Number"></asp:TextBox>
                                </div>

                            </div>

                        </div>

                    </div>

                    <%--tercera fila--%>
                    <div class="row">
                        <div class="col-12 col-md-6">
                            <div class="row col-12 form-group ">
                                <div class="row mx-auto border">
                                    <asp:Button class="btn btn-sm btn-gradient-info btn-icon-text" ID="Button2" runat="server" Text="Agregar Habitación" OnClick="Button2_Click" />
                                </div>
                                 
                            </div>
                        </div>
                        <div class="col-12 col-md-6">
                            <div class="row col-12 form-group">
                                <div class="col-12 col-md 6 input-group">
                                    <label for="idEstadoReserva">Estado</label>
                                    <asp:DropDownList ID="idEstadoReserva" class="form-control" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                    </div>


                    <table class=" table">

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

                                        <asp:TemplateColumn HeaderText="Tipo">
                                            <ItemTemplate>
                                                <span style="float: left;">
                                                    <asp:Label ID="Tipo" runat="server" Text='<%#Eval("Tipo") %>'></asp:Label>
                                                </span>
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

                        <tr align="right">
                            <td>
                                <table style="border-top: hidden">
                                    <tr>
                                        <td>

                                            <label for="totalReservacion">Total Reservación</label></td>
                                        <td>
                                            <asp:TextBox ID="totalReservacion" ReadOnly="true" required="required" class="form-control" runat="server"></asp:TextBox></td>
                                    </tr>
                                    <tr>
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
                                            <asp:Button class="btn btn-gradient-info mr-2" ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" /></td>
                                        <td>
                                            <asp:Button class="btn btn-gradient-secondary btn-fw" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="Cancelar_Click" UseSubmitBehavior="False" /></td>

                                    </tr>

                                </table>
                            </td>


                        </tr>
                    </table>

                    <!-- Delete Modal Begin-->
                    <div class="modal fade" id="DeleteModal" tabindex="-1" role="dialog" data-backdrop="static">
                        <div class="modal-dialog modal-lg" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h4 class="modal-title">Crear Cliente</h4>
                                    <button type="button" class="close btn btn-gradient-danger" data-dismiss="modal" aria-hidden="true">&times;</button>

                                </div>
                                <div class="modal-body">
                                    <div class="col-12 grid-margin">
                                        <div class="card">
                                            <div class="card-body">

                                                <div class="row col-12">
                                                    <div class="col-12 col-md-4">
                                                        <label for="dniCliente">Cédula</label>
                                                        <asp:TextBox ID="dniClienteM" class="col-12 col-md-12 form-control form-control-sm" pattern="^[0-9]{10}$" runat="server"></asp:TextBox>

                                                    </div>
                                                    <div class="col-12 col-md-4">
                                                        <label for="nombreCliente">Nombre</label>
                                                        <asp:TextBox ID="nombreClienteM" class="col-12 col-md-12 form-control form-control-sm" pattern="^[\ s A-z ]*$" runat="server"></asp:TextBox>
                                                    </div>
                                                    <div class="col-12 col-md-4">
                                                        <label for="apellidoCliente">Apellido</label>
                                                        <asp:TextBox ID="apellidoClienteM" class="col-12 col-md-12 form-control form-control-sm" pattern="^[\ s A-z ]*$" runat="server"></asp:TextBox>
                                                    </div>

                                                </div>

                                                <div class="row col-12">
                                                    <div class="col-12 col-md-8">
                                                        <label for="direccionCliente">Dirección</label>
                                                        <asp:TextBox ID="direccionCliente" class="col-12 col-md-12 form-control form-control-sm" runat="server"></asp:TextBox>
                                                    </div>
                                                    <div class="col-12 col-md-4">
                                                        <label for="telefonoCliente">Teléfono</label>
                                                        <asp:TextBox ID="telefonoCliente" class="form-control form-control-sm" pattern="^[0-9]{10}$" placeholder="Ejm: 0992333333" runat="server"></asp:TextBox>
                                                    </div>
                                                </div>

                                                <div class="row col-12">
                                                    <div class="col-12 col-md-4">
                                                        <label for="correoCliente">Email</label>
                                                        <asp:TextBox ID="correoCliente" type="email" class="form-control form-control-sm" runat="server"></asp:TextBox>
                                                    </div>
                                                    <div class="col-12 col-md-4">
                                                        <label for="sexoCliente">Sexo</label>
                                                        <asp:DropDownList ID="sexoCliente" class="col-12 col-md-12 form-control form-control-sm" runat="server">
                                                            <asp:ListItem Selected="True" Value="M">MASCULINO</asp:ListItem>
                                                            <asp:ListItem Value="F">FEMENINO</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>
                                                    <div class="col-12 col-md-4">
                                                        <label for="estadoCliente">Estado</label>
                                                        <asp:DropDownList ID="estadoCliente" class="col-12 col-md-12 form-control form-control-sm" runat="server">
                                                            <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                                                            <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>

                                                        </asp:DropDownList>
                                                    </div>

                                                </div>

                                                <asp:Label ID="LblError" runat="server"></asp:Label>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="Button3" OnClick="GuardarCliente" runat="server" Class="btn btn-gradient-info btn-sm" Text="Guardar" UseSubmitBehavior="False" OnClientClick="if (validarFormulario() == true) return(true)" />
                                    <button type="button" class="btn btn-gradient-secondary btn-sm" data-dismiss="modal">Cancelar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Delete Modal End -->

                </form>
            </div>
        </div>
    </div>
</asp:Content>
