

 create table Producto
  ( Codigo int not null primary key, 
    Nombre varchar(150) not null, 
	Precio int not null, 
	Cantidad int not null, 
	Impuesto float not null, 
	Total float not null, 
	Usuario varchar(20) )