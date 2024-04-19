<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarProductos.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <link href="../Css/Contenedores.css" rel="stylesheet" />



    <div id="contenedor-clientes">

    <div>
        <asp:Label ID="Label3" runat="server" Text="Seleccione el proveedor:" CssClass="h1"></asp:Label>
    </div>

        <div>

            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Proveedor" DataValueField="Codigo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto IIConnectionString3 %>" SelectCommand="SELECT [Codigo], [Proveedor] FROM [Proveedores]"></asp:SqlDataSource>

            <asp:Button ID="btnSeleccionarProveedor" runat="server" Text="Seleccionar" OnClick="btnSeleccionarProveedor_Click" />
            <asp:Button ID="btnEliminarFactura" runat="server" Text="Eliminar factura" />
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

            <asp:Calendar ID="calFecha" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="189px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="285px">
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

               <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" />

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
          <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
          <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
          <asp:Button ID="btnRealizarCompra" runat="server" Text="Realizaar compra" />
      </div>
      <div>
          <asp:Label ID="lblMensaje" runat="server" Text="Label" CssClass="error" Visible="False"></asp:Label>
      </div>


 </div>

  <div id="contenedor-detalles">


      <asp:GridView ID="dgvProductos" runat="server">
      </asp:GridView>


  </div>
</asp:Content>
