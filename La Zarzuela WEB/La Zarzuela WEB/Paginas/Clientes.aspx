<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
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
            <asp:Label ID="Label4" runat="server" Text="Tipo:"></asp:Label>
            <asp:TextBox ID="txtTipo" runat="server" CssClass="centro"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label6" runat="server" Text="Cedula:"></asp:Label>
            <asp:TextBox ID="txtCedula" CssClass="centro" runat="server"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label5" runat="server" Text="Direccion:"></asp:Label>
            <asp:TextBox ID="txtDireccion" CssClass="centro" runat="server"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label7" runat="server" Text="Provincia:"></asp:Label>
            <asp:TextBox ID="txtProvincia" CssClass="centro" runat="server"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label1" runat="server" Text="Telefono:"></asp:Label>
            <asp:TextBox ID="txtTelefono" CssClass="centro" runat="server"></asp:TextBox>
        </div>
        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label2" runat="server" Text="Correo:"></asp:Label>
            <asp:TextBox ID="txtCorreo" CssClass="centro" runat="server" OnTextChanged="txtCorreo_TextChanged"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID ="lblError" runat="server" CssClass="error" Text="error" Visible="False"></asp:Label>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
        </div>

        <div  id="contenedorGridView" class="form-group" style="display: inline-block; width: 100%;">
            <asp:GridView ID="dgvClientes" runat="server" CssClass="styled-gridview">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
