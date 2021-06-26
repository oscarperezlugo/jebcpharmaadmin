<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Compra.aspx.cs" Inherits="PanelAdmin.Compra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
         <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="COMPRAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">    
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="SELECCIONE EL PROVEEDOR" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>           
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT [Nombre] FROM [Clientes] WHERE ([Tipo] = @Tipo)">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="PROVEEDOR" Name="Tipo" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>   
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Fecha De Pago" class="formularioTIT"></asp:Label><br />                        
                <input class="formulario" placeholder="Nombre Comercial" id="Nombre" type="date" required runat="server"/> 
                            </td>
                        </tr>                        
                    </table>
                        <hr />
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="SIGUIENTE"/>            
            </div>
        </div>
        </div>
        </div>
        </div>
        </div>
</asp:Content>
