<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmImpuestos.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Css/Estilos1.css" rel="stylesheet" />
           <div class="form-container">
    <div class="form-group" style="display: inline-block; width: 50%;">
        <asp:Label ID="lblMesaConsultar" runat="server" Text="Mes a consultar:"></asp:Label>
        <asp:TextBox ID="txtMes" runat="server" CssClass="centro"></asp:TextBox>
    </div>
    

    <div class="form-group" style="display: inline-block; width: 50%;">
        <asp:Label ID="lblImpuesto" runat="server" Text="Impuesto a pagar:"></asp:Label>
        <asp:TextBox ID="txtImpuesto" runat="server" CssClass="centro" ReadOnly="True"></asp:TextBox>
    </div>
    <div>

        <asp:Label ID="lblError" runat="server" Text="Error" CssClass="error" Visible="False"></asp:Label>

    </div>
    <div>

        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />

    </div>
</asp:Content>
