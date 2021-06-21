<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedidoTres.aspx.cs" Inherits="PanelAdmin.PedidoTres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
         <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="AGREGAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">    
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
        <Columns>                        
            <asp:BoundField DataField="iDCliente" HeaderText="iDCliente" SortExpression="iDCliente" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Rif" HeaderText="Rif" SortExpression="Rif" />
            <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="black" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
<PagerStyle CssClass="pgr"></PagerStyle>
    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [iDCliente], [Nombre], [Rif], [Direccion] FROM [Clientes] WHERE ([Nombre] = @Nombre)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="clienteC" Name="Nombre" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="PRODUCTO" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label2" runat="server" Text="PRECIO " Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label3" runat="server" Text="CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label4" runat="server" Text="TOTAL " Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="Producto" DataValueField="Producto" OnSelectedIndexChanged="Prod" CssClass="formularioProc" AutoPostBack="true">
                                    <asp:ListItem Value="0">PRODUCTO</asp:ListItem>
                                </asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT [Producto] FROM [Producto]" ></asp:SqlDataSource>
                                  </td>
                            <td><asp:Label ID="Label5" runat="server" CssClass="formularioFinD" ></asp:Label>
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioblockD"   AppendDataBoundItems="true" DataTextField="Precio" DataValueField="Precio"  AutoPostBack="true">                                
                                </asp:DropDownList>
                                </td>
                            <td><asp:TextBox CssClass="formularioProc" placeholder="CANTIDAD" id="Correo" type="number" runat="server" ValidationGroup="ValidateMe"  AutoPostBack="true" OnTextChanged="test" ></asp:TextBox>                                
                            </td>                            
                            <td>
                                <asp:Label ID="prefifin" runat="server" CssClass="formularioFin" ></asp:Label>
                            </td>
                        </tr>
                      
                    </table>
                    <hr />
                     <center><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="AGREGAR" OnClick="Unnamed1_Click"/>                                                  
                    </center>
                    <hr />
           <div>
                <asp:Button class="botonsubmit" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed2_Click"  Text="SIGUIENTE"/>            
            </div>
        </div>
        </div>
        </div>
        </div>
        </div>
</asp:Content>
