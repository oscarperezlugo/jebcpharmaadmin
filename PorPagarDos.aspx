<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PorPagarDos.aspx.cs" Inherits="PanelAdmin.PorPagarDos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="COMPRAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
    <c><p><h2></h2></p></c>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
        <Columns>            
            
            <asp:BoundField DataField="iDCliente" HeaderText="iDCliente" SortExpression="iDCliente" />
            <asp:BoundField DataField="FechaVenta" HeaderText="FechaVenta" SortExpression="FechaVenta" />
            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" />
 <%--           <asp:BoundField DataField="Lineas" HeaderText="Lineas" SortExpression="Lineas" />
            <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" SortExpression="SubTotal" />--%>
            <asp:BoundField DataField="iDVenta" HeaderText="iDVenta" SortExpression="iDVenta" />
            <asp:BoundField DataField="Row" HeaderText="#" SortExpression="Row" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
   <%--         <asp:BoundField DataField="TipoVenta" HeaderText="TipoVenta" SortExpression="TipoVenta" />
            <asp:BoundField DataField="Metodo" HeaderText="Metodo" SortExpression="Metodo" />--%>
          <%--  <asp:BoundField DataField="NroOp" HeaderText="Factura" SortExpression="NroOp" />--%>
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="DETALLE" />
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [iDCliente], [FechaVenta], [Monto], [Lineas], [SubTotal], [iDVenta], [Row], [Status], [TipoVenta], [Metodo], [Direccion], NroOp FROM [Cabecera] WHERE (([Tipo] = @Tipo))">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="COMPRA" Name="Tipo" Type="String"></asp:Parameter>                            
                        </SelectParameters>
                    </asp:SqlDataSource>
</div>
            </div>
        </div>
        </div>  
</asp:Content>
