<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContrasenaEmail.aspx.cs" Inherits="CapaWeb.ContrasenaEmail" %>

 <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

    <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
     <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <title>Ingreso</title>

    <script type="text/javascript">
        {
            if (history.forward(1))
                location.replace(history.forward(1))
        }
</script>
    
        <!-- Required meta tags -->
  
 
 
  <!-- plugins:css -->
  <link rel="stylesheet" href="../../Tema/vendors/iconfonts/mdi/css/materialdesignicons.min.css">
  <link rel="stylesheet" href="../../Tema/vendors/css/vendor.bundle.base.css">
  <!-- endinject -->
  <!-- plugin css for this page -->
  <!-- End plugin css for this page -->
  <!-- inject:css -->
  <link rel="stylesheet" href="../../Tema/css/style.css">
  <!-- endinject -->
  <link rel="shortcut icon" href="../../Tema/images/favicon.png" />
</head>

<body>
<div class="container-scroller">
    <div class="container-fluid page-body-wrapper full-page-wrapper">
      <div class="content-wrapper d-flex align-items-center auth">
        <div class="row w-100">
          <div class="col-lg-4 mx-auto">
            <div class="auth-form-light text-left p-5">
              <div class="brand-logo">
                <img src="../../Tema/images/HFV.png">
              </div>
              <h4>¡Hola! </h4>
              <h6 class="font-weight-light">Ingrese su usuario</h6>
              <form runat="server" class="pt-3">
                <div class="form-group">
                    <asp:TextBox ID="TxtUsu" class="form-control form-control-lg" required="required" runat="server" placeholder="Usuario"  ></asp:TextBox>
                  
                </div>
             
                <div class="mt-3">
                  
				   <asp:Button ID="Button1"  class="btn btn-block btn-gradient-info btn-lg font-weight-medium auth-form-btn" runat="server" Text="Enviar Email" 
                                onclick="Button1_Click" />
                </div>
                  <div class="mt-3">
                  <a href="Index.aspx"  aling="center" class="auth-link text-black">Inicio</a>
                 </div>
              </form>
            </div>
          </div>
        </div>
      </div>
      <!-- content-wrapper ends -->
    </div>
    <!-- page-body-wrapper ends -->
  </div>

     <!-- plugins:js -->
    <script src="../../Tema/vendors/js/vendor.bundle.base.js"></script>
    <script src="../../Tema/vendors/js/vendor.bundle.addons.js"></script>
    <!-- endinject -->
    <!-- Plugin js for this page-->
    <!-- End plugin js for this page-->
    <!-- inject:js -->
    <script src="../../Tema/js/off-canvas.js"></script>
    <script src="../../Tema/js/misc.js"></script>
    <!-- endinject -->
    <!-- Custom js for this page-->
    <script src="../../Tema/js/dashboard.js"></script>
    <!-- End custom js for this page-->
     <script src="../../Usuario/main.js"></script>

</body>
</html>