<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarInventario.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <link href="../Css/Estilos1.css" rel="stylesheet" />


    <div id="form-container">

    <div>
        <asp:Label ID="Label3" runat="server" Text="Seleccione el proveedor:" CssClass="h1"></asp:Label>
    </div>
        <div>

            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Proveedor" DataValueField="Codigo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto IIConnectionString %>" ProviderName="<%$ ConnectionStrings:Proyecto IIConnectionString.ProviderName %>" SelectCommand="SELECT [Codigo], [Proveedor] FROM [Proveedores]"></asp:SqlDataSource>

        </div>
        <div>

            <asp:Button ID="btnSeleccionarProveedor" runat="server" OnClick="Button1_Click" Text="Seleccionar" />
            <asp:Button ID="btnEliminarFactura" runat="server" Text="Eliminar factura" OnClick="btnEliminarFactura_Click" />
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

            <asp:Calendar ID="calFecha" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="163px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="259px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                <DayStyle Width="14%" />
                <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                <TodayDayStyle BackColor="#CCCC99" />
            </asp:Calendar>

        </div>


</div>








  <div id="contenedor-productos">
      <div>
          
          <asp:Label ID="Label1" runat="server" Text="Seleccione el producto:" CssClass="h1"></asp:Label>
      </div>
      <div>

          <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Codigo">
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto IIConnectionString %>" ProviderName="<%$ ConnectionStrings:Proyecto IIConnectionString.ProviderName %>" SelectCommand="SELECT [Codigo], [Nombre] FROM [Productos]"></asp:SqlDataSource>

      </div>
      <div>


          <asp:Button ID="btnSeleccionarProducto" runat="server" Text="Seleccionar" OnClick="btnSeleccionarProducto_Click" />


      </div>

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
              <asp:Label ID="lblCantidad" runat="server" Text="Cantidad:"></asp:Label>
                  <asp:Label ID="lblCantidadMostrar" runat="server" Text="______"></asp:Label>
          </div>
          <div>

              <asp:Label ID="lblPrecio" runat="server" Text="Precio:"></asp:Label>
              <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
          </div>

          <div>

              <asp:Label ID="lblCantidadIngresada" runat="server" Text="Ingrese la cantidad desada:"></asp:Label>
              <asp:TextBox ID="txtCantidadDeseada" runat="server" Width="84px"></asp:TextBox>

          </div>
      <div>
          <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
          <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click1" />
          <asp:Button ID="btnRealizarCompra" runat="server" Text="Realizar compra" OnClick="btnRealizarCompra_Click1" />
      </div>
      <div>
          <asp:Label ID="lblMensaje" runat="server" Text="Label" CssClass="error" Visible="False"></asp:Label>
      </div>


 </div>

  <div id="contenedor-detalles">


      <asp:GridView ID="dgvProductos" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvProductos_SelectedIndexChanged" CssClass="styled-gridview">
      </asp:GridView>


  </div>


</asp:Content>
