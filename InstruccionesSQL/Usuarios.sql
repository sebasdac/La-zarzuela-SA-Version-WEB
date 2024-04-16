CREATE TABLE [Productos] (
  [Codigo] int PRIMARY KEY,
  [Nombre] string,
  [Cantidad] int,
  [Precio] double
)
GO

select*from Proveedores
select*from Usuarios
select*from Clientes

CREATE TABLE [Proveedores] (
  [Codigo] varchar(300) PRIMARY KEY,
  [Proveedor] varchar(30),
  [Tipo] varchar(10),
  [Cedula] varchar(15),
  [Direccion] varchar(255),
  [Provincia] varchar(20),
  [Telefono] decimal,
  [Correo] varchar(100),
  [Contrasena] varchar(100)
)
GO

select*from Usuarios

UPDATE Usuarios SET Estado = 'Activo' WHERE Usuario = '1';


CREATE TABLE [Proveedores] (
  [Codigo] int PRIMARY KEY
  [Proveedor] varchar(20),
  [Cedula] varchar(15),



)
GO

CREATE TABLE [Usuarios] (
  [Usuario] string PRIMARY KEY,
  [Contrasena] string,
  [Cedula] string,
  [Nombre] string,
  [Estado] string
)
GO

CREATE TABLE [Ordenes] (
  [Codigo] int PRIMARY KEY,
  [CodigoCliente] int,
  [CodigoProducto] int
)
GO


CREATE TABLE [Clientes](
   [Codigo] varchar(900) PRIMARY KEY,
  [Nombre] varchar(60),
  [Tipo] varchar(60),
  [Cedula] varchar(60),
  [Direccion] varchar(60),
  [Provincia] varchar(60),
  [Telefono] varchar(60),
  [Correo] varchar(60),
  [Contrasena] varchar(60)
)


ALTER TABLE [Ordenes] ADD FOREIGN KEY ([Codigo]) REFERENCES [Clientes] ([Codigo])
GO

ALTER TABLE [Ordenes] ADD FOREIGN KEY ([Codigo]) REFERENCES [Productos] ([Codigo])
GO

ALTER TABLE [Proveedores] ADD FOREIGN KEY ([Codigo]) REFERENCES [Ordenes] ([Codigo])
GO
