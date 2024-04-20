<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRecuperacionContrasena.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.frmRecuperacionContrasena" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <link href="Css/Estilos1.css" rel="stylesheet" />
                       <div class="form-container">
                <div class="form-group" style="display: inline-block; width: 50%;">
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="centro"></asp:TextBox>
                </div>

                <div class="form-group" style="display: inline-block; width: 50%;">
                    <asp:Label ID="lblNuevacontrasena" runat="server" Text="Nueva contraseña"></asp:Label>
                    <asp:TextBox ID="txtNuevaContrasena" runat="server" CssClass="centro"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblMensaje" runat="server" Visible="False"></asp:Label>
                </div>

                

                <div class="form-group" style="display: inline-block; width: 50%;">
                    <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" style="height: 26px" />
                    
                </div>
 
            </div>

            <div>



            </div>


        </div>
    </form>
</body>
</html>
