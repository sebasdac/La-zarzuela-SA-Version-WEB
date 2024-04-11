﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.Formulario_web1" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Css/Estilos1.css" rel="stylesheet" />
               <div class="form-container">
        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label8" runat="server" Text="Codigo:"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server" CssClass="centro"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="centro"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label>
            <asp:TextBox ID="txtPrecio" runat="server" CssClass="centro"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label6" runat="server" Text="Cantidad:"></asp:Label>
            <asp:TextBox ID="txtCantidad" CssClass="centro" runat="server"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label5" runat="server" Text="IVA: "></asp:Label>
            <asp:Label ID="lblImpuestoMostrar" runat="server"  Text="___________"></asp:Label>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label7" runat="server" Text="Total: "></asp:Label>
            <asp:Label ID="lblTotalMostrar" runat="server" Text="_______"></asp:Label>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID ="lblError" runat="server" CssClass="error" Text="error" Visible="False"></asp:Label>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
        </div>

        <div  id="contenedorGridView" class="form-group" style="display: inline-block; width: 100%;">
            <asp:GridView ID="dgvProductos" runat="server" AutoGenerateSelectButton="true" CssClass="styled-gridview" OnSelectedIndexChanged="dgvProductos_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </div>




</asp:Content>
