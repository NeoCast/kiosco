CREATE table productos(
codProducto int identity(1,1),
codPromo int,
tipoProducto VARCHAR(30),
descripcion varchar(100),
stock int,
stockMin int,
precio NUMERIC(18,2),
inFecha datetime,
outFecha datetime,
CONSTRAINT pk_producto PRIMARY KEY(codProducto)
);

drop TABLE productos;


CREATE table promocion(
codPromo INT,
descrprom VARCHAR(100),
total NUMERIC(18,2),
activa BIT,
CONSTRAINT pk_promocion PRIMARY KEY (codPromo)
);



CREATE TABLE detalle_promocion(
codDetallePromo INT IDENTITY(1,1),
codPromo INT,
codProd INT,
descrProd VARCHAR(100),
totalProducto INT,
cantidad INT,
CONSTRAINT pk_detallePromo PRIMARY KEY (codDetallePromo,codPromo, codProd)
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
VALUES('CIG','cigarrillos');

INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('DUL','dulces');

INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('SNK','snacks');

INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('BBD','bebidas');

INSERT INTO tipoProducto(codTipop, descripTipo)
VALUES('VAR','cosas varias');

TRUNCATE table tipoProducto;

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

CREATE TABLE usuarios(
idUsuario INT IDENTITY (1,1),
tipoUsuario VARCHAR(40),
usuario varchar(40),
contrasena varchar(40),
nombre varchar(60)
);

DROP TABLE usuarios

