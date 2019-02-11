<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ver.aspx.cs" Inherits="CapaWeb.Formularios.Empleado.Ver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="row">
        <div class="col-lg-12 grid-margin stretch-card">
              <div class="card">
                <div class="card-body">
                    <h4 class="card-header">Detalle Empleado</h4>
                <form id="form1" class="forms-sample" runat="server" name="form1">
                    <div class="form-group">
                        <asp:Label ID="LblErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                    <%-- carview--%>

                        <div class="row col-12">
                                <div class="row col-12 col-md-4 ">
                                    <asp:Image ID="imagenEmpleado" runat="server" class=" form-control" ImageUrl='<%# Eval("imagenEmpleado", "imagen.ashx?id={0}") %>' Width="200px" Height="200px" />
                                </div>
                                <div class="row col-12 col-md-8">
                                    <div class=" col-12 col-md-4">
                                        <label for="dniEmpleado">Cédula: </label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:TextBox ID="dniEmpleado" class="form-control" required="required" runat="server"></asp:TextBox>
                                    </div>
                                    <div class=" col-12 col-md-4">
                                        <label for="nombreEmpleado" >Nombre:</label>
                                    </div>
                                    <div class=" col-12 col-md-8">
                                        <asp:TextBox ID="nombreEmpleado" class=" form-control" required="required" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="col-12 col-md-4">
                                        <label for="apellidoEmpleado" >Apellido:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:TextBox ID="apellidoEmpleado" class="form-control"  required="required" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="col-12 col-md-4">
                                        <label for="fnacimiento" >Fecha Nacimiento:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:TextBox type="text" ID="fnacimiento" class="form-control" required="required" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="col-12 col-md-4">
                                        <label for="sexoEmpleadoo" >Sexo:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:DropDownList ID="sexoEmpleado" class="form-control" runat="server">
                                            <asp:ListItem Selected="True" Value="M">MASCULINO</asp:ListItem>
                                            <asp:ListItem Value="F">FEMENINO</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>


                                    <div class="col-12 col-md-4">
                                        <label for="estadocivilEmpleado" >Estado civil:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:DropDownList ID="estadocivilEmpleado" class="form-control" runat="server">
                                            <asp:ListItem Selected="True" Value="CASADO">CASADO</asp:ListItem>
                                            <asp:ListItem Value="DIVORCIADO">DIVORCIADO</asp:ListItem>
                                            <asp:ListItem Value="SOLTERO">SOLTERO</asp:ListItem>
                                            <asp:ListItem Value="UNION LIBRE">UNION LIBRE</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                    <div class="col-12 col-md-4">
                                        <label for="domicilioEmpleado" >Domicilio:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:TextBox ID="domicilioEmpleado" class="form-control" required="required" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="col-12 col-md-4">
                                        <label for="telefmovilEmpleado" >Celular:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:TextBox ID="telefmovilEmpleado" class="form-control" pattern="^[0-9]{10}$" placeholder="Ejm: 0992333333" required="required" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="col-12 col-md-4">
                                        <label for="fecharegistroEmpleado" >Fecha registro:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:TextBox Type="date" ID="fecharegistroEmpleado" class="form-control" required="required" runat="server"></asp:TextBox>
                                    </div>


                                    <div class="col-12 col-md-4">
                                        <label for="emailEmpleado" >Email:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:TextBox ID="emailEmpleado" type="email" class="form-control" required="required" runat="server"></asp:TextBox>
                                    </div>


                                    <div class="col-12 col-md-4">
                                        <label for="estadoEmpleado" >Estado:</label>
                                    </div>
                                    <div class="col-12 col-md-8">
                                        <asp:DropDownList ID="estadoEmpleado" class="form-control" runat="server">
                                            <asp:ListItem Selected="True" Value="ACTIVO">ACTIVO</asp:ListItem>
                                            <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
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
 </div>
</asp:Content>
