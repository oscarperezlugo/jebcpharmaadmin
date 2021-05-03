<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PanelAdmin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Administrativo JEBCPHARMA</title>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="Content/columnas.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@200&display=swap" rel="stylesheet">  
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="Content/Print.css" rel="stylesheet" media="print"/>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="nave fijador">
            <div  class="col2L  col0M col0S col0T" >
                  <a href="Default.aspx"><img id="logo" src="img/weblogo_jebcpharma-2.png" /></a>
            </div>            
        </nav>
        <nav class="subnave fijadordos">
            <%--<label class="fa fa-bars botonsub no-print" for="check"/>&ensp; 
            <i class="fas fa-user"></i>&ensp;<asp:Label ID="Label1" runat="server" CssClass="nomlog" for="chek"></asp:Label>--%>
        </nav> 
        <br />
            <br />
            <br />
          <br />
            <br />
            <br />
          <br />
            <br />
            <br />
        <div class="baseform" style="width:60%; margin-left:20%;">
            <br />
            <br />
            <br />
            <p><h2>LOGIN</h2></p>
            <div class="fila col10L">
                <input class="formulario" placeholder="Correo" id="Correo" type="text" required runat="server"/>            
            </div>                       
            <div class="fila col10L">
                <input class="formulario" placeholder="Contraseña" id="Contrasena" type="password" required runat="server"/>            
            </div>            
            <%--<p><a class="enlaces" href="Registro.aspx">Don't you have an account? sign up here</a></p>--%>
            <%--<p><a class="enlaces" href="Contrasena.aspx">Actualizar Contraseña</a></p>--%>
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="LOGIN" OnClick="Unnamed1_Click" />            
            </div>
        </div>      
    </form>
</body>
</html>
