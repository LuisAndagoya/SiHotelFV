<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ver.aspx.cs" Inherits="CapaWeb.Formularios.Habitacion.Ver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-header">Detalle Habitación</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="row 12">
                        <div class="col-12 col-md-6">
                            <div class="form-group">
                                <label for="ListaHotel" >Hotel:</label>
                                <asp:Label ID="lblHotel" runat="server" CssClass="h5"></asp:Label>
                                <asp:DropDownList ID="ListaHotel" required="required" class="form-control" runat="server" Visible="false">
                                </asp:DropDownList>

                            </div>
                            <div class="form-group">
                                <label for="imagenEmpleado">Imagen</label>
                                <asp:Image ID="imagenTipo" runat="server" class="form-control" ImageUrl='<%# Eval("imagenTipo", "imagen.ashx?id={0}") %>' Width="400px" Height="200px" />
                            </div>


                        </div>
                        <div class="col-12 col-md-6">
                            <div class="form-group">
                                <label for="numeroHabitacion">Habitación N°:</label>
                                <asp:Label ID="lblNumeroHabitacion" runat="server" CssClass="h5"> </asp:Label>
                                <asp:TextBox ID="numeroHabitacion" class="form-control" type="number" required="required" runat="server" Visible="false"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="ListaTipo">Habitación Tipo:</label>
                                <asp:Label ID="lblTipoHabitacion" runat="server" CssClass="h5"> </asp:Label>
                                <asp:DropDownList ID="ListaTipo" required="required" class="form-control" runat="server" Visible="false">
                                </asp:DropDownList>
                            </div>

                            <div class="form-group">
                                <label for="ListaEstado">Descripción:</label>
                                <asp:Label ID="lblDescripcion" runat="server" CssClass="h5"> </asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="ListaEstado">Personas Máximo:</label>
                                <asp:Label ID="lblMaximoPersonas" runat="server" CssClass="h5"> </asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="ListaEstado">Habitación Precio $:</label>
                                <asp:Label ID="lblPrecioHabitacion" runat="server" CssClass="h5"> </asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="ListaEstado">Estado Actual:</label>
                                <asp:Label ID="lblEstadoHabitacion" runat="server" CssClass="h5"> </asp:Label>
                                <asp:DropDownList ID="ListaEstado" required="required" class="form-control" runat="server" Visible="false">
                                </asp:DropDownList>
                            </div>

                        </div>
                    </div>

                    <div class="row col-12">
                        <a href="Index.aspx" class="btn btn-sm btn-secondary text-dark btn-icon-text">
                            <i class="mdi mdi-exit-to-app btn-icon-prepend mdi-24px"></i>Regresar
                        </a>
                    </div>


                    <asp:Label Visible="false" ID="lblId" runat="server" Text=""></asp:Label>

                </form>
            </div>
        </div>
    </div>
</asp:Content>
