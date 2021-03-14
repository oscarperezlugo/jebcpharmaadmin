<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClienteEdicion.aspx.cs" Inherits="PanelAdmin.ClienteEdicion"   %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
        <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">  
            <asp:Label ID="Label6" runat="server" Text="CLIENTE: EDICION" Style="font-weight: bold; font-size: 18px;"></asp:Label>   
        <asp:Label ID="Label1" runat="server" Text="PROVEEDOR: EDICION" Style="font-weight: bold; font-size: 18px;"></asp:Label>   
                        </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width: 100%;">
                        <tr>
                            <td><div class="fila col10L">                
                                <asp:Label ID="Label2" runat="server" Text="Nombre Comercial" class="formularioTIT"></asp:Label><br />  
                <input class="formulario" placeholder="Nombre (Juan)" id="Nombre" type="text"  runat="server"/>            
            </div></td>                            
                            <td><div class="fila col10L">
                <asp:Label ID="Label3" runat="server" Text="Correo" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Correo (juan@gmail.com)" id="Correo" type="email"  runat="server"/>            
            </div></td>
                            <td><div class="fila col10L">
                <asp:Label ID="Label4" runat="server" Text="Telefono" class="formularioTIT"></asp:Label><br />   
                <input class="formulario" placeholder="Télefono (0414555555)" id="Telefono" type="text" maxlength="11"  runat="server"/>            
            </div></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <div class="fila col10L">
                                     <asp:Label ID="Label5" runat="server" Text="RIF" class="formularioTIT"></asp:Label><br />  
                <input class="formulario" placeholder="V5555555555-5" id="Text1" type="text" maxlength="11" required runat="server"/>            
            </div>
                            </td>
                            <td>
                                <div class="fila col10L">   
                                    <asp:Label ID="Label7" runat="server" Text="Dirección" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Dirección (Valencia, Prebo Calle Libra #55)" id="Dirección" type="text"  runat="server" />            
            </div>  
                            </td>
                            <td>
                                <div class="fila col10L">
                                   <asp:Label ID="Label8" runat="server" Text="SICM" class="formularioTIT"></asp:Label><br />  
                <input class="formulario" placeholder="CODIGO SICM" id="Text2" type="text" required runat="server"/>            
            </div>
                            </td>
                            <td>&nbsp;</td>
                        </tr>                        
                    </table>
            
            
            
            
         
             <hr />
            
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="ACTUALIZAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="ACTUALIZAR CLIENTE" ID="CLI"/>            
                <asp:Button class="botonsubmit" value="ACTUALIZAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="ACTUALIZAR PROVEEDOR" ID="PROV"/>            
            </div>
        </div>
            </div>
            </div>
        </div>
        </div>    
</asp:Content>
