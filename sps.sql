CREATE PROCEDURE altaProducto
@tipoProd VARCHAR(30),
@descripcion varchar(80),
@precio NUMERIC(18,2),
@outFecha DATETIME,
@stock INT,
@inFecha DATETIME,
@stockMin INT
AS
insert into productos(tipoProducto,descripcion,precio, stock, stockMin ,inFecha, outFecha)
values (@tipoProd, @descripcion ,@precio, @stock, @stockMin,@inFecha, @outFecha)
GO


GO
drop PROCEDURE altaProducto
go

CREATE PROCEDURE nuevoStock
@descripcion varchar(80),
@inFecha DATETIME,
@outFecha DATETIME
AS
INSERT into stock( descripcionStock,
inFecha, outFecha) 
VALUES (@descripcion, @inFecha, @outFecha)
GO



CREATE PROCEDURE nuevoProducStock
@codProducto int,
@codStock INT,
@cantidad INT,
@valorStock NUMERIC(18,2),
@descripcion VARCHAR(80),
@observacion VARCHAR(100),
@fechaIn DATETIME,
@fechaOut DATETIME
AS
INSERT into tieneStock(codProducto, codStock,
cantidad, valorStock,descripcionStock, observacion, fechaIn, fechaOut)
VALUES (@codProducto, @codStock, @cantidad, @valorStock,
@descripcion, @observacion, @fechaIn,  @fechaOut)
go

