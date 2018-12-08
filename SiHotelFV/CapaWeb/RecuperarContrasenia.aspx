<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarContrasenia.aspx.cs" Inherits="CapaWeb.RecuperarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recurperar Contraseña </title>
       <!-- Required meta tags -->
    <meta charset="utf-8">
  
    <!-- plugins:css -->
    <link rel="stylesheet" href="Tema/vendors/iconfonts/mdi/css/materialdesignicons.min.css">
    <link rel="stylesheet" href="Tema/vendors/css/vendor.bundle.base.css">
    <!-- endinject -->
    <!-- inject:css -->
    <link rel="stylesheet" href="Tema/css/style.css">
    <!-- endinject -->
    <link rel="shortcut icon" href="Tema/images/favicon.png" />
    <script type="text/javascript">
        {
            if (history.forward(1))
                location.replace(history.forward(1))
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" class="forms-sample">
    <div class="form-group">
                        <label for="usernameUsuario">Usuario</label>
                        <asp:TextBox ID="TextBox1" class="form-control" required="required" runat="server"></asp:TextBox>
                    </div>

        <div class="form-group">
                        <label for="usernameUsuario">Usuario</label>
                        <asp:TextBox ID="TextBox2" class="form-control" required="required" runat="server"></asp:TextBox>
                    </div>

        <div class="form-group">
                        <label for="usernameUsuario">Usuario</label>
                        <asp:TextBox ID="TextBox3" class="form-control" required="required" runat="server"></asp:TextBox>
                    </div>

         <asp:Button class="btn btn-gradient-primary mr-2" ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
    </form>
</body>
</html>
