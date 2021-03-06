<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsVenCli.aspx.cs" Inherits="PanelAdmin.ConsVenCli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
         <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="CONSULTA PRODUCTO CLIENTE" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                        
                    <table style="width: 100%;">
                        
                        <tr>
                            
                            <td><asp:Label ID="Label1" runat="server" Text="SELECCIONE EL CLIENTE" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                        </td>                            
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT [Nombre] FROM [Clientes] WHERE ([Tipo] = @Tipo)">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="CLIENTE" Name="Tipo" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td> 
                                                                             
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
