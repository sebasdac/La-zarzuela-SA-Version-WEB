<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Productos.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Estilo1.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
                :&nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="centro"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="centro"></asp:TextBox>
            </div>

            <div>

                <asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="centro"></asp:TextBox>

            </div>
            <div>


                <asp:Label ID="Label6" runat="server" Text="Cantidad:"></asp:Label>
                <asp:TextBox ID="TextBox4" CssClass="centro" runat="server"></asp:TextBox>


            </div>



            <div>
                <asp:Label ID="Label5" runat="server" Text="IVA: "></asp:Label>
                <asp:Label ID="lblIVAMostrar" runat="server"  Text="___________"></asp:Label>
            </div>
            <div>

            <asp:Label ID="Label7" runat="server" Text="Total: "></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="_______"></asp:Label>

            </div>

            <div>
                <asp:Label ID ="Label2" runat="server" CssClass="error" Text="error"></asp:Label>
            </div>

            <div>
                
            </div>

            <div>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </div>




        </div>
    </form>
</body>
</html>
