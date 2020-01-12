CREATE table productos(
codProducto int identity(1,1),
tipoProducto VARCHAR(30),
descripcion varchar(100),
stock int,
stockMin int,
precio NUMERIC(18,2),
inFecha datetime,
outFecha datetime,
CONSTRAINT pk_producto PRIMARY KEY(codProducto)
);
drop TABLE producto;

CREATE table promocion(
codPromo INT IDENTITY(1,1),
codProd INT,
descrprod VARCHAR(100),
cantidad INT,
valorUnit NUMERIC(18,2),
total NUMERIC(18,2),
);

CREATE table stock(
idStock int identity(1,1),
codProducto int,
descripcionStock varchar(100),
inFecha datetime,
outFecha datetime,
CONSTRAINT pk_stock PRIMARY KEY(idStock)
);
DROP TABLE stock;

CREATE table tieneStock(
codProducto int,
codStock int identity(1,1),
valorStock NUMERIC(18,2),
cantidad int,
descripcionStock varchar(80),
observacion varchar(100),
fechaIn DATETIME,
fechaOut DATETIME,
CONSTRAINT pk_tieneStock PRIMARY KEY(codProducto, codStock)
);
drop TABLE tieneStock;

CREATE table tipoProducto(
codTipop varchar(30),
descripTipo varchar(80),
CONSTRAINT pk_tipoP PRIMARY KEY(codTipop)
);

INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('cig','cigarrillos');

INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('car','caramelos');

INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('sna','snacks');

INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('beb','bebidas');


INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('var','cosas varias');

DELETE from tipoProducto where codTipop= 'cca'

CREATE table ventas(
idVenta int identity(1,1),
total NUMERIC(18,2),
ventaFecha datetime,
CONSTRAINT pk_ventas PRIMARY KEY(idVenta)
);

CREATE table detalleVentas(
codDetalleVta int,
idVenta int,
codProducto int,
cantidad int,
totalProducto NUMERIC(18,2),
descripcionProd varchar(80),
ventaFecha datetime, 
CONSTRAINT pk_detalleVta PRIMARY KEY(codDetalleVta, idVenta, codProducto)
);



