CREATE PROCEDURE altaProductos
@codPromo INT,
@tipoProd VARCHAR(30),
@descripcion varchar(100),
@precio NUMERIC(18,2),
@outFecha DATETIME,
@stock INT,
@inFecha DATETIME,
@stockMin INT
AS

DECLARE @p_codPromo INT

select @p_codPromo = ISNULL(@codPromo, 0)

insert into productos(codPromo,tipoProducto,descripcion,precio, stock, stockMin ,inFecha, outFecha)
values (@codPromo,@tipoProd, @descripcion ,@precio, @stock, @stockMin,@inFecha, @outFecha)
GO



drop PROCEDURE altaProductos;

GO

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

/**PROCEDIMIENTO NUEVA PROMO**/
USE Kiosco
GO

CREATE PROCEDURE nuevaPromo(
@codProd INT, 
@descripcion VARCHAR(100),
@total NUMERIC(18,2),
@activa BIT
)
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
  VALUES(@codPromo ,@descripcion,
         @total, @activa)

GO



/***FIN PROCEDIMIENTO***/
DROP PROCEDURE nuevaPromo
/**PROCEDIMIENTO MODIFICAR PROMOCION**/

CREATE PROCEDURE modificarPromocion
@codPromo INT,
@descrPromo varchar(100),
@total NUMERIC(18,2),
@activa BIT,
@codProd INT,
@cantidad INT,
@totalProd NUMERIC (18,2),
@descrProd VARCHAR(100)
AS
DECLARE @p_promo INT
DECLARE @codError INT
DECLARE @descrError VARCHAR(60)



SELECT @p_promo = isnull(codPromo, 0)
FROM codPromo 
WHERE codPromo = @codPromo

IF @p_promo <> 0
        BEGIN
        UPDATE promocion
                SET
                descrprom = @descrPromo,
                total = @total,
                activa = @activa
                    WHERE codPromo = @p_promo
        END
ELSE
        BEGIN 
                SET @codError = 33
                SET @descrError = 'ERROR' + CONVERT(VARCHAR,@codError) + ' ' +  'No se ingreso el codigo de promocion'
        END

GO
/**FIN PROCEDIMIENTO**/

/**PROCEDIMIENTO NUEVO DETALLE**/
CREATE PROCEDURE sp_nuevoDetallePromo
@codPromo INT,
@codProd INT,
@descrProd VARCHAR(100),
@totalProd NUMERIC(18,2),
@cantidad INT
AS



INSERT INTO detalle_promocion
VALUES (@codPromo, @codProd, @descrProd, @totalProd, @cantidad)
GO
GRANT EXECUTE ON sp_nuevoDetallePromo TO Kiosco
GO
/***FIN PROCEDIMIENTO***/



/**TRIGGER PARA NUEVA PROMOCION**/

CREATE TRIGGER tri_nuevaPromo on promocion
AFTER INSERT
AS

BEGIN
/*DECLARACION DE VARIABLES*/
DECLARE @tipoProducto VARCHAR(30)


SET NOCOUNT ON;
INSERT INTO productos(codPromo, tipoProducto, descripcion, ,precio)
GO
/*******FALTA TERMINAR********/

/**FIN TRIGGER**/


/**PROCEDIMIENTO NUEVO USER**/

CREATE PROCEDURE sp_nuevoUsuario
@tipoUsuario varchar(40),
@usuario varchar(40),
@contrasena varchar(40),
@nombre varchar(60)
AS
DECLARE @cod_error INT
DECLARE @desc_error VARCHAR(60)
DECLARE @p_usuario VARCHAR(40)
DECLARE @existe BIT

SET @cod_error = 0
IF @cod_error = 0
BEGIN
        IF EXISTS(
                SELECT 1  
                 FROM usuarios
                    WHERE usuario = @usuario
        )
        BEGIN
        SET @existe = 1
        END
        ELSE
        BEGIN
        
        SET @existe = 0

        END
END

IF @existe = 0
BEGIN
INSERT INTO usuarios VALUES(@tipoUsuario ,@usuario, @contrasena, @nombre)
END

ELSE
BEGIN
SET @cod_error = 60
SET @desc_error = 'El usuario: ' + @usuario + ' ya existe'
END

GRANT EXECUTE ON sp_nuevoUsuario to Kiosco
GO

/***FIN PROCEDIMIENTO***/


/***PROCEDIMIENTO ELIMINAR USER***/
CREATE PROCEDURE sp_eliminarUsuario
@usuario VARCHAR(40)
AS

DELETE FROM usuarios 
        WHERE usuario = @usuario

GRANT EXECUTE ON sp_eliminarUsuario TO Kiosco

GO




/***FIN PROCEDIMIENTO***/

/**PROCEDIMIENTO BUSCAR USUARIO**/
CREATE PROCEDURE sp_logear
@usuario varchar(40),
@password varchar


/**FIN PROCEDIMIENTO**/
