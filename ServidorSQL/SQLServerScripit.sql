USE [master]
GO
/****** Object:  Database [Proyecto II]    Script Date: 15/4/2024 20:37:59 ******/
CREATE DATABASE [Proyecto II]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Productos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Productos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Productos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Productos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Proyecto II] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyecto II].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyecto II] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto II] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto II] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto II] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto II] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto II] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyecto II] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto II] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto II] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto II] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyecto II] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto II] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto II] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto II] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto II] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Proyecto II] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto II] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyecto II] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyecto II] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyecto II] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto II] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyecto II] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyecto II] SET RECOVERY FULL 
GO
ALTER DATABASE [Proyecto II] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto II] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyecto II] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyecto II] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyecto II] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyecto II] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proyecto II] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proyecto II', N'ON'
GO
ALTER DATABASE [Proyecto II] SET QUERY_STORE = ON
GO
ALTER DATABASE [Proyecto II] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Proyecto II]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 15/4/2024 20:37:59 ******/
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
/****** Object:  Table [dbo].[DetallesFactura]    Script Date: 15/4/2024 20:37:59 ******/
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
	[ProductoNombre] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[DetalleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesFacturaCompra]    Script Date: 15/4/2024 20:37:59 ******/
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
/****** Object:  Table [dbo].[Factura]    Script Date: 15/4/2024 20:37:59 ******/
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
	[Total] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[FacturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaCompra]    Script Date: 15/4/2024 20:37:59 ******/
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
	[Total] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[FacturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pin]    Script Date: 15/4/2024 20:37:59 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 15/4/2024 20:37:59 ******/
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
/****** Object:  Table [dbo].[Proveedores]    Script Date: 15/4/2024 20:37:59 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 15/4/2024 20:37:59 ******/
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
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'1', N'Sebas', N'Juridico', N'123456789', N'Cocori de la escuela cocoi ', N'Guanacaste', N'12345678', N'secoto@', N'qwas')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'123', N'Arron', N'Fisico', N'123456789', N'asd', N'Heredia', N'12345678', N'sebas@gmail.com', N'ASf@df23')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'128', N'Pruebanueva', N'Fisico', N'123456789', N'fsdf', N'San José', N'12345678', N'se@gmail.com', N'Sdasfg12@')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'2', N'Arron', N'Fisico', N'123456789', N'asd', N'Heredia', N'12345678', N'sebas@gmail.com', N'ASf@df23')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'23', N'Sebastian Coto', N'Juridico', N'305610818', N'COcori', N'Cartago', N'61951300', N'secoto12@gmail.com', N'Hairwax1@')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'3', N'Nicole', N'Físico', N'123456789', N'Cocori de la escuela cocoi ', N'Heredia', N'12345678', N'nicesa@', N'Ss2sdfega@')
GO
SET IDENTITY_INSERT [dbo].[DetallesFactura] ON 

INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (20, 21, 1, 1, CAST(120.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(135.60 AS Decimal(18, 2)), CAST(15.60 AS Decimal(18, 2)), N'Oreo')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (21, 22, 1, 1, CAST(120.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(135.60 AS Decimal(18, 2)), CAST(15.60 AS Decimal(18, 2)), N'Oreo')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (22, 23, 3, 3, CAST(125.00 AS Decimal(18, 2)), CAST(375.00 AS Decimal(18, 2)), CAST(423.75 AS Decimal(18, 2)), CAST(48.75 AS Decimal(18, 2)), N'Galletas')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (23, 23, 3, 3, CAST(125.00 AS Decimal(18, 2)), CAST(375.00 AS Decimal(18, 2)), CAST(423.75 AS Decimal(18, 2)), CAST(48.75 AS Decimal(18, 2)), N'Galletas')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (24, 23, 3, 2, CAST(125.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(282.50 AS Decimal(18, 2)), CAST(32.50 AS Decimal(18, 2)), N'Galletas')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (25, 24, 2, 2, CAST(125.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(282.50 AS Decimal(18, 2)), CAST(32.50 AS Decimal(18, 2)), N'Piña')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (26, 24, 4, 1, CAST(700.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(791.00 AS Decimal(18, 2)), CAST(91.00 AS Decimal(18, 2)), N'Cereal')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (27, 25, 4, 1, CAST(700.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(791.00 AS Decimal(18, 2)), CAST(91.00 AS Decimal(18, 2)), N'Cereal')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (28, 25, 3, 5, CAST(125.00 AS Decimal(18, 2)), CAST(625.00 AS Decimal(18, 2)), CAST(706.25 AS Decimal(18, 2)), CAST(81.25 AS Decimal(18, 2)), N'Galletas')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (29, 26, 3, 5, CAST(125.00 AS Decimal(18, 2)), CAST(625.00 AS Decimal(18, 2)), CAST(706.25 AS Decimal(18, 2)), CAST(81.25 AS Decimal(18, 2)), N'Galletas')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (30, 27, 5, 1, CAST(1250000.00 AS Decimal(18, 2)), CAST(1250000.00 AS Decimal(18, 2)), CAST(1412500.00 AS Decimal(18, 2)), CAST(162500.00 AS Decimal(18, 2)), N'iPhone 14')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (31, 28, 5, 1, CAST(1250000.00 AS Decimal(18, 2)), CAST(1250000.00 AS Decimal(18, 2)), CAST(1412500.00 AS Decimal(18, 2)), CAST(162500.00 AS Decimal(18, 2)), N'iPhone 14')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (32, 29, 5, 1, CAST(1250000.00 AS Decimal(18, 2)), CAST(1250000.00 AS Decimal(18, 2)), CAST(1412500.00 AS Decimal(18, 2)), CAST(162500.00 AS Decimal(18, 2)), N'iPhone 14')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (33, 30, 4, 1, CAST(700.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(791.00 AS Decimal(18, 2)), CAST(91.00 AS Decimal(18, 2)), N'Cereal')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (34, 30, 2, 3, CAST(125.00 AS Decimal(18, 2)), CAST(375.00 AS Decimal(18, 2)), CAST(423.75 AS Decimal(18, 2)), CAST(48.75 AS Decimal(18, 2)), N'Piña')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (35, 31, 5, 1, CAST(1250000.00 AS Decimal(18, 2)), CAST(1250000.00 AS Decimal(18, 2)), CAST(1412500.00 AS Decimal(18, 2)), CAST(162500.00 AS Decimal(18, 2)), N'iPhone 14')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (37, 32, 2, 2, CAST(75.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), CAST(169.50 AS Decimal(18, 2)), CAST(19.50 AS Decimal(18, 2)), N'Oreo')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (38, 32, 3, 2, CAST(600.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(1356.00 AS Decimal(18, 2)), CAST(156.00 AS Decimal(18, 2)), N'Cereal')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (39, 33, 3, 1, CAST(600.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), CAST(678.00 AS Decimal(18, 2)), CAST(78.00 AS Decimal(18, 2)), N'Cereal')
INSERT [dbo].[DetallesFactura] ([DetalleID], [FacturaID], [ProductoID], [Cantidad], [Precio], [SubTotal], [TotalProducto], [Impuesto], [ProductoNombre]) VALUES (40, 33, 1, 2, CAST(250.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(565.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), N'Leche')
SET IDENTITY_INSERT [dbo].[DetallesFactura] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallesFacturaCompra] ON 

INSERT [dbo].[DetallesFacturaCompra] ([DetalleID], [FacturaID], [ProductoID], [ProductoNombre], [Cantidad], [Precio], [SubTotal], [Impuesto], [TotalProducto]) VALUES (23, 22, 1, N'Leche', 2, CAST(250.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), CAST(565.00 AS Decimal(18, 2)))
INSERT [dbo].[DetallesFacturaCompra] ([DetalleID], [FacturaID], [ProductoID], [ProductoNombre], [Cantidad], [Precio], [SubTotal], [Impuesto], [TotalProducto]) VALUES (24, 22, 2, N'Oreo', 50, CAST(75.00 AS Decimal(18, 2)), CAST(3750.00 AS Decimal(18, 2)), CAST(487.50 AS Decimal(18, 2)), CAST(4237.50 AS Decimal(18, 2)))
INSERT [dbo].[DetallesFacturaCompra] ([DetalleID], [FacturaID], [ProductoID], [ProductoNombre], [Cantidad], [Precio], [SubTotal], [Impuesto], [TotalProducto]) VALUES (25, 22, 3, N'Cereal', 80, CAST(600.00 AS Decimal(18, 2)), CAST(48000.00 AS Decimal(18, 2)), CAST(6240.00 AS Decimal(18, 2)), CAST(54240.00 AS Decimal(18, 2)))
INSERT [dbo].[DetallesFacturaCompra] ([DetalleID], [FacturaID], [ProductoID], [ProductoNombre], [Cantidad], [Precio], [SubTotal], [Impuesto], [TotalProducto]) VALUES (26, 23, 66, N'Leche2', 5, CAST(100.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), CAST(565.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[DetallesFacturaCompra] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (21, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-13' AS Date), CAST(135.60 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (22, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-13' AS Date), CAST(135.60 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (23, 3, N'Nicole', N'123456789', N'Físico', CAST(N'2024-04-13' AS Date), CAST(1130.00 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (24, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-13' AS Date), CAST(1073.50 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (25, 123, N'Arron', N'123456789', N'Fisico', CAST(N'2024-04-13' AS Date), CAST(1497.25 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (26, 3, N'Nicole', N'123456789', N'Físico', CAST(N'2024-04-13' AS Date), CAST(706.25 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (27, 3, N'Nicole', N'123456789', N'Físico', CAST(N'2024-04-13' AS Date), CAST(1412500.00 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (28, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-13' AS Date), CAST(1412500.00 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (29, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-13' AS Date), CAST(1412500.00 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (30, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-13' AS Date), CAST(1214.75 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (31, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-13' AS Date), CAST(1412500.00 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (32, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-15' AS Date), CAST(1525.50 AS Decimal(18, 2)))
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha], [Total]) VALUES (33, 23, N'Sebastian Coto', N'305610818', N'Juridico', CAST(N'2024-04-15' AS Date), CAST(1243.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[FacturaCompra] ON 

INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha], [Total]) VALUES (22, 2, N'Dos Pinos', N'1234567890', N'Juridico', CAST(N'2024-04-15' AS Date), CAST(59042.50 AS Decimal(18, 2)))
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha], [Total]) VALUES (23, 2, N'Dos Pinos', N'1234567890', N'Juridico', CAST(N'2024-04-15' AS Date), CAST(565.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[FacturaCompra] OFF
GO
INSERT [dbo].[Pin] ([Pin]) VALUES (1212)
GO
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (1, N'Leche', 0, CAST(250 AS Decimal(18, 0)), CAST(65 AS Decimal(18, 0)), CAST(565 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (2, N'Oreo', 48, CAST(75 AS Decimal(18, 0)), CAST(488 AS Decimal(18, 0)), CAST(4238 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (3, N'Cereal', 77, CAST(600 AS Decimal(18, 0)), CAST(6240 AS Decimal(18, 0)), CAST(54240 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (28, N'Cereal', 3, CAST(200 AS Decimal(18, 0)), CAST(78 AS Decimal(18, 0)), CAST(678 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (66, N'Leche2', 5, CAST(100 AS Decimal(18, 0)), CAST(65 AS Decimal(18, 0)), CAST(565 AS Decimal(18, 0)))
GO
INSERT [dbo].[Proveedores] ([Codigo], [Proveedor], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'2', N'Dos Pinos', N'Juridico', N'1234567890', N'd', N'San José', CAST(12345678 AS Decimal(18, 0)), N'se@gmail.com', N'Ssfknio@1')
GO
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'1', N'1', N'305610818', N'Sebasdac', N'Activo')
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'2', N'2', N'123456789', N'2', N'Activo')
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'3', N'3', N'12345678', N'2', N'Activo')
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'77', N'77', N'12345678', N'77', N'Activo')
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'777', N'777', N'12345678', N'777', N'Inactivo')
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'99', N'999', N'999999999', N'99', N'Inactivo')
GO
ALTER TABLE [dbo].[DetallesFactura]  WITH CHECK ADD FOREIGN KEY([FacturaID])
REFERENCES [dbo].[Factura] ([FacturaID])
GO
ALTER TABLE [dbo].[DetallesFacturaCompra]  WITH CHECK ADD FOREIGN KEY([FacturaID])
REFERENCES [dbo].[FacturaCompra] ([FacturaID])
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 15/4/2024 20:38:00 ******/
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
USE [master]
GO
ALTER DATABASE [Proyecto II] SET  READ_WRITE 
GO
