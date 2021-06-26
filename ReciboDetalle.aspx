<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReciboDetalle.aspx.cs" Inherits="PanelAdmin.ReciboDetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">   
     <div class="container">
          <br />
                    <br />
                    <br />
                    <br />
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server"  Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                
                    </div>                   
                </div>
            </div>
        <div class="card-body printbody">
                <div class="form-row">
    <c><p><h2></h2></p></c>
                   
                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" DataKeyNames="Row">
                        <Columns>
                            <asp:BoundField DataField="Metodo" HeaderText="Metodo" SortExpression="Metodo" />                          
                    <%--        <asp:BoundField DataField="Row" HeaderText="#" SortExpression="Row" InsertVisible="False" ReadOnly="True" />--%>
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                            <asp:BoundField DataField="FactPagada" HeaderText="Factura Pagada" SortExpression="FactPagada"></asp:BoundField>
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
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Metodo], [Row], [Fecha], [FactPagada] FROM [Pagos] WHERE ([FactPagada] = @FactPagada)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="cobR" Name="FactPagada" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" ShowFooter="true">
        <Columns>
            <asp:BoundField DataField="Cinfirmacion" HeaderText="Cinfirmacion" SortExpression="Cinfirmacion" />
            <asp:BoundField DataField="Moneda" HeaderText="Moneda" SortExpression="Moneda" />
            <asp:BoundField DataField="Banco" HeaderText="Banco" SortExpression="Banco" />
            <asp:BoundField DataField="MontoFin" HeaderText="Monto" SortExpression="MontoFin" />
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
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Cinfirmacion], [Moneda], [Banco], [MontoFin] FROM [Pagos] WHERE ([FactPagada] = @FactPagada)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="cobR" Name="FactPagada" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    
    
    <div class="fila col10L">
                
            </div>
                    <br />
                    <div class="fila col10L">
                <center><asp:Button class="botonsubmit no-print" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit no-print" OnClientClick="javascript:window.print();" ID="PrintBut"  Text="IMPRIMIR" UseSubmitBehavior="false"/></center>            
            </div>
                    </div>
            </div>
        </div>
        </div>
    
        
    </asp:Content>
