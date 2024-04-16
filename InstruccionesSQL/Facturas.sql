select*from Proveedores
select*from Productos
select*from DetallesFacturaCompra
select*from FacturaCompra

CREATE TABLE FacturaCompra (
    FacturaID INT PRIMARY KEY IDENTITY,
    ProveedorID INT,
	NombreProveedor varchar(50),
	CedulaProveedor varchar(50),
	Tipo varchar(50),
    Fecha DATE,
    Total DECIMAL(18, 2),
    
);



CREATE TABLE DetallesFacturaCompra (
    DetalleID INT PRIMARY KEY IDENTITY,
    FacturaID INT,
    ProductoID INT,
	ProductoNombre varchar(50),
    Cantidad INT,
    Precio DECIMAL(18, 2),
	SubTotal DECIMAL(18,2),
	Impuesto DECIMAL(18,2),
    TotalProducto DECIMAL(18, 2),
    -- Otros campos de información del detalle de la factura
    FOREIGN KEY (FacturaID) REFERENCES FacturaCompra(FacturaID)
);
