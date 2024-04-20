<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarProductos.aspx.cs" Inherits="La_Zarzuela_WEB.Paginas.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <link href="../Css/Contenedores.css" rel="stylesheet" />
    <link href="../Css/Estilos1.css" rel="stylesheet" />
   

    <div id="form-container">
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Seleccione el proveedor:" CssClass="h1"></asp:Label>
                </div>

                    <div>

                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Proveedor" DataValueField="Codigo">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto IIConnectionString %>" SelectCommand="SELECT [Codigo], [Proveedor] FROM [Proveedores]" ProviderName="<%$ ConnectionStrings:Proyecto IIConnectionString.ProviderName %>"></asp:SqlDataSource>

                        <asp:Button ID="btnSeleccionarProveedor" runat="server" Text="Seleccionar" OnClick="btnSeleccionarProveedor_Click" />
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









                  <div>
          
                      <asp:Label ID="Label1" runat="server" Text="Seleccione el producto:" CssClass="h1"></asp:Label>
                  </div>
                       <div>

                       </div>

                            <link href="../Css/Estilos1.css" rel="stylesheet" />
                                 <div>
                          <div class="form-group" style="display: inline-block; width: 50%;">
                              <asp:Label ID="Label8" runat="server" Text="Codigo:"></asp:Label>
                              <asp:TextBox ID="txtCodigo" runat="server" CssClass="centro"></asp:TextBox>
                          </div>

                          <div class="form-group" style="display: inline-block; width: 50%;">
                              <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
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
                          </div>
          
                  <div>
                      <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                      <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                      <asp:Button ID="btnRealizarCompra" runat="server" Text="Realizar compra" OnClick="btnRealizarCompra_Click" style="height: 26px" />
                  </div>
                  <div>
                      <asp:Label ID="lblMensaje" runat="server" Text="Label" Visible="False"></asp:Label>
                  </div>


             </div>

              <div id="contenedor-detalles">


                  <asp:GridView ID="dgvProductos" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvProductos_SelectedIndexChanged" CssClass="styled-gridview">
                  </asp:GridView>

              </div>
    </div>

</asp:Content>
