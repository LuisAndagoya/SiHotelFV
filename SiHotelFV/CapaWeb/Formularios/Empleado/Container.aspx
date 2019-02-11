<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="CapaWeb.Formularios.Empleado.Container" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="../Empleado/ValidarCedula.js"></script>
    <div class="col-md-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-header">Empleado</h4>

                <form id="form1" class="forms-sample" runat="server" name="form1">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="row form-group">

                        <div class="row col-12 col-md-6">
                            <div class="row col-12">
                                <label for="dniEmpleado" class="col-12 col-md-4">Cédula:</label>
                                <asp:TextBox ID="dniEmpleado" class="col-12 col-md-8 form-control" pattern="^[0-9]{10}$" required="required" runat="server"></asp:TextBox>
                            </div>

                            <div class="row col-12">
                                <label for="nombreEmpleado" class="col-12 col-md-4">Nombre</label>
                                <asp:TextBox ID="nombreEmpleado" class="col-12 col-md-8 form-control" pattern="^[\ s A-z ]*$" required="required" runat="server"></asp:TextBox>
                            </div>

                            <div class="row col-12">
                                <label for="apellidoEmpleado" class="col-12 col-md-4">Apellido</label>
                                <asp:TextBox ID="apellidoEmpleado" class=" col-12 col-md-8 form-control" pattern="^[\ s A-z ]*$" required="required" runat="server"></asp:TextBox>
                            </div>


                            <div class="row row col-12">
                                <label for="fnacimiento" class="col-12 col-md-4">Fecha Nacimiento</label>
                                <asp:TextBox type="date" ID="fnacimiento" class="col-12 col-md-8 form-control" required="required" runat="server"></asp:TextBox>
                            </div>


                            <div class="row col-12">
                                <label for="sexoEmpleadoo" class="col-12 col-md-4">Sexo</label>
                                <asp:DropDownList ID="sexoEmpleado" class="col-12 col-md-8 form-control" runat="server">
                                    <asp:ListItem Selected="True" Value="M">MASCULINO</asp:ListItem>
                                    <asp:ListItem Value="F">FEMENINO</asp:ListItem>
                                </asp:DropDownList>
                            </div>


                            <div class="row col-12 ">
                                <label for="estadocivilEmpleado" class="col-12 col-md-4">Estado civil</label>
                                <asp:DropDownList ID="estadocivilEmpleado" class="col-12 col-md-8 form-control" runat="server">
                                    <asp:ListItem Selected="True" Value="CASADO">CASADO</asp:ListItem>
                                    <asp:ListItem Value="DIVORCIADO">DIVORCIADO</asp:ListItem>
                                    <asp:ListItem Value="SOLTERO">SOLTERO</asp:ListItem>
                                    <asp:ListItem Value="UNION LIBRE">UNION LIBRE</asp:ListItem>
                                </asp:DropDownList>
                            </div>


                            <div class="row col-12 ">
                                <label for="domicilioEmpleado" class="col-12 col-md-4">Domicilio</label>
                                <asp:TextBox ID="domicilioEmpleado" class="col-12 col-md-8 form-control" required="required" runat="server"></asp:TextBox>
                            </div>

                            <div class="row col-12">
                                <label for="telefmovilEmpleado" class="col-12 col-md-4">Celular</label>
                                <asp:TextBox ID="telefmovilEmpleado" class="col-12 col-md-8 form-control" pattern="^[0-9]{10}$" placeholder="Ejm: 0992333333" required="required" runat="server"></asp:TextBox>
                            </div>


                            <div class="row col-12 ">
                                <label for="fecharegistroEmpleado" class="col-12 col-md-4">Fecha registro</label>
                                <asp:TextBox Type="date" ID="fecharegistroEmpleado" class="col-12 col-md-8 form-control" required="required" runat="server"></asp:TextBox>
                            </div>

                            <div class="row col-12">
                                <label for="emailEmpleado" class="col-12 col-md-4">Email</label>
                                <asp:TextBox ID="emailEmpleado" type="email" class="col-12 col-md-8 form-control" required="required" runat="server"></asp:TextBox>
                            </div>
                            <div class="row col-12 ">
                                <label for="estadoEmpleado" class="col-12 col-md-4">Estado</label>
                                <asp:DropDownList ID="estadoEmpleado" class="col-12 col-md-8 form-control" runat="server">
                                    <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                                    <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="row col-12 col-md-6">
                            <div class="form-group">
                                <div class="row col-12">
                                    <label for="imagenEmpleado" class="col-12">Imagen</label>
                                    <asp:FileUpload ID="FileUpload1" class="col-12" runat="server" />
                                    <asp:TextBox ID="txtfot" runat="server" Visible="false"></asp:TextBox>

                                </div>

                                <div class="row col-12">
                                    <asp:Image ID="Image1" runat="server" class="col-12 form-control" ImageUrl='<%# Eval("Image1", "imagen.ashx?id={0}") %>' Width="200px" Height="200px" />

                                </div>
                                <div class="row col-12 ">
                                    <div class="row mx-auto border">
                                        <%--<asp:Button ID="btnSubir" class="btn btn-sm btn-gradient-success" runat="server" Text="Subir Imágen" OnClick="btnSubir_Click1" />--%>
                                        <asp:LinkButton ID="btnSubir" class="col-12" runat="server" required="required" CssClass="btn btn-sm btn-icon-text btn-gradient-info " Text="<span class='mdi mdi-upload btn-icon-prepend mdi-24px'> Subir Imagen</span>" OnClick="btnSubir_Click1" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="row col-12">
                        
                            
                                <%--<asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" Text="Guardar" onclick="Button1_Click" />--%>
                                <asp:LinkButton ID="Button1" runat="server" required="required" CssClass="btn btn-sm btn-icon-text btn-gradient-info " Text="<span class='mdi mdi-content-save btn-icon-prepend mdi-24px'>&nbsp; Guardar</span>" OnClick="Button1_Click" />
                         
                       
                                <a href="Index.aspx" class="btn btn-sm btn-secondary text-dark btn-icon-text ">
                                    <i class="mdi mdi-cancel btn-icon-prepend mdi-24px"></i>Cancelar
                                </a>

                         
                    </div>

                    <asp:Label Visible="false" ID="lblId" runat="server" Text=""></asp:Label>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
