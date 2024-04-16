CREATE PROCEDURE InsertarCliente
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

select*from Productos

CREATE TABLE Factura (
    FacturaID INT PRIMARY KEY IDENTITY,
    ClienteID INT,
	NombreCliente VARCHAR(50),
	CedulaCliente VARCHAR(50),
	TipoCliente VARCHAR(50),
    Fecha DATE,
    Total DECIMAL(18, 2),
    -- Otros campos de información de la factura
);

CREATE TABLE DetallesFactura (
    DetalleID INT PRIMARY KEY IDENTITY,
    FacturaID INT,
    ProductoID INT,
    Cantidad INT,
    Precio DECIMAL(18, 2),
	SubTotal DECIMAL(18,2),
    TotalProducto DECIMAL(18, 2),
    -- Otros campos de información del detalle de la factura
    FOREIGN KEY (FacturaID) REFERENCES Factura(FacturaID)
);
select*from Factura
select*from DetallesFactura
