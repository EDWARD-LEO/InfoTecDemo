CREATE DATABASE infotec
GO

-- Tienda de artículos informáticos
USE infotec
GO

-- **** CREACIÓN DE TABLAS ****

CREATE TABLE clientes
(
	idcliente		INT		IDENTITY(1,1) PRIMARY KEY,
	apellidos		VARCHAR(30)	NOT NULL,
	nombres			VARCHAR(30)	NOT NULL,
	dni				CHAR(8)		NOT NULL,
	CONSTRAINT uk_dni_cli UNIQUE (dni)
)
GO

INSERT INTO clientes (apellidos, nombres, dni) VALUES
	('MARTINEZ PRADA','Miguel','11223344'),
	('FAJARDO OCHOA','Esther','22224444'),
	('APOLAYA TASAYCO','Fiorella','77778888'),
	('QUISPE PRADA', 'Roxana', '77448877'),
	('QUIROGA FELIX', 'Tatiana', '99556655'),
	('PACHAS SARAVIA', 'Raul', '11441144'),
	('VELIZ MORENO', 'Sara', '55663322')
GO

CREATE TABLE productos 
(
	idproducto		INT IDENTITY (1,1) PRIMARY KEY,
	codbarra		VARCHAR(30)		NOT NULL,
	categoria		VARCHAR(30)		NOT NULL, -- Debería ser FK
	marca			VARCHAR(30)		NOT NULL, -- Debería ser FK
	descripcion		VARCHAR(70)		NOT NULL,
	stock			INT				NOT NULL,
	precio			DECIMAL(7,2)	NOT NULL,
	CONSTRAINT ck_stock_prd CHECK (stock >= 0),
	CONSTRAINT ck_precio_prd CHECK (precio > 0)
)
GO

INSERT INTO productos (codbarra, categoria, marca, descripcion, stock, precio) VALUES 
	('A001', 'Teclado', 'Genius', 'Teclado inalámbrico RGB', 10, 85),
	('A002', 'Teclado', 'Logitech', 'Teclado gamer mecánico', 5, 250),
	('A003', 'Monitor', 'Samsung', 'Monitor curvo 165Hz', 2, 900),
	('A004', 'Monitor', 'Atheros', 'Monitor Gamer con parlantes', 4, 500),
	('A005', 'Monitor', 'ASUS', 'Monitor Gamer Ultra WideScreen 190hz', 1, 1500),
	('A006', 'Impresora', 'EPSON', 'Ecotank L200', 4, 650),
	('A007', 'Impresora', 'Brother', 'OfficePro X', 7, 600)
GO

CREATE TABLE ventas
(
	idventa			INT IDENTITY(1,1) PRIMARY KEY,
	tipocomprobante	CHAR(1)		NOT NULL DEFAULT 'B',
	numcomprobante	INT			NOT NULL, 
	idcliente		INT			NULL, -- Hace falta un FK del usuario/empleado para este ejemplo se omitió
	fechaventa		DATETIME	NOT NULL DEFAULT GETDATE(),
	tipopago		VARCHAR(10) NOT NULL DEFAULT 'efectivo',
	CONSTRAINT ck_tipocomprobante_vnt CHECK (tipocomprobante IN ('B','F')),
	CONSTRAINT fk_idcliente_vnt FOREIGN KEY (idcliente) REFERENCES clientes (idcliente),
	CONSTRAINT ck_tipopago_vnt CHECK (tipopago IN ('efectivo','yape','plin','visa','depósito'))
)
GO

CREATE TABLE detventa
(
	iddetventa		INT IDENTITY (1,1) PRIMARY KEY,
	idventa			INT			NOT NULL,
	idproducto		INT			NOT NULL,
	cantidad		SMALLINT	NOT NULL,
	precioventa		DECIMAL(7,2)NOT NULL,
	CONSTRAINT fk_idventa_dvt FOREIGN KEY (idventa) REFERENCES ventas (idventa),
	CONSTRAINT fk_idproducto_dvt FOREIGN KEY (idproducto) REFERENCES productos (idproducto),
	CONSTRAINT ck_cantidad_dvt CHECK (cantidad > 0),
	CONSTRAINT ck_precioventa_dvt CHECK (precioventa > 0)
)
GO


-- **** CREACIÓN DE PROCEDIMIENTOS ALMACENADOS ****
CREATE PROCEDURE spu_clientes_listar_todos
AS BEGIN
	SELECT * 
		FROM clientes
		ORDER BY apellidos, nombres
END
GO

CREATE PROCEDURE spu_productos_listar_todos
AS BEGIN
	SELECT	idproducto,
			CONCAT(marca, ' ', descripcion) 'descripcion',
			stock,
			precio
		FROM productos
		WHERE stock > 0
		ORDER BY 2
END
GO

CREATE PROCEDURE spu_productos_buscar_codbarra
@codbarra	VARCHAR(30)
AS BEGIN
	SELECT	idproducto,
			CONCAT(marca, ' ', descripcion) 'descripcion',
			stock,
			precio
		FROM productos
		WHERE stock > 0 AND codbarra = @codbarra
END
GO

CREATE PROCEDURE spu_venta_registrar
	@idventa			INT OUTPUT, -- ¡Importante, variable de salida!
	@tipocomprobante	CHAR(1),
	@numcomprobante		INT,
	@idcliente			INT,
	@tipopago			VARCHAR(10)
AS BEGIN
	-- Si el idcliente es -1, significa que no se asignó
	IF @idcliente = -1 SET @idcliente = NULL

	INSERT INTO ventas (tipocomprobante, numcomprobante, idcliente, tipopago) 
		VALUES (@tipocomprobante, @numcomprobante, @idcliente, @tipopago)

	-- Obtenemos el último ID generado
	SET @idventa = @@IDENTITY
END
GO

-- ¿Cómo verificar un SPU con variable de salida en MSSQL Server?
-- PASO 1: Crear una variable donde se almacenará el ID obtenido
-- PASO 2: Ejecutar el SPU enviando el ID a la variable creada en el paso anterior
-- PASO 3: Mostramos el valor obtenido

-- DECLARE @idgenerado INT
-- EXEC spu_venta_registrar @idgenerado OUTPUT, 'B', -1, 'yape'
-- SELECT @idgenerado
-- GO

-- Si alguna vez quieren reiniciar el IDENTITY de alguna tabla
-- DELETE FROM [nombre_tabla]
-- DBCC CHECKIDENT ('[nombre_tabla]', RESEED, 0);
-- GO

-- Se agrega los productos y se debe descontar su stock
CREATE PROCEDURE spu_detventa_registrar
	@idventa		INT,
	@idproducto		INT,
	@cantidad		SMALLINT,
	@precioventa	DECIMAL(7,2)
AS BEGIN
	INSERT INTO detventa (idventa, idproducto, cantidad, precioventa) VALUES
		(@idventa, @idproducto, @cantidad, @precioventa)

	UPDATE productos SET stock = stock - @cantidad WHERE idproducto = @idproducto
END
GO