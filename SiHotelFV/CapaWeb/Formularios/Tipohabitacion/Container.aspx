<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Tipohabitacion.Container" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-header">Tipo Habitación</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="row ">
                        <div class="row col-12 col-md-6">
                            <div class="form-group col-12">
                                <label for="nombreTipo">Tipo</label>
                                <asp:TextBox ID="nombreTipo" class=" form-control" required="required" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-12">
                                <label for="ListaPrecio">Precio</label>
                                <asp:DropDownList ID="ListaPrecio" required="required" class="form-control" runat="server">
                                </asp:DropDownList>
                            </div>

                            <div class="form-group col-12">
                                <label for="maximoTipo">Máximo Personas</label>
                                <asp:TextBox ID="maximoTipo" class="form-control" type="number" required="required" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-12">
                                <label for="estadoEmpleado">Estado</label>
                                <asp:DropDownList ID="estadoTipo" class="form-control" runat="server">
                                    <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                                    <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                                </asp:DropDownList>
                            </div>

                        </div>

                        <div class="row col-12 col-md-6">
                            <div class="form-group">
                                <div class="row col-12">
                                    <label for="imagenTipoHabitacion" class="col-12">Imagen</label>
                                    <asp:FileUpload ID="FileUpload1" class="col-12 " runat="server" />
                                    <asp:TextBox ID="txtfot" class="form-control" runat="server" Visible="false"></asp:TextBox>
                                </div>

                                <div class="row col-12">
                                    <asp:Image ID="Image1" runat="server" class="col-12 form-control" ImageUrl='<%# Eval("Image1", "imagen.ashx?id={0}") %>' Width="200px" Height="200px" />
                                </div>

                                <div class="row col-12 ">
                                    <div class="row mx-auto border">
                                        <%--<asp:Button ID="btnSubir" class="btn btn-light" runat="server" Text="Subir Imágen" OnClick="btnSubir_Click1" />--%>
                                        <asp:LinkButton ID="btnSubir" class="col-12" runat="server" required="required" CssClass="btn btn-sm btn-icon-text btn-gradient-info " Text="<span class='mdi mdi-upload btn-icon-prepend mdi-24px'> Subir Imagen</span>" OnClick="btnSubir_Click1" />
                                    </div>

                                </div>

                            </div>

                        </div>

                    </div>


                    <%--<asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server"  Text="Guardar" onclick="Button1_Click" />--%>
                    <asp:LinkButton ID="Button1" runat="server" required="required" CssClass="btn btn-sm btn-icon-text btn-gradient-info " Text="<span class='mdi mdi-content-save btn-icon-prepend mdi-24px'>&nbsp; Guardar</span>" OnClick="Button1_Click" />

                    <a href="Index.aspx" class="btn btn-sm btn-secondary text-dark btn-icon-text ">
                        <i class="mdi mdi-cancel btn-icon-prepend mdi-24px"></i>Cancelar
                    </a>


                    <asp:Label Visible="false" ID="lblId" runat="server" Text=""></asp:Label>

                </form>
            </div>
        </div>
    </div>
</asp:Content>
