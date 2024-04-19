<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="La_Zarzuela_WEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <link href="Estilos1.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-header">
            <h2>Iniciar sesión</h2>
        </div>
        <div>
            <asp:Login ID="LoginUsuario" runat="server" OnAuthenticate="Login1_Authenticate">
            </asp:Login>
        </div>
        <button type="submit" class="login-button">Iniciar sesión</button>
    </form>
</body>
</html>
