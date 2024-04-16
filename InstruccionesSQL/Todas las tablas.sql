CREATE TABLE [Productos] (
  [Codigo] int PRIMARY KEY,
  [Nombre] string,
  [Cantidad] int,
  [Precio] double
)
GO

CREATE TABLE [Clientes] (
  [Codigo] int PRIMARY KEY,
  [Nombre] nvarchar(255),
  [Tipo] nvarchar(255),
  [Cedula] nvarchar(255),
  [Direccion] nvarchar(255),
  [Provincia] nvarchar(255),
  [Telefono] double,
  [Correo] string
)
GO

CREATE TABLE [Proveedores] (
  [Codigo] int PRIMARY KEY
)
GO

CREATE TABLE [Usuarios] (
  [Usuario] string PRIMARY KEY,
  [Contrasena] string,
  [Cedula] string,
  [Nombre] string
)
GO

CREATE TABLE [Ordenes] (
  [Codigo] int PRIMARY KEY,
  [CodigoCliente] int,
  [CodigoProducto] int
)
GO

ALTER TABLE [Ordenes] ADD FOREIGN KEY ([Codigo]) REFERENCES [Clientes] ([Codigo])
GO

ALTER TABLE [Ordenes] ADD FOREIGN KEY ([Codigo]) REFERENCES [Productos] ([Codigo])
GO

ALTER TABLE [Proveedores] ADD FOREIGN KEY ([Codigo]) REFERENCES [Ordenes] ([Codigo])
GO
