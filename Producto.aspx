<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="PanelAdmin.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
        <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="Crear Producto" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width: 100%;">
                        <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label1" runat="server" Text="Nombre del Producto" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Nombre del Producto" id="Nombre" type="text" required runat="server" maxlength="60"/>            
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label2" runat="server" Text="Precio" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Precio $ formato (9,18)" id="Precio" type="text"  required runat="server" maxlength="5"/> 
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label3" runat="server" Text="Categoria" class="formularioTIT"></asp:Label><br /> 
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario" DataSourceID="SqlDataSource1" DataTextField="Categoria" DataValueField="Categoria" ></asp:DropDownList>                           
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Categoria] FROM [Categorias]"></asp:SqlDataSource>
            </div></td>
                        </tr>
                        <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label4" runat="server" Text="Cantidad" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Cantidad" id="Cantidad" type="number" maxlength="10" required runat="server"/>            
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label5" runat="server" Text="Condición Fiscal" class="formularioTIT"></asp:Label><br /> 
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formulario">
                    <asp:ListItem>Exento de IVA</asp:ListItem>
                    <asp:ListItem>Aplica IVA</asp:ListItem>
                </asp:DropDownList>
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label7" runat="server" Text="Imagen" class="formularioTIT"></asp:Label><br /> 
               <c><asp:FileUpload ID="FileUpload1" runat="server" CssClass="formulario" /></c>                         
            </div> </td>
                        </tr>   
                         <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label8" runat="server" Text="Precio Compra" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Precio Compra $ formato (9,18)" id="Number1" type="text" maxlength="10" required runat="server"/>            
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label9" runat="server" Text="CPE" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="CPE" id="Text3" type="text" required runat="server"/> 
            </div></td>
                            <td> <div class="fila col10L">
                                <asp:Label ID="Label10" runat="server" Text="OBSERVACION" class="formularioTIT"></asp:Label><br /> 
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formulario">
                    <asp:ListItem>NO REFRIGERADO</asp:ListItem>
                    <asp:ListItem>REFRIGERADO</asp:ListItem>                    
                </asp:DropDownList>
            </div></td>
                        </tr>  
                         <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label11" runat="server" Text="LOTE" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Lote" id="Text1" type="text" maxlength="10" required runat="server"/>            
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label12" runat="server" Text="FECHA VENCIMIENTO" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="CPE" id="Text2" type="datetime-local" required runat="server"/> 
            </div></td>
                            <td> <div class="fila col10L">
                                <asp:Label ID="Label13" runat="server" Text="UNIDAD DE MANEJO" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="UNIDAD" id="Datetimelocal1" type="text" required runat="server"/> 
            </div></td>
                        </tr>
                    </table>
                    <table style="width: 27.5%;">
                        <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label14" runat="server" Text="CODIGO" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="CODIGO" id="Text4" type="text" required runat="server"/> 
            </div></td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        
                    </table>
            
            
            
            
            
               <hr />                 
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="CREAR PRODUCTO" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="CREAR PRODUCTO"/>            
            </div>
        </div>
            </div>
            </div>
        </div>
        </div> 
</asp:Content>
