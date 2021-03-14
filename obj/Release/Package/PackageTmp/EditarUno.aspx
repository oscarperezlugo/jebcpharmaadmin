<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarUno.aspx.cs" Inherits="PanelAdmin.EditarUno" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
         
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="LISTA CLIENTES" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                       
                    <center><input class="formulario" placeholder="Nombre" id="Correo" type="text" runat="server"/>  
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BUSCAR CLIENTE"  OnClick="Unnamed1_Click"/></center>
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" DataKeyNames="Row">
                        <AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                        <Columns>                            
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo"></asp:BoundField>
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono"></asp:BoundField>
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />                            
                            <asp:BoundField DataField="Vendedor" HeaderText="Vendedor" SortExpression="Vendedor" />                                                                                    
                            <asp:BoundField DataField="Row" HeaderText="Row" SortExpression="Row" InsertVisible="False" ReadOnly="True" />
                            <asp:BoundField DataField="Rif" HeaderText="Rif" SortExpression="Rif" />
                            <asp:BoundField DataField="sicm" HeaderText="sicm" SortExpression="sicm" />
                            <asp:BoundField DataField="Telefono2" HeaderText="Telefono2" SortExpression="Telefono2"></asp:BoundField>
                            <asp:BoundField DataField="TipoCliente" HeaderText="TipoCliente" SortExpression="TipoCliente"></asp:BoundField>
                            <asp:BoundField DataField="Persona" HeaderText="Persona" SortExpression="Persona"></asp:BoundField>
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Nombre], [Correo], [Telefono], [Direccion], [FechaRegistro], [iDCliente], [Row], [Rif], [sicm], [Telefono2], [TipoCliente], [Persona], [Vendedor] FROM [Clientes] WHERE Tipo = 'CLIENTE'"></asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" margin-left="2%" DataKeyNames="Row">
                        <AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo"></asp:BoundField>
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono"></asp:BoundField>
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion"></asp:BoundField> 
                            <asp:BoundField DataField="Vendedor" HeaderText="Vendedor" SortExpression="Vendedor" /> 
                            <asp:BoundField DataField="Row" HeaderText="Row" SortExpression="Row" InsertVisible="False" ReadOnly="True" />
                            <asp:BoundField DataField="Rif" HeaderText="Rif" SortExpression="Rif" />                            
                            <asp:BoundField DataField="sicm" HeaderText="sicm" SortExpression="sicm"></asp:BoundField>
                            <asp:BoundField DataField="Telefono2" HeaderText="Telefono2" SortExpression="Telefono2"></asp:BoundField>
                            <asp:BoundField DataField="TipoCliente" HeaderText="TipoCliente" SortExpression="TipoCliente"></asp:BoundField>
                            <asp:BoundField DataField="Persona" HeaderText="Persona" SortExpression="Persona"></asp:BoundField>
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
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PaladarMobileConnectionString %>" SelectCommand="SELECT [Nombre], [Correo], [Telefono], [Direccion], [FechaRegistro], [iDCliente], [Row], [Rif], [Sueldo], [sicm], [Telefono2], [TipoCliente], [Persona], [Vendedor] FROM [Clientes] WHERE ([Nombre] LIKE '%' + @Nombre + '%') AND Tipo='CLIENTE'">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramcincoC" Name="Nombre" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>           
                    </div>
        </div>
        </div>
        </div>
</asp:Content>
