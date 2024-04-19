<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="../Css/Estilos1.css" rel="stylesheet" />
               <div class="form-container">
        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label8" runat="server" Text="Cedula:"></asp:Label>
            <asp:TextBox ID="txtCedula" runat="server" CssClass="centro"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="centro"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label4" runat="server" Text="Usuario:"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" CssClass="centro"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label6" runat="server" Text="Contraseña:"></asp:Label>
            <asp:TextBox ID="txtContrasena" CssClass="centro" runat="server"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label5" runat="server" Text="Pin: "></asp:Label>
            <asp:TextBox ID="txtPin" CssClass="centro" runat="server"></asp:TextBox>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID="Label7" runat="server" Text="Estado: "></asp:Label>
            <asp:DropDownList ID="cbEstado" runat="server">
                <asp:ListItem>Activo</asp:ListItem>
                <asp:ListItem>Inactivo</asp:ListItem>    
            </asp:DropDownList>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Label ID ="lblError" runat="server" CssClass="error" Text="error" Visible="False"></asp:Label>
            <asp:Label ID="mensaje" runat="server" Text="lblMensaje" Visible="False"></asp:Label>
        </div>

        <div class="form-group" style="display: inline-block; width: 50%;">
            <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" style="height: 26px" />
            <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        </div>

        <div  id="contenedorGridView" class="form-group" style="display: inline-block; width: 100%;">
            <asp:GridView ID="dgvUsuarios" runat="server" AutoGenerateSelectButton="true" CssClass="styled-gridview" OnSelectedIndexChanged="dgvUsuarios_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
