<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="VentaProducto.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Css/Contenedores.css" rel="stylesheet" />



      <div id="contenedor-clientes">

      <div>
          <asp:Label ID="Label3" runat="server" Text="Seleccione el cliente:" CssClass="h1"></asp:Label>
      </div>

          <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3" DataTextField="Nombre" DataValueField="Codigo" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
      </asp:DropDownList>
      <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto IIConnectionString %>" SelectCommand="SELECT [Codigo], [Nombre] FROM [Clientes]"></asp:SqlDataSource>
          <div>

              <asp:Button ID="btnSeleccionarCliente" runat="server" OnClick="btnSeleccionarCliente_Click" Text="Seleccionar" style="height: 26px" />
              <asp:Button ID="btnEliminarFactura" runat="server" OnClick="btnEliminarFactura_Click" Text="Eliminar factura" />
          </div>
      <div>
          <asp:Label ID="lblCodigoCliente" runat="server" Text="Codigo:"></asp:Label>
          <asp:Label ID="lblCodigoMostrarCliente" runat="server" Text="______"></asp:Label>
      </div>
      <div>
          <asp:Label ID="lblNombreCliente" runat="server" Text="Nombre:"></asp:Label>
          <asp:Label ID="lblNombreMostrarCliente" runat="server" Text="______"></asp:Label>
      </div>
      <div>

          <asp:Label ID="lblCedula" runat="server" Text="Cedula:"></asp:Label>
          <asp:Label ID="lblMostrarCedula" runat="server" Text="______"></asp:Label>

      </div>
      <div>

          <asp:Label ID="lblTipo" runat="server" Text="Tipo:"></asp:Label>
          <asp:Label ID="lblMostrarTipo" runat="server" Text="______"></asp:Label>

      </div>
          <div>

              <asp:Calendar ID="calFecha" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="103px" NextPrevFormat="ShortMonth" OnSelectionChanged="calFecha_SelectionChanged" Width="215px">
                  <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                  <DayStyle BackColor="#CCCCCC" />
                  <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                  <OtherMonthDayStyle ForeColor="#999999" />
                  <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                  <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                  <TodayDayStyle BackColor="#999999" ForeColor="White" />
              </asp:Calendar>

          </div>


  </div>








    <div id="contenedor-productos">
        <div>
            
            <asp:Label ID="Label1" runat="server" Text="Seleccione el producto:" CssClass="h1"></asp:Label>
        </div>
        
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Codigo" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto IIConnectionString %>" ProviderName="<%$ ConnectionStrings:Proyecto IIConnectionString.ProviderName %>" SelectCommand="SELECT [Codigo], [Nombre], [Cantidad], [Precio] FROM [Productos]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>


              <asp:Button ID="btnSeleccionar" runat="server" OnClick="btnSeleccionar_Click" Text="Seleccionar" style="height: 26px" />
            <div>

                <asp:Label ID="lblCodigo" runat="server" Text="Codigo:"></asp:Label>
                <asp:Label ID="lblCodigoMostrar" runat="server" Text="______"></asp:Label>

                <asp:Label ID="lblFacturaID" runat="server" Text="Factura ID: "></asp:Label>
                    <asp:Label ID="lblFacturaIDMostrar" runat="server" Text="______"></asp:Label>

            </div>
            <div>

                <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                <asp:Label ID="lblNombreMostrar" runat="server" Text="______"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblCantidad" runat="server" Text="Cantidad disponible:"></asp:Label>
                    <asp:Label ID="lblCantidadMostrar" runat="server" Text="______"></asp:Label>
            </div>
            <div>

                <asp:Label ID="lblPrecio" runat="server" Text="Precio:"></asp:Label>
                <asp:Label ID="lblPrecioMostrar" runat="server" Text="______"></asp:Label>
            </div>

            <div>

                <asp:Label ID="Label2" runat="server" Text="Ingrese la cantidad desada:"></asp:Label>
                <asp:TextBox ID="txtCantidadDeseada" runat="server" Width="84px"></asp:TextBox>

            </div>
        <div>
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" style="height: 26px" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
            <asp:Button ID="btnGenerarFactura" runat="server" OnClick="btnGenerarFactura_Click" Text="Realizar compra" />
        </div>
        <div>
            <asp:Label ID="lblMensaje" runat="server" Text="Label" CssClass="error" Visible="False"></asp:Label>
        </div>


   </div>

    <div id="contenedor-detalles">


        <asp:GridView ID="dgvProductos" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvProductos_SelectedIndexChanged" style="margin-top: 0px">
        </asp:GridView>


    </div>

  
    

</asp:Content>
