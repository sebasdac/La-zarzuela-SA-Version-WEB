<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmFacturaVentas.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Css/Estilos1.css" rel="stylesheet" />
<div class="form-container">
    <div>
        <asp:Label ID="lblFacturasCompra" runat="server" Text="Facturas de venta" CssClass="h1"></asp:Label>
    </div>
    <div class="form-group" style="display: inline-block; width: 50%;">
        <asp:Label ID="Label8" runat="server" Text="ID de factura:"></asp:Label>
        <asp:TextBox ID="txtNumeroFactura" runat="server" CssClass="centro"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
    </div>
    <div>

        <asp:Label ID="lblError" runat="server" Text="lblError" Visible="False"></asp:Label>

    </div>
    <div>
        <asp:Label ID="lblFactura" runat="server" CssClass="h3" Text="Factura"></asp:Label>
    </div>
    <div>
        <div>
            <asp:GridView ID="dgvFacturaCompra" runat="server"  CssClass="styled-gridview" >
            </asp:GridView>
        </div>
    </div>
    <div>
        <asp:Label ID="lblDetalles" runat="server" CssClass="h3" Text="Detalles"></asp:Label>
    </div>
    <div>
        <asp:GridView ID="dgvDetalles" runat="server" CssClass="styled-gridview">
        </asp:GridView>
    </div>
</div>
</asp:Content>
