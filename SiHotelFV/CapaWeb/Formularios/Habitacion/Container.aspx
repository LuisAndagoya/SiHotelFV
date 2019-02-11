<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Habitacion.Container" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-md-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-header">Habitación</h4>

                <form id="form1" class="forms-sample" runat="server">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="form-group">
                        <label for="numeroHabitacion">N° Habitación</label>
                        <asp:TextBox ID="numeroHabitacion" class="form-control" type="number" required="required" runat="server"></asp:TextBox>

                    </div>


                    <div class="form-group">
                        <label for="ListaTipo">Tipo Habitación</label>
                        <asp:DropDownList ID="ListaTipo" required="required" class="form-control" runat="server">
                        </asp:DropDownList>
                    </div>




                    <div class="form-group">
                        <label for="ListaHotel">Hotel</label>
                        <asp:DropDownList ID="ListaHotel" required="required" class="form-control" runat="server">
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="ListaEstado">Estado</label>
                        <asp:DropDownList ID="ListaEstado" required="required" class="form-control" runat="server">
                        </asp:DropDownList>
                    </div>


                    <%--<asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" Text="Guardar" onclick="Button1_Click" />--%>
                    <asp:LinkButton ID="Button1" runat="server" required="required" CssClass="btn btn-sm btn-icon-text btn-gradient-info " Text="<span class='mdi mdi-content-save btn-icon-prepend mdi-24px'>&nbsp;&nbsp;&nbsp; Guardar</span>" OnClick="Button1_Click" />


                    <a href="Index.aspx" class="btn btn-sm btn-secondary text-dark btn-icon-text ">
                        <i class="mdi mdi-cancel btn-icon-prepend mdi-24px"></i>Cancelar
                    </a>


                    <asp:Label Visible="false" ID="lblId" runat="server" Text=""></asp:Label>

                </form>
            </div>
        </div>
    </div>
</asp:Content>
