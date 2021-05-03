<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="PanelAdmin.Login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
            <br />
            <br />
            <br />
            <p><h2>LOGIN</h2></p>
            <div class="fila col10L">
                <input class="formulario" placeholder="Usuario" id="Correo" type="text" required runat="server"/>            
            </div>                       
            <div class="fila col10L">
                <input class="formulario" placeholder="Contraseña" id="Contrasena" type="password" required runat="server"/>            
            </div>            
            <%--<p><a class="enlaces" href="Registro.aspx">Don't you have an account? sign up here</a></p>--%>
            <p><a class="enlaces" href="Contrasena.aspx">Actualizar Contraseña</a></p>
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="LOGIN" OnClick="Unnamed1_Click" />            
            </div>
        </div>        
</asp:Content>
