<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tasa.aspx.cs" Inherits="PanelAdmin.Tasa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
         <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="ACTUALIZAR TASA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">        
    <div class="fila col10L"> 
        <label>TASA DEL DIA </label><br />
        <label runat="server" id="TagTasa" class=""></label><br />
        <hr />
                <input class="formulario" placeholder="Tasa Bs. formato (555555.99)" id="TasaDia" type="text"  required runat="server" maxlength="10"/> 
            </div>
                    <hr />
    <div class="fila col10L">
                <asp:Button class="botonsubmit" value="CREAR PRODUCTO" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="ACTUALIZAR TASA"/>            
            </div>
        </div>
              </div>
            </div>
        </div>
        </div> 
</asp:Content>
