<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCateg.aspx.cs" Inherits="PanelAdmin.ListaCateg" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <c><p><h2>LISTA CATEGORIAS</h2></p></c>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
        <Columns>                   
            <asp:BoundField DataField="Producto" HeaderText="Producto" SortExpression="Producto" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
            <asp:BoundField DataField="iDProducto" HeaderText="iDProducto" SortExpression="iDProducto" />
            <asp:BoundField DataField="PrecioD" HeaderText="PrecioD" SortExpression="PrecioD" />
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />            
            <asp:BoundField DataField="Impuesto" HeaderText="Impuesto" SortExpression="Impuesto" />
        </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Producto], [Precio], [iDProducto], [PrecioD], [Categoria], [Cantidad], [Impuesto] FROM [Producto] ORDER BY [Categoria]"></asp:SqlDataSource>
</asp:Content>
