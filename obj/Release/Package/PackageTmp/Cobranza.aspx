<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cobranza.aspx.cs" Inherits="PanelAdmin.Cobranza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
        <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                         <asp:Label ID="Label6" runat="server" Text="Registrar Pago" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">  
                    <table style="width: 100%;">
                        <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label1" runat="server" Text="MONEDA" class="formularioTIT"></asp:Label><br />  
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formulario">
                    <asp:ListItem>DOLARES</asp:ListItem>
                    <asp:ListItem>BOLIVARES</asp:ListItem>
                    <asp:ListItem>BITCOIN</asp:ListItem>
                </asp:DropDownList>          
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label2" runat="server" Text="METODO" class="formularioTIT"></asp:Label><br />  
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario">
                    <asp:ListItem>TRANSFERENCIA</asp:ListItem>
                    <asp:ListItem>EFECTIVO</asp:ListItem>                    
                </asp:DropDownList>             
            </div></td>
                            <td><div class="fila col10L">
                                  <asp:Label ID="Label3" runat="server" Text="FACTURA" class="formularioTIT"></asp:Label><br />                       
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formulario" DataSourceID="SqlDataSource1" DataTextField="NroOp" DataValueField="NroOp">
                                </asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:PaladarMobileConnectionString %>' SelectCommand="SELECT [NroOp] FROM [Cabecera] WHERE ([Status] NOT LIKE '%' + @Status + '%')">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="FINALIZADO" Name="Status" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label4" runat="server" Text="BANCO" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="BANESCO ENTIDAD" id="Telefono" type="text" maxlength="11" required runat="server"/>            
            </div></td>                            
                        </tr>
                        <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label5" runat="server" Text="FECHA" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="CPE" id="Text2" type="datetime-local" required runat="server"/>                      
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label7" runat="server" Text="CONFIRMACION" class="formularioTIT"></asp:Label><br /> 
                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formulario">
                    <asp:ListItem>SI</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>                    
                </asp:DropDownList> 
            </div></td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label8" runat="server" Text="MONTO" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="1989,32" id="Contrasena" type="text" required runat="server"/>            
            </div></td>
                            <td></td>
                        </tr>                        
                    </table>
            
            
            
            
            
            
            
            <hr />
           
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRAR CLIENTE" type="submit"  runat="server" CssClass="botonsubmit no-print"  OnClick="Unnamed1_Click"  Text="REGISTRAR PAGO"/>           <br /> 
                <br /> 
                 
            </div>
        </div>
            </div>
            </div>
        </div>
        </div>    
</asp:Content>
