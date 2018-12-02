
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
        <link rel="stylesheet" type="text/css" href="Tema/css/style.css" />
		<script src="Tema/js/cufon-yui.js" type="text/javascript"></script>
		<script src="Tema/js/ChunkFive_400.font.js" type="text/javascript"></script>
</head>
<body>
<div class="wrapper">
			<h1>Sistema</h1>
			<h2>BIENVENIDO@S</h2>
			<div class="content"
				<div id="form_wrapper" class="form_wrapper">
			
    <form id="form1"  class="login active" runat="server">
    
  <h3>Login</h3>
						<div>
							<label>Usuario:</label>
							
                            <asp:TextBox ID="TxtUsu" required runat="server"></asp:TextBox>
						</div>
						<div>
							<label>Contrase&ntilde;a:</label>
                            <asp:TextBox ID="TxtCont" required="required" TextMode="Password" runat="server"></asp:TextBox>
							
						</div>
						<div class="bottom">
							
                            <asp:Button ID="Button1" runat="server" Text="Ingresar" 
                                onclick="Button1_Click" />
							
							<div class="clear"></div>
						</div>
		
    </form>

    	
				</div>
				<div class="clear"></div>
			</div>
		
		</div>
</body>
</html>

