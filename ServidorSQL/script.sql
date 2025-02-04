USE [Proyecto II]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Codigo] [varchar](900) NOT NULL,
	[Nombre] [varchar](60) NULL,
	[Tipo] [varchar](60) NULL,
	[Cedula] [varchar](60) NULL,
	[Direccion] [varchar](60) NULL,
	[Provincia] [varchar](60) NULL,
	[Telefono] [varchar](60) NULL,
	[Correo] [varchar](60) NULL,
	[Contrasena] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesFactura]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesFactura](
	[DetalleID] [int] IDENTITY(1,1) NOT NULL,
	[FacturaID] [int] NULL,
	[ProductoID] [int] NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](18, 2) NULL,
	[SubTotal] [decimal](18, 2) NULL,
	[TotalProducto] [decimal](18, 2) NULL,
	[Impuesto] [decimal](18, 2) NULL,
	[ProductoNombre] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[DetalleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesFacturaCompra]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesFacturaCompra](
	[DetalleID] [int] IDENTITY(1,1) NOT NULL,
	[FacturaID] [int] NULL,
	[ProductoID] [int] NULL,
	[ProductoNombre] [varchar](50) NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](18, 2) NULL,
	[SubTotal] [decimal](18, 2) NULL,
	[Impuesto] [decimal](18, 2) NULL,
	[TotalProducto] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[DetalleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[FacturaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NULL,
	[NombreCliente] [varchar](50) NULL,
	[CedulaCliente] [varchar](50) NULL,
	[TipoCliente] [varchar](50) NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[FacturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaCompra]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaCompra](
	[FacturaID] [int] IDENTITY(1,1) NOT NULL,
	[ProveedorID] [int] NULL,
	[NombreProveedor] [varchar](50) NULL,
	[CedulaProveedor] [varchar](50) NULL,
	[Tipo] [varchar](50) NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[FacturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pin]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pin](
	[Pin] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Pin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Codigo] [int] NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](18, 0) NULL,
	[Impuesto] [decimal](18, 0) NULL,
	[Total] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Codigo] [varchar](300) NOT NULL,
	[Proveedor] [varchar](30) NULL,
	[Tipo] [varchar](10) NULL,
	[Cedula] [varchar](15) NULL,
	[Direccion] [varchar](255) NULL,
	[Provincia] [varchar](20) NULL,
	[Telefono] [decimal](18, 0) NULL,
	[Correo] [varchar](100) NULL,
	[Contrasena] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usuario] [nvarchar](25) NOT NULL,
	[Contrasena] [nvarchar](25) NULL,
	[Cedula] [varchar](13) NULL,
	[Nombre] [varchar](25) NULL,
	[Estado] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetallesFactura]  WITH CHECK ADD FOREIGN KEY([FacturaID])
REFERENCES [dbo].[Factura] ([FacturaID])
GO
ALTER TABLE [dbo].[DetallesFacturaCompra]  WITH CHECK ADD FOREIGN KEY([FacturaID])
REFERENCES [dbo].[FacturaCompra] ([FacturaID])
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 22/4/2024 11:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarCliente]
    @Codigo NVARCHAR(50),
    @Nombre NVARCHAR(50),
	@Tipo NVARCHAR(50),
	@Cedula NVARCHAR(50),
	@Direccion NVARCHAR(50),
	@Provincia NVARCHAR(50),
	@Telefono NVARCHAR(50),
	@Correo NVARCHAR (50),
	@Contrasena NVARCHAR(50)
    
    -- Agrega otros parámetros según tus necesidades
AS
BEGIN
    INSERT INTO Clientes (Codigo, Nombre,Tipo, Cedula, Direccion, Provincia, Telefono, Correo, Contrasena)
    VALUES (@Codigo, @Nombre,@Tipo, @Cedula, @Direccion, @Provincia, @Telefono, @Correo, @Contrasena);
END;
GO
