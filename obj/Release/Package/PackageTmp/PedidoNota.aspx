<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedidoNota.aspx.cs" Inherits="PanelAdmin.PedidoNota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
         <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="NOTA DE ENTREGA" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                        
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="SELECCIONE EL CLIENTE" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />                                
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT [Nombre] FROM [Clientes] WHERE ([Tipo] = @Tipo)">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="CLIENTE" Name="Tipo" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td> 
                            <td><asp:Label ID="Label4" runat="server" Text="SELECCIONE EL VENDEDOR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />                                
                                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formulario" DataSourceID="SqlDataSource2" DataTextField="Nombre" DataValueField="Nombre"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT [Nombre] FROM [Clientes] WHERE ([Tipo] = @Tipo)">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="VENDEDOR" Name="Tipo" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>                          
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="SELECCIONE EL TIPO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formulario" >
                                    <asp:ListItem Value="DESPACHO">DESPACHO</asp:ListItem>
                                    <asp:ListItem Value="RETIRO">RETIRO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="PROCESO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formulario" OnSelectedIndexChanged="fijarproceso" AutoPostBack="true" disabled>
                                    <asp:ListItem Value="NOTA DE ENTREGA">NOTA DE ENTREGA</asp:ListItem>                      
                                </asp:DropDownList>
                                </td>
                        </tr>                        
                    </table>
                     <%--   <hr />
                    <asp:Label ID="Label5" runat="server" Text="OBSERVACIONES" Style="font-weight: bold; font-size: 18px;" CssClass="no-print"></asp:Label>    
                    <hr class="no-print"/>--%>
         <%--<table style="width: 100%;">
             <tr>
                 <td> <asp:Label ID="Label7" runat="server" Text="CENTRO" class="formularioTIT" CssClass="no-print" Style="font-weight: bold; font-size: 14px;"></asp:Label><br /> 
                <input class="formulario no-print" placeholder="CENTRO" id="Nombre" type="text" required runat="server" maxlength="60"  /></td>
                 <td> <asp:Label ID="Label8" runat="server" Text="NUMERO DE FACTURA" class="formularioTIT" CssClass="no-print" Style="font-weight: bold; font-size: 14px;"></asp:Label><br /> 
                <input class="formulario no-print" placeholder="NUMERO DE FACTURA" id="Text1" type="text" required runat="server" maxlength="60" /></td>
                 <td> <asp:Label ID="Label10" runat="server" Text="FECHA DE FACTURA" class="formularioTIT" CssClass="no-print" Style="font-weight: bold; font-size: 14px;"></asp:Label><br /> 
                <input class="formulario no-print" placeholder="FECHA FACTURA" id="Text2" type="date" required runat="server" maxlength="60" /></td>
                 <td> <asp:Label ID="Label9" runat="server" Text="NOTA DE ENTREGA" class="formularioTIT" CssClass="no-print" Style="font-weight: bold; font-size: 14px;"></asp:Label><br /> 
                     <input class="formulario no-print" placeholder="NOTA DE ENTREGA" id="Text3" type="text" required runat="server" maxlength="60" />
                     <%--<asp:DropDownList ID="DropDownList5" runat="server" CssClass="formulario" DataSourceID="SqlDataSource3" DataTextField="Row" DataValueField="Row">
                     </asp:DropDownList>
                     <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT [Row] FROM [Cabecera] WHERE ([Tipo] = @Tipo)">
                         <SelectParameters>
                             <asp:Parameter DefaultValue="NOTA DE ENTREGA" Name="Tipo" Type="String"></asp:Parameter>
                         </SelectParameters>
                     </asp:SqlDataSource>--%>
              <%--   </td>
             </tr>
             
         </table>--%>
         <hr class="no-print"/>
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="SIGUIENTE" UseSubmitBehavior="False" />            
            </div>
        </div>
        </div>
        </div>
        </div>
        </div>
</asp:Content>
