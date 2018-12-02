
    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaWeb.Index" %>
    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

    
    <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>

    <script type="text/javascript">
        {
            if (history.forward(1))
                location.replace(history.forward(1))
        }
</script>

        <link rel="shortcut icon" href="Tema/favicon.ico" type="image/x-icon"/>
        <link rel="stylesheet" href="../../Tema/vendors/iconfonts/mdi/css/materialdesignicons.min.css"/>
        <link rel="stylesheet" href="../../Tema/vendors/css/vendor.bundle.base.css"/>
         <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
         <link rel="shortcut icon" href="../../Tema/images/favicon.png" />
      
        <link rel="stylesheet" href="../../../Tema/css/style.css"/>
		<script src="Tema/js/cufon-yui.js" type="text/javascript"></script>
		<script src="Tema/js/ChunkFive_400.font.js" type="text/javascript"></script>
</head>
<body>
<div id="sidebar" align="center" class="sidebar-grdient-dark" >
			
    <br />
			<h2>BIENVENIDO@S</h2>
    <br />
    <br />
			<div class="card">
         <div class="card-body">
				<div  class="sidebar sidebar-offcanvas"  align="center">
			
    <form id="form1"  class="form-group" align="center" runat="server" color="red">
     
  <h3>Login</h3>
						<div>
							<label>Usuario</label>
							
                            <asp:TextBox ID="TxtUsu" required="required" runat="server"   placeholder="Usuario" ></asp:TextBox>
						</div>
						<div>
							<label>Contrase&ntilde;a</label>
                            <asp:TextBox ID="TxtCont" required="required" TextMode="Password" placeholder="Contraseña" runat="server" ></asp:TextBox>
							
						</div>
						<div class="bottom">
							<br />
                            <br />
                            <asp:Button ID="Button1"  class = "btn btn-primary" runat="server" Text="Ingresar" 
                                onclick="Button1_Click" />
							
							<div class="clear"></div>
						</div>
		
    </form>

    	
				</div>
				<div class="clear"></div>
			</div>
		
		</div>
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


</body>
</html>

