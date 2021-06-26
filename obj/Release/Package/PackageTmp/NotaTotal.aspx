﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NotaTotal.aspx.cs" Inherits="PanelAdmin.NotaTotal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">   
    
    <div class="container containerPrint">
        <asp:Panel ID="pnl1" ClientIDMode="Static" CssClass="pnlCSS" runat="server"> 
            <div id="mainpnl">
                <br />
                    <br />
                    <br />
                    <br />
    <div class="card printtest">
        <div class="card-header">
                <div class="form-row">
                    
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="NOTA DE ENTREGA #: " Style="font-weight: bold; font-size: 18px;"></asp:Label>  
                        <asp:Label ID="Label1" runat="server"  Style="font-weight: bold; font-size: 18px; text-align:right;"></asp:Label> 
                    </div>                   
                </div>
            </div>
        <div class="card-body printbody">
                <div class="form-row printtest">   
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" GridLines="None" AllowPaging="True" CssClass="mGrid2" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <%--<asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />--%>
            <asp:BoundField DataField="Rif" HeaderText="Rif" SortExpression="Rif" />
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
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT distinct [Nombre], [Direccion], [Rif] FROM [Clientes] WHERE ([iDCliente] = @iDCliente)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="idclienteC" Name="iDCliente" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid2" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
        <Columns>
            <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
            <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
            <asp:BoundField DataField="FechaVenta" HeaderText="Fecha Cotizacion" SortExpression="FechaVenta" DataFormatString="{0:d}" />
            
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
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" GridLines="None" AllowPaging="True" CssClass="mGrid2" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" ShowFooter="true">
        <Columns>
            <asp:BoundField DataField="Producto" HeaderText="Descripcion" SortExpression="Producto" />
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
                   <%-- <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" GridLines="None" AllowPaging="True" CssClass="mGrid2" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" DataKeyNames="Row">
                        <Columns>
                            <%--<asp:BoundField DataField="Row" HeaderText="COTIZACION #" SortExpression="Row" InsertVisible="False" ReadOnly="True" />--%>
                           <%-- <%--<asp:BoundField DataField="Lineas" HeaderText="Lineas" SortExpression="Lineas" />--%>
                            <%--<asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" DataFormatString="{0:#,#}">
                                <ItemStyle ForeColor="#009933"></ItemStyle>
                            </asp:BoundField>
        </Columns>--%>
        <%--<FooterStyle BackColor="#CCCC99" ForeColor="Black"/>
                            <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="black"/>
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right"/>
                            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White"/>
                            <SortedAscendingCellStyle BackColor="#F7F7F7"/>
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B"/>
                            <SortedDescendingCellStyle BackColor="#E5E5E5"/>
                            <SortedDescendingHeaderStyle BackColor="#242121"/>
    </asp:GridView>--%>
                   <%-- <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Row], [Lineas], [Monto] FROM [Cabecera] WHERE ([iDVenta] = @iDVenta)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="idventaC" Name="iDVenta" Type="String"/>
        </SelectParameters>--%>
   <%-- </asp:SqlDataSource>--%>
    <br/>
                    <hr />
                    <table style="width:100%">
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" text="ENTREGADO POR:" Style="font-weight: bold; font-size: 12px; text-align:right;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" text="RECIBIDO POR:" Style="font-weight: bold; font-size: 12px; text-align:right;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" text="NOMBRE:" Style="font-weight: bold; font-size: 12px; text-align:right;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" text="NOMBRE:" Style="font-weight: bold; font-size: 12px; text-align:right;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" text="C.I:" Style="font-weight: bold; font-size: 12px; text-align:right;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label8" runat="server" text="C.I:" Style="font-weight: bold; font-size: 12px; text-align:right;"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    
          
        
                <hr  class="no-print"/>
                <center><asp:Button class="botonsubmit" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit no-print"  OnClientClick="javascript:window.print();"  Text="IMPRIMIR"/></center>
    </div>    
    </div>
            </div>
        </div>
            </asp:Panel>
        <%--<div class="fila col10L">--%>
        
                    
      

            <%--</div> --%> 
        </div>
           
    
                  
    </asp:Content>
