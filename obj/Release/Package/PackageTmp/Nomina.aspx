<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nomina.aspx.cs" Inherits="PanelAdmin.Nomina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
         <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="Registro de Personal" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">            
                <div class="form-row">    
            <table style="width: 100%;">
                <tr>                    
                    <td><div class="fila col10L">
                        <asp:Label ID="Label1" runat="server" Text="Nombre" class="formularioTIT"></asp:Label><br />                        
                <input class="formulario" placeholder="Nombre Comercial" id="Nombre" type="text" required runat="server"/>            
            </div></td>
                    <td><div class="fila col10L">
                        <asp:Label ID="Label7" runat="server" Text="Apellido" class="formularioTIT"></asp:Label><br />
                <input class="formulario" placeholder="Apellido (Perez)" id="Apellido" type="text" required runat="server"/>            
            </div></td>
                    <td><div class="fila col10L">
                        <asp:Label ID="Label3" runat="server" Text="Telefono" class="formularioTIT"></asp:Label><br />   
                <input class="formulario" placeholder="Télefono (0414555555)" id="Telefono" type="text" maxlength="11" required runat="server"/>            
            </div></td>
                    <td><div class="fila col10L">
                        <asp:Label ID="Label8" runat="server" Text="Pass" class="formularioTIT"></asp:Label><br />  
                <input class="formulario" placeholder="Contraseña" id="Contraseña" type="password" required runat="server"/>            
            </div></td>
                </tr>
                <tr>
                    <td><div class="fila col10L">
                       <asp:Label ID="Label4" runat="server" Text="CEDULA" class="formularioTIT"></asp:Label><br />   
                <input class="formulario" placeholder="V55555555555" id="Text1" type="text" maxlength="11" required runat="server"/>            
            </div></td>
                    <td><div class="fila col10L">
                        <asp:Label ID="Label5" runat="server" Text="Dirección" class="formularioTIT"></asp:Label><br />   
                <input class="formulario" placeholder="Dirección (Valencia, Prebo Calle Libra #55)" id="Dirección" type="text" required runat="server"/>            
            </div></td>
                    <td><div class="fila col10L">
                        <asp:Label ID="Label2" runat="server" Text="Correo" class="formularioTIT"></asp:Label><br />   
                <input class="formulario" placeholder="Correo (juan@gmail.com)" id="Correo" type="email" required runat="server"/>            
            </div></td>
                    
                    <td><div class="fila col10L">
                        <asp:Label ID="Label9" runat="server" Text="Confirmar Pass" class="formularioTIT"></asp:Label><br />  
                <input class="formulario" placeholder="Repetir Contraseña" id="Repetir" type="password" required runat="server"/>            
            </div></td>
                </tr>
                <tr>
                    <td><div class="fila col10L">
                       <asp:Label ID="Label10" runat="server" Text="PERSONA CONTACTO" class="formularioTIT"></asp:Label><br />   
                <input class="formulario" placeholder="JUAN PEREZ" id="Text31" type="text" maxlength="20" required runat="server"/>            
            </div></td>
                    <td><div class="fila col10L">
                        <asp:Label ID="Label11" runat="server" Text="TELEFONO CONTACTO" class="formularioTIT"></asp:Label><br />   
                <input class="formulario" placeholder="0424-555 55555" id="Text41" type="text" required runat="server"/>            
            </div></td>
                    <td><div class="fila col10L">
                        <asp:Label ID="Label12" runat="server" Text="TIPO NOMINA" class="formularioTIT"></asp:Label><br />   
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formulario">
                    <asp:ListItem>ADMIN</asp:ListItem>
                    <asp:ListItem>VENDEDOR</asp:ListItem>
                    <asp:ListItem>CONTADOR</asp:ListItem>   
                    <asp:ListItem>SERVICIO</asp:ListItem>  
                </asp:DropDownList>         
            </div></td>
                    
                    <td><div class="fila col10L">
                        <asp:Label ID="Label13" runat="server" Text="SUELDO" class="formularioTIT"></asp:Label><br />   
                <input class="formulario" placeholder="50000000" id="Text3" type="text" required runat="server"/>            
            </div></td>
                </tr>   
            </table>
            
            
           
            
            
            
            
            
            
                    <hr />
            <%--<p><input type="checkbox" required> ¿Acepta el cliente los Términos y Condiciones? <a class="enlaces" href="Terminos.aspx">Términos y Condiciones</a></p>
            <p><a class="enlaces" href="Login.aspx">¿Ya Tienes una Cuenta? Inicia Sesión desde Aquí</a></p>--%>
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="REGISTRAR PERSONAL"/>            
            </div>
        </div>
             </div>
        </div>
        </div>
        </div>
</asp:Content>
