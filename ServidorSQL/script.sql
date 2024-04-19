USE [master]
GO
/****** Object:  Database [Proyecto II]    Script Date: 19/4/2024 17:06:29 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 19/4/2024 17:06:29 ******/
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
/****** Object:  Table [dbo].[DetallesFactura]    Script Date: 19/4/2024 17:06:29 ******/
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
/****** Object:  Table [dbo].[DetallesFacturaCompra]    Script Date: 19/4/2024 17:06:29 ******/
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
/****** Object:  Table [dbo].[Factura]    Script Date: 19/4/2024 17:06:29 ******/
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
	[Fecha] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[FacturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaCompra]    Script Date: 19/4/2024 17:06:29 ******/
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
	[Fecha] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[FacturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pin]    Script Date: 19/4/2024 17:06:29 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 19/4/2024 17:06:29 ******/
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
/****** Object:  Table [dbo].[Proveedores]    Script Date: 19/4/2024 17:06:29 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 19/4/2024 17:06:29 ******/
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
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'1', N'Sebastian Coto Arias', N'Físico', N'1234567893', N'San Jose', N'San José', N'12345678', N'secoto12@gmail.com', N'Hairwax1@')
GO
SET IDENTITY_INSERT [dbo].[DetallesFacturaCompra] ON 

INSERT [dbo].[DetallesFacturaCompra] ([DetalleID], [FacturaID], [ProductoID], [ProductoNombre], [Cantidad], [Precio], [SubTotal], [Impuesto], [TotalProducto]) VALUES (49, 53, 6, N'LecheWEB', 1, CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(113.00 AS Decimal(18, 2)))
INSERT [dbo].[DetallesFacturaCompra] ([DetalleID], [FacturaID], [ProductoID], [ProductoNombre], [Cantidad], [Precio], [SubTotal], [Impuesto], [TotalProducto]) VALUES (52, 55, 66, N'Leche2', 10, CAST(1.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(1.30 AS Decimal(18, 2)), CAST(11.30 AS Decimal(18, 2)))
INSERT [dbo].[DetallesFacturaCompra] ([DetalleID], [FacturaID], [ProductoID], [ProductoNombre], [Cantidad], [Precio], [SubTotal], [Impuesto], [TotalProducto]) VALUES (57, 60, 28, N'Cereal', 4, CAST(200.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)), CAST(104.00 AS Decimal(18, 2)), CAST(904.00 AS Decimal(18, 2)))
INSERT [dbo].[DetallesFacturaCompra] ([DetalleID], [FacturaID], [ProductoID], [ProductoNombre], [Cantidad], [Precio], [SubTotal], [Impuesto], [TotalProducto]) VALUES (58, 61, 56, N'Zanahoria', 2, CAST(300.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), CAST(78.00 AS Decimal(18, 2)), CAST(678.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[DetallesFacturaCompra] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha]) VALUES (1116, 1, N'Sebastian Coto Arias', N'Físico', N'1234567893', N'1/1/0001 00:00:00')
INSERT [dbo].[Factura] ([FacturaID], [ClienteID], [NombreCliente], [CedulaCliente], [TipoCliente], [Fecha]) VALUES (1117, 1, N'Sebastian Coto Arias', N'Físico', N'1234567893', N'1/1/0001 00:00:00')
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[FacturaCompra] ON 

INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (49, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (50, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (51, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (52, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (53, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (54, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (55, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (56, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (57, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (58, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (59, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (60, 1, N'Dos Pinos', N'123456789', N'Físico', N'1/1/0001 00:00:00')
INSERT [dbo].[FacturaCompra] ([FacturaID], [ProveedorID], [NombreProveedor], [CedulaProveedor], [Tipo], [Fecha]) VALUES (61, 1, N'Dos Pinos', N'123456789', N'Físico', N'2024-04-19 17:05:15')
SET IDENTITY_INSERT [dbo].[FacturaCompra] OFF
GO
INSERT [dbo].[Pin] ([Pin]) VALUES (1212)
GO
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (3, N'Cereal', 82, CAST(650 AS Decimal(18, 0)), CAST(6240 AS Decimal(18, 0)), CAST(54240 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (28, N'Cereal', 6, CAST(200 AS Decimal(18, 0)), CAST(78 AS Decimal(18, 0)), CAST(678 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (34, N'Shampoo', 32, CAST(100 AS Decimal(18, 0)), CAST(390 AS Decimal(18, 0)), CAST(3390 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (56, N'Zanahoria', 2, CAST(300 AS Decimal(18, 0)), CAST(78 AS Decimal(18, 0)), CAST(678 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (78, N'CerealosWEB', 5, CAST(650 AS Decimal(18, 0)), CAST(423 AS Decimal(18, 0)), CAST(3673 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (97, N'Jugo naranja', 41, CAST(500 AS Decimal(18, 0)), CAST(2925 AS Decimal(18, 0)), CAST(25425 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (98, N'Gillete', 0, CAST(75 AS Decimal(18, 0)), CAST(39 AS Decimal(18, 0)), CAST(339 AS Decimal(18, 0)))
INSERT [dbo].[Productos] ([Codigo], [Nombre], [Cantidad], [Precio], [Impuesto], [Total]) VALUES (100, N'Chele', 2, CAST(125 AS Decimal(18, 0)), CAST(163 AS Decimal(18, 0)), CAST(1413 AS Decimal(18, 0)))
GO
INSERT [dbo].[Proveedores] ([Codigo], [Proveedor], [Tipo], [Cedula], [Direccion], [Provincia], [Telefono], [Correo], [Contrasena]) VALUES (N'1', N'Dos Pinos', N'Físico', N'123456789', N'San Jose Centro', N'San José', CAST(12345678 AS Decimal(18, 0)), N'secoto12@gmail.com', N'Ssfknio@1')
GO
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'1', N'1', N'305610818', N'Sebasdac', N'Activo')
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'2', N'2', N'123456789', N'2', N'Activo')
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'3', N'4', N'12345678', N'2', N'Activo')
INSERT [dbo].[Usuarios] ([Usuario], [Contrasena], [Cedula], [Nombre], [Estado]) VALUES (N'99', N'999', N'999999999', N'99', N'Inactivo')
GO
ALTER TABLE [dbo].[DetallesFactura]  WITH CHECK ADD FOREIGN KEY([FacturaID])
REFERENCES [dbo].[Factura] ([FacturaID])
GO
ALTER TABLE [dbo].[DetallesFacturaCompra]  WITH CHECK ADD FOREIGN KEY([FacturaID])
REFERENCES [dbo].[FacturaCompra] ([FacturaID])
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 19/4/2024 17:06:29 ******/
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
