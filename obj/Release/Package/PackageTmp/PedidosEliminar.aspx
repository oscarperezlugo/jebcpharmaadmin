<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedidosEliminar.aspx.cs" Inherits="PanelAdmin.PedidosEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="PEDIDOS ELIMINAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <center><input class="formulario" placeholder="Numero Operacion" id="Correo" type="text" runat="server"/>  
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BUSCAR FACTURA" OnClick="Unnamed1_Click" /></center>
                    <br />
    <c><p><h2></h2></p></c>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
        <Columns>            
            
            <asp:BoundField DataField="iDCliente" HeaderText="iDCliente" SortExpression="iDCliente" />
            <asp:BoundField DataField="FechaVenta" HeaderText="FechaVenta" SortExpression="FechaVenta" />
            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" />
            <asp:BoundField DataField="Lineas" HeaderText="Lineas" SortExpression="Lineas" />
            <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" SortExpression="SubTotal" />
            <asp:BoundField DataField="iDVenta" HeaderText="iDVenta" SortExpression="iDVenta" />
            <asp:BoundField DataField="Row" HeaderText="#" SortExpression="Row" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="NroOp" HeaderText="Numero Operacion" SortExpression="NroOp" />            
         
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ELIMINAR" />
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [iDCliente], [FechaVenta], [Monto], [Lineas], [SubTotal], [iDVenta], [Row], [Status], [TipoVenta], [Metodo], [Direccion], NroOp, Ref FROM [Cabecera] WHERE (([Tipo] = @Tipo) OR ([Tipo] = @Tipo2))">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="PEDIDO" Name="Tipo" Type="String"></asp:Parameter>
                            <asp:Parameter DefaultValue="NOTA DE ENTREGA" Name="Tipo2" Type="String"></asp:Parameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
        <Columns>            
            
            <asp:BoundField DataField="iDCliente" HeaderText="iDCliente" SortExpression="iDCliente" />
            <asp:BoundField DataField="FechaVenta" HeaderText="FechaVenta" SortExpression="FechaVenta" />
            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" />
            <asp:BoundField DataField="Lineas" HeaderText="Lineas" SortExpression="Lineas" />
            <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" SortExpression="SubTotal" />
            <asp:BoundField DataField="iDVenta" HeaderText="iDVenta" SortExpression="iDVenta" />
            <asp:BoundField DataField="Row" HeaderText="#" SortExpression="Row" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="NroOp" HeaderText="Numero Operacion" SortExpression="NroOp" />            
         
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ELIMINAR" />
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
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [iDCliente], [FechaVenta], [Monto], [Lineas], [SubTotal], [iDVenta], [Row], [Status], [TipoVenta], [Metodo], [Direccion], NroOp, Ref FROM [Cabecera] WHERE (([Tipo] = @Tipo AND NroOp = @Operacion) OR ([Tipo] = @Tipo2 AND NroOp = @Operacion))">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="PEDIDO" Name="Tipo" Type="String"></asp:Parameter>
                            <asp:Parameter DefaultValue="NOTA DE ENTREGA" Name="Tipo2" Type="String"></asp:Parameter>
                            <asp:CookieParameter CookieName="Operacion" Name="Operacion" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
</div>
            </div>
        </div>
        </div>  
</asp:Content>
