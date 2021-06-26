<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedidoTotal.aspx.cs" Inherits="PanelAdmin.PedidoTotal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">   
     <div class="container">
         <asp:Panel ID="pnl1" ClientIDMode="Static" CssClass="pnlCSS" runat="server"> 
    <div class="card">
        <div class="card-header no-print">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="PEDIDO DETALLES" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                
                    </div>                   
                </div>
            </div>
        <div class="card-body no-print printbody">
                <div class="form-row">   
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid no-print" PagerStyle-CssClass="pgr no-print" AlternatingRowStyle-CssClass="alt no-print" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
        <Columns>
            <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
            <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
            <asp:BoundField DataField="FechaVenta" HeaderText="FechaVenta" SortExpression="FechaVenta" DataFormatString="{0:d}"/>
            
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Tipo], [FechaVenta], [Direccion] FROM [Cabecera] WHERE ([iDVenta] = @iDVenta)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="idventaC" Name="iDVenta" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="DireccionEntF" HeaderText="DireccionEntF" SortExpression="DireccionEntF" />
            <asp:BoundField DataField="Rif" HeaderText="Rif" SortExpression="Rif" />
            <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="black" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Nombre], [DireccionEntF], [Rif], [Telefono] FROM [Clientes] WHERE ([iDCliente] = @iDCliente)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="idclienteC" Name="iDCliente" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" ShowFooter="true">
        <Columns>
            <asp:BoundField DataField="Producto" HeaderText="Producto" SortExpression="Producto" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" DataFormatString="{0:#,#}"></asp:BoundField>            
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="black" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Producto], [Cantidad], [Precio] FROM [Lineas] WHERE ([iDVenta] = @iDVenta)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="idventaC" Name="iDVenta" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" DataKeyNames="Row">
                        <Columns>
                            <asp:BoundField DataField="Row" HeaderText="Row" SortExpression="Row" InsertVisible="False" ReadOnly="True" />
                            <asp:BoundField DataField="Lineas" HeaderText="Lineas" SortExpression="Lineas" />
                            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" DataFormatString="{0:#,#}">
                                <ItemStyle ForeColor="#009933"></ItemStyle>
                            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="black" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Row], [Lineas], [Monto] FROM [Cabecera] WHERE ([iDVenta] = @iDVenta)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="idventaC" Name="iDVenta" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
                     </asp:Panel> 
                    <hr class="no-print"/>
         
         
    <div class="fila col10L">
                <center><asp:Button class="botonsubmit" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit no-print" OnClientClick="javascript:window.print();" ID="PrintBut"  Text="IMPRIMIR" UseSubmitBehavior="false"/></center>            
            </div>
                    </div>
            </div>
        </div>
        </div>
    <div id="factura1" style="width:100%">
    
        <div class="soloimp" id="rsoc"><asp:Label ID="Label1" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="rifp"><asp:Label ID="Label4" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="fecha"><asp:Label ID="Label7" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="dir1"><asp:Label ID="Label9" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="dir2"><asp:Label ID="Label17" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="telef"><asp:Label ID="Label22" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="lineasfact"> <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource6" Width="100%" CssClass="soloimp">        
                         <Columns>
                             <asp:BoundField DataField="Codigo" HeaderText="&nbsp;" SortExpression="Codigo"></asp:BoundField>
                             <asp:BoundField DataField="Producto" HeaderText="&nbsp;" SortExpression="Producto"></asp:BoundField>
                             <asp:BoundField DataField="Lote" HeaderText="&nbsp;" SortExpression="Lote"></asp:BoundField>
                             <asp:BoundField DataField="FechaVenc" HeaderText="&nbsp;" SortExpression="FechaVenc" DataFormatString="{0:Y}"></asp:BoundField>
                             <asp:BoundField DataField="Cantidad" HeaderText="&nbsp;" SortExpression="Cantidad"></asp:BoundField>
                             <asp:BoundField DataField="Precio" HeaderText="&nbsp;" SortExpression="Precio" DataFormatString="{0:#,#}"></asp:BoundField>
                             <asp:BoundField DataField="Precio1" HeaderText="&nbsp;" SortExpression="Precio1" DataFormatString="{0:#,#}"></asp:BoundField>
                         </Columns>
                     </asp:GridView>
                     <asp:SqlDataSource runat="server" ID="SqlDataSource6" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT Producto.Codigo, Producto.Producto, Producto.Lote, Producto.FechaVenc, Lineas.Cantidad, Producto.Precio, Lineas.Precio FROM Lineas LEFT JOIN Producto ON Producto.Producto = Lineas.Producto WHERE iDVenta = @iDVenta;">
                         <SelectParameters>
                            <asp:CookieParameter CookieName="idventaC" Name="iDVenta" Type="String" />
        </SelectParameters>
                     </asp:SqlDataSource></div>
        <div class="soloimp" id="tot1"><asp:Label ID="Label24" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="tot2"><asp:Label ID="Label25" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="centro"><asp:Label ID="Label10" runat="server"  CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="numpe"><asp:Label ID="Label11" runat="server"  CssClass="soloimp" ></asp:Label></div>
        <div class="soloimp" id="noten"><asp:Label ID="Label12" runat="server" CssClass="soloimp" ></asp:Label></div>
        <%--<table style="width: 90%;" class="no-print">
             <tr>
                 <td><asp:Label ID="Label2" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" CssClass="soloimp"></asp:Label></td>                 
                 <td><asp:Label ID="Label20" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></td>
                 <td><asp:Label ID="Label3" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" CssClass="soloimp" ></asp:Label></td>
                 <td><asp:Label ID="Label21" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></td>                 
                 <td><asp:Label ID="Label5" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" CssClass="soloimp" ></asp:Label></td>
                 <td><asp:Label ID="Labe22" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></td>
             </tr>             
         </table>   
    <table style="width: 90%;">
             <tr>
                 <td><asp:Label ID="Label8" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" CssClass="soloimp"></asp:Label></td>                 
                 <td><asp:Label ID="Label23" runat="server" Text="Label" CssClass="soloimp" ></asp:Label></td>                 
             </tr>             
         </table>
    <table style="width: 90%;">
             <tr>
                 <td><asp:Label ID="Label10" runat="server" Text="&nbsp;" CssClass="soloimp"></asp:Label></td>                 
                 <td><asp:Label ID="Label11" runat="server" Text="" CssClass="soloimp" ></asp:Label></td>
                 <td><asp:Label ID="Label12" runat="server" Text="" CssClass="soloimp" ></asp:Label></td>
                 <td><asp:Label ID="Label13" runat="server" Text="" CssClass="soloimp" ></asp:Label></td>                 
                 <td><asp:Label ID="Label14" runat="server" Text="" CssClass="soloimp" ></asp:Label></td>
                 <td><asp:Label ID="Label15" runat="server" Text="" CssClass="soloimp" ></asp:Label></td>
             </tr>             
         </table> 
    <table style="width: 90%;">
             <tr>
                 <td><asp:Label ID="Label16" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" CssClass="soloimp"></asp:Label></td>                 
                 <td><asp:Label ID="Label60" runat="server"  CssClass="soloimp" ></asp:Label></td>                 
             </tr>   
        <tr>
                 <td><asp:Label ID="Label18" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" CssClass="soloimp"></asp:Label></td>                 
                 <td><asp:Label ID="Label19" runat="server"  CssClass="soloimp" ></asp:Label></td>                 
             </tr>  
         </table>
    <table style="width: 90%;" class="no-print">
             <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                 <td>
                     <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" Width="90%" CssClass="soloimp">
                         <Columns>
                             <asp:BoundField DataField="Codigo" HeaderText="&nbsp;" SortExpression="Codigo"></asp:BoundField>
                             <asp:BoundField DataField="Producto" HeaderText="&nbsp;" SortExpression="Producto"></asp:BoundField>
                             <asp:BoundField DataField="Lote" HeaderText="&nbsp;" SortExpression="Lote"></asp:BoundField>
                             <asp:BoundField DataField="FechaVenc" HeaderText="&nbsp;" SortExpression="FechaVenc"></asp:BoundField>
                             <asp:BoundField DataField="Cantidad" HeaderText="&nbsp;" SortExpression="Cantidad"></asp:BoundField>
                             <asp:BoundField DataField="Precio" HeaderText="&nbsp;" SortExpression="Precio"></asp:BoundField>
                             <asp:BoundField DataField="Precio1" HeaderText="&nbsp;" SortExpression="Precio1"></asp:BoundField>
                         </Columns>
                     </asp:GridView>
                     <asp:SqlDataSource runat="server" ID="SqlDataSource5" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT Producto.Codigo, Producto.Producto, Producto.Lote, Producto.FechaVenc, Lineas.Cantidad, Producto.Precio, Lineas.Precio FROM Lineas LEFT JOIN Producto ON Producto.Producto = Lineas.Producto WHERE iDVenta = @iDVenta;">
                         <SelectParameters>
                            <asp:CookieParameter CookieName="idventaC" Name="iDVenta" Type="String" />
        </SelectParameters>
                     </asp:SqlDataSource>
                 </td>                         
             </tr>             
         </table>--%>
        </div>
    </asp:Content>
