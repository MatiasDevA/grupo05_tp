
USE [FerreteriaIndustrial]
GO

-- 1. DetalleVenta no la apunta nadie, se puede truncar sin problemas
TRUNCATE TABLE [dbo].[DetalleVenta];
TRUNCATE TABLE [dbo].[DetalleCompra];

-- 2. Venta y OrdenCompra son apuntadas por FKs, así que usamos DELETE
DELETE FROM [dbo].[Venta];
DELETE FROM [dbo].[OrdenCompra];

-- 3. El resto de las tablas maestras también se limpian con DELETE
DELETE FROM [dbo].[Cliente];
DELETE FROM [dbo].[Producto];
DELETE FROM [dbo].[Proveedor];
DELETE FROM [dbo].[Usuario];
DELETE FROM [dbo].[Perfil];

-- 4. Como usamos DELETE, reiniciamos manualmente los contadores IDENTITY a 0
DBCC CHECKIDENT ('[dbo].[Venta]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[OrdenCompra]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Cliente]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Producto]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Proveedor]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Usuario]', RESEED, 0);
DBCC CHECKIDENT ('[dbo].[Perfil]', RESEED, 0);
GO