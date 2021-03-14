<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="PanelAdmin.Categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
        <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="Crear Categoria" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width: 100%;">
                        <tr>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label1" runat="server" Text="Nombre de la Categoria" class="formularioTIT"></asp:Label><br /> 
                <input class="formulario" placeholder="Nombre de la Categoria" id="Nombre" type="text" required runat="server" maxlength="15"/>            
            </div>  </td>
                            <td><div class="fila col10L">
                                <asp:Label ID="Label2" runat="server" Text="Imagen de la Categoria" class="formularioTIT"></asp:Label><br />
               <c><asp:FileUpload ID="FileUpload1" runat="server" CssClass="formulario" /></c>                         
            </div>   </td>                            
                        </tr>                        
                    </table>
                      
              <hr />                
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="CREAR PRODUCTO" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="CREAR CATEGORIA"/>            
            </div>
        </div>
               </div>
            </div>
        </div>
        </div> 
</asp:Content>
