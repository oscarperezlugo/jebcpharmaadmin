<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdEditar.aspx.cs" Inherits="PanelAdmin.ProdEditar" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">   
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="EDITAR PRODUCTOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">   
                    <center><input class="formulario" placeholder="Nombre" id="Correo" type="text" runat="server"/>  
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BUSCAR PRODUCTO" OnClick="Unnamed1_Click" /></center>
                    <br />

                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" DataKeyNames="Row">
                        <AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                        <Columns>
                            
                            <asp:BoundField DataField="Producto" HeaderText="Producto" SortExpression="Producto" />
                            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                            <%--<asp:BoundField DataField="iDProducto" HeaderText="iDProducto" SortExpression="iDProducto" />--%>
                            <asp:BoundField DataField="Row" HeaderText="Row" SortExpression="Row" InsertVisible="False" ReadOnly="True" />
                            <asp:BoundField DataField="PrecioD" HeaderText="PrecioD" SortExpression="PrecioD" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria" />
                            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                            <asp:BoundField DataField="Impuesto" HeaderText="Impuesto" SortExpression="Impuesto"></asp:BoundField>
                            <asp:BoundField DataField="PrecioCompra" HeaderText="PrecioCompra" SortExpression="PrecioCompra"></asp:BoundField>
                            <asp:BoundField DataField="Lote" HeaderText="Lote" SortExpression="Lote"></asp:BoundField>
                            <asp:BoundField DataField="FechaVenc" HeaderText="FechaVenc" SortExpression="FechaVenc"></asp:BoundField>
                            <asp:BoundField DataField="Unidad" HeaderText="Unidad" SortExpression="Unidad"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ACTUALIZAR"></asp:CommandField>
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Producto], [Precio], [iDProducto], [Row], [PrecioD], [Categoria], [Cantidad], [Impuesto], [PrecioCompra], [Lote], [FechaVenc], [Unidad] FROM [Producto] ">                        
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" DataKeyNames="Row">
                        <AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="Producto" HeaderText="Producto" SortExpression="Producto" />
                            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                            <%--<asp:BoundField DataField="iDProducto" HeaderText="iDProducto" SortExpression="iDProducto" />--%>
                            <asp:BoundField DataField="Row" HeaderText="Row" SortExpression="Row" InsertVisible="False" ReadOnly="True" />
                            <asp:BoundField DataField="PrecioD" HeaderText="PrecioD" SortExpression="PrecioD" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria" />
                            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                            <asp:BoundField DataField="Impuesto" HeaderText="Impuesto" SortExpression="Impuesto"></asp:BoundField>
                            <asp:BoundField DataField="PrecioCompra" HeaderText="PrecioCompra" SortExpression="PrecioCompra"></asp:BoundField>
                            <asp:BoundField DataField="Lote" HeaderText="Lote" SortExpression="Lote"></asp:BoundField>
                            <asp:BoundField DataField="FechaVenc" HeaderText="FechaVenc" SortExpression="FechaVenc"></asp:BoundField>
                            <asp:BoundField DataField="Unidad" HeaderText="Unidad" SortExpression="Unidad"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ACTUALIZAR"></asp:CommandField>
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
                    
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Producto], [Precio], [iDProducto], [Row], [PrecioD], [Categoria], [Cantidad], [Impuesto], [PrecioCompra], [Lote], [FechaVenc], [Unidad] FROM [Producto] WHERE ([Producto] LIKE '%' + @Producto + '%')">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramseisC" Name="Producto" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    </div>
            </div>
        </div>
        </div>
</asp:Content>
