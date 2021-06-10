<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proveedor.aspx.cs" Inherits="PanelAdmin.Proveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
        <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="Registro de Proveedor" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">  
                    <table style="width: 100%;">
                        <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label1" runat="server" Text="Nombre Comercial" class="formularioTIT"></asp:Label><br />  
                <input class="formulario" placeholder="Nombre Comercial" id="Nombre" type="text" required runat="server"/>            
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label2" runat="server" Text="RIF" class="formularioTIT"></asp:Label><br />  
                <input class="formulario" placeholder="V5555555555-5" id="Text2" type="text" maxlength="11" required runat="server"/>            
            </div></td>
                            <td><div class="fila col10L">
                                  <asp:Label ID="Label3" runat="server" Text="CORREO" class="formularioTIT"></asp:Label><br />                       
                <input class="formulario" placeholder="Correo (juan@gmail.com)" id="Correo" type="email" required runat="server"/>            
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label4" runat="server" Text="Télefono" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Télefono (0414555555)" id="Telefono" type="text" maxlength="11" required runat="server"/>            
            </div></td>                            
                        </tr>
                        <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label5" runat="server" Text="Dirección" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Dirección (Valencia, Prebo Calle Libra #55)" id="Text1" type="text" required runat="server"/>                       
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label7" runat="server" Text="PERSONA CONTACTO" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="JUAN PEREZ" id="Text3" type="text" required runat="server"/> 
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label8" runat="server" Text="Contraseña" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Contraseña" id="Contraseña" type="password" required runat="server"/>            
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label9" runat="server" Text="Télefono 2" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Télefono (0414555555)" id="Repetir" type="text" maxlenght="11" required runat="server"/>            
            </div></td>
                        </tr>                        
                    </table>
            
            
            
            
            
            
            
            <hr />
           
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="REGISTRAR PROVEEDOR"/>            
            </div>
        </div>
            </div>
            </div>
        </div>
        </div>    
</asp:Content>
