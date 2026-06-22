CREATE PROCEDURE SP_ListarClientes
AS
BEGIN
select 
id_cliente,
razon_social,
dni,
cuil,
telefono,
contacto 
from Cliente
END
GO

USE [FerreteriaIndustrial]
GO

DROP PROCEDURE IF EXISTS SP_ListarClientes;
GO


select *from Cliente
select *from Usuario
select *from Perfil

alter table Cliente
add constraint fk_clientes_vendedor
foreign key (id_usuario_vendedor)
references Usuario(id_usuario)





USE [FerreteriaIndustrial]
GO

CREATE PROCEDURE SP_AltaCliente
    @RazonSocial VARCHAR(150),
    @Dni VARCHAR(20),
    @Cuil VARCHAR(20),      -- Corregido: nombre alineado a tu tabla Cliente
    @Telefono VARCHAR(30),
    @Contacto VARCHAR(100),
    @IdUsuarioVendedor INT  -- Agregado: obligatorio para que no falle el NOT NULL
AS 
BEGIN

    INSERT INTO [dbo].[Cliente] (
        [razon_social], 
        [dni], 
        [cuil],             -- Corregido: nombre real de la columna en tu BD
        [telefono], 
        [contacto],
        [id_usuario_vendedor] -- Agregado
    )
    VALUES (
        @RazonSocial, 
        @Dni, 
        @Cuil,              -- Corregido: ahora coincide con el parámetro de arriba
        @Telefono, 
        @Contacto,
        @IdUsuarioVendedor  -- Agregado
    );
END
GO

DROP PROCEDURE IF EXISTS SP_AltaCliente;
GO



CREATE PROCEDURE SP_BuscarClientePorDNI
    @DNI VARCHAR(20)
AS
BEGIN
    SELECT *
    FROM Cliente
  WHERE DNI LIKE '%' + @DNI + '%'
END

DROP PROCEDURE IF EXISTS SP_BuscarClientePorDNI;

CREATE PROCEDURE SP_BuscarClientePorID
    @ID INT
AS
BEGIN
    SELECT *
    FROM Cliente
 WHERE id_cliente = @Id
END

DROP PROCEDURE IF EXISTS SP_BuscarClientePorID;
GO

 
CREATE PROCEDURE  SP_BuscarClientePorCuil
    @CUIL VARCHAR(20)
AS
BEGIN
    SELECT *
    FROM Cliente
  WHERE cuil LIKE '%' + @CUIL + '%'
END
DROP PROCEDURE IF EXISTS SP_BuscarClientePorCuil;

CREATE PROCEDURE  SP_BuscarClientePorRazonSocial
    @RazonSocial VARCHAR(20)
AS
BEGIN
    SELECT *
    FROM Cliente
  WHERE razon_social LIKE '%' + @RazonSocial + '%'
END
DROP PROCEDURE IF EXISTS SP_BuscarClientePorRazonSocial;


CREATE PROCEDURE SP_ModificarCliente
    @IdCliente INT,
    @RazonSocial VARCHAR(150),
    @Dni VARCHAR(20),
    @Cuil VARCHAR(20),
    @Telefono VARCHAR(30),
    @Contacto VARCHAR(100)
AS
BEGIN

    UPDATE dbo.Cliente
    SET
        razon_social = @RazonSocial,
        dni = @Dni,
        cuil = @Cuil,
        telefono = @Telefono,
        contacto = @Contacto
    WHERE id_cliente = @IdCliente;

END