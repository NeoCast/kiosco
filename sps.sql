CREATE PROCEDURE altaProductos
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

drop PROCEDURE altaProductos;

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

CREATE PROCEDURE ultimoguardado
AS 
select top 1 descripcion from productos
order by 1 desc
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


CREATE PROCEDURE buscarProducto
@descripcion varchar(100)
AS
Select descripcion FROM productos
where descripcion LIKE '%@descripcion%'
GO


CREATE PROCEDURE todosProductos
AS
select tipoProducto, descripcion, stock,
 stockMin, precio, outFecha from productos
GO


CREATE PROCEDURE eliminarProducto
@codProducto INT
AS
Delete productos where
codProducto = @codProducto
GO



CREATE PROCEDURE modificarProducto
@codProducto INT,
@tipoProducto VARCHAR(30),
@descripcion varchar(100),
@stock INT,
@stockMin INT,
@precio NUMERIC(18,2),
@inFecha DATETIME,
@outFecha DATETIME
AS
UPDATE productos 
SET tipoProducto= @tipoProducto,
descripcion = @descripcion,
stock = @stock,
stockMin = @stockMin,
precio = @precio,
inFecha = @inFecha,
outFecha = @outFecha
     WHERE
        codProducto = @codProducto
GO



CREATE PROCEDURE nuevaPromo
@codProd INT, 
@tipoProd VARCHAR(30),
@descripcion VARCHAR(100),
@cantidad INT,
@valorUnit NUMERIC(18,2),
@total NUMERIC(18,2),
@activa BIT
AS

DECLARE @codPromo INT

SELECT TOP 1 @codPromo = isnull(codPromo, 0) FROM
promocion ORDER BY codPromo DESC

        IF (@codPromo = 0)
        BEGIN
              SET  @codPromo = 1
        END
        ELSE
        BEGIN
                SET @codPromo = @codPromo + 1

        END

  INSERT INTO promocion 
  VALUES(@codPromo, @codProd ,@descripcion,
        @cantidad, @valorUnit, @total)


EXEC altaProductos(@tipoProd, 
                   @descripcion,
                   @precio,
                   @outFecha,
                   @stock,
                   @inFecha,
                   @stockMin
                   )
----*----
---@tipoProd VARCHAR(30),
---@descripcion varchar(80),
---@precio NUMERIC(18,2),
---@outFecha DATETIME,
---@stock INT,
---@inFecha DATETIME,
---@stockMin INT

GO
