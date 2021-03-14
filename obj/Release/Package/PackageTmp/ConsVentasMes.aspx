<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsVentasMes.aspx.cs" Inherits="PanelAdmin.ConsVentasMes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
         <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="CONSULTA VENTAS MES" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                        
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="SELECCIONE EL MES" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td>                             
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario" >
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>6</asp:ListItem>
                                    <asp:ListItem>7</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>9</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                </asp:DropDownList>                                
                            </td>
                            <td>&nbsp;</td>
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
