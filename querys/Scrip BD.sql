USE [FerreteriaIndustrial]
GO

-- 1. Insertar Perfiles Solicitados
INSERT INTO [dbo].[Perfil] ([nombre], [descripcion]) VALUES
('Sistemas', 'Soporte técnico y administración de la plataforma'),
('Gerente', 'Planificación, reportes y decisiones comerciales'),
('Vendedor', 'Atención directa al público y facturación'),
('Encargado de deposito', 'Control de stock, recepción y despacho de mercadería');
GO

-- 2. Insertar Usuarios (Mapeados a los 4 perfiles anteriores)
INSERT INTO [dbo].[Usuario] ([nombre], [apellido], [email], [usuario], [clave], [nro_telefono], [estado], [id_perfil]) VALUES
('Carlos', 'Gómez', 'carlos.sistemas@ferreteria.com', 'cgomez', 'sysAdmin2026', '11-4444-5555', 'activo', 1), -- Sistemas
('Marta', 'Benítez', 'marta.gerencia@ferreteria.com', 'mbenitez', 'gerente789', '11-5555-6666', 'activo', 2), -- Gerente
('Ana', 'Martínez', 'ana.venta1@ferreteria.com', 'amartinez', 'vende123', '11-6666-7777', 'activo', 3),     -- Vendedor
('Lucas', 'Díaz', 'lucas.venta2@ferreteria.com', 'ldiaz', 'vende456', '11-7777-8888', 'activo', 3),        -- Vendedor
('Jorge', 'Rodríguez', 'jorge.deposito@ferreteria.com', 'jrodriguez', 'stock987', '11-8888-9999', 'activo', 4), -- Encargado de depósito
('Nicolás', 'López', 'nicolas.deposito@ferreteria.com', 'nlopez', 'depo123', '11-1111-2222', 'activo', 4);  -- Encargado de depósito
GO

-- 3. Insertar Proveedores (Sin valores NULL)
INSERT INTO [dbo].[Proveedor] ([razon_social], [cuit], [contacto]) VALUES
('Distribuidora Bulonera Atlántica S.A.', '30-11223344-5', 'Pedro Altieri (Ventas)'),
('Herramientas Profesionales Stanley SRL', '30-55667788-9', 'María Luz (Corporativo)'),
('Pinturas y Químicos Titanio', '30-99887766-4', 'Soporte Comercial'),
('Maquinarias Industriales S.A.', '30-44551122-3', 'Ricardo Fontana'),
('Cables y Conductores del Sur', '30-88772211-6', 'Clara Vega'),
('Seguridad Industrial Pro', '30-66554433-1', 'Fabián Ruiz');
GO

USE [FerreteriaIndustrial]
GO

-- 4. Insertar Clientes (Todos con DNI y CUIT inventados para evitar NULL)
INSERT INTO [dbo].[Cliente] ([razon_social], [dni], [cuit], [telefono], [contacto], [id_usuario_vendedor]) VALUES
('Constructora del Norte S.A.', 'No Aplica', '30-44556677-2', '11-2222-3333', 'Ing. Jorge Alaniz', 3),
('Juan Pedro Pérez', '32.456.789', '20-32456789-4', '11-9999-8888', 'Juan Pérez', 3),
('Taller Mecánico El Chispazo', 'No Aplica', '20-15987463-1', '11-3333-4444', 'Roberto Bruni', 3),
('Metalúrgica FerroMax', 'No Aplica', '30-77889911-5', '11-5555-4444', 'Ing. Claudio Sosa', 4),
('Laura Estela Gómez', '28.112.334', '27-28112334-9', '11-6666-1111', 'Laura Gómez', 4),
('Mantenimiento Urbano SRL', 'No Aplica', '30-22334455-8', '11-7777-0000', 'Arq. Sofía Rossi', 4);
GO

-- 5. Insertar Productos (7 artículos con todas sus columnas llenas)
INSERT INTO [dbo].[Producto] ([codigo], [descripcion], [categoria], [precio_compra], [precio_venta], [stock_actual], [stock_minimo]) VALUES
('BUL-M10-050', 'Bulón cabeza hexagonal M10 x 50mm (x100u)', 'Bulonería', 1250.00, 2100.00, 50, 10),
('TAL-DEW-20V', 'Taladro Percutor Inalámbrico Dewalt 20V Max', 'Herramientas Eléctricas', 45000.00, 72000.00, 12, 3),
('DIS-COR-045', 'Disco de corte para metal 4.5 Tyrolit', 'Discos y Abrasivos', 320.00, 580.00, 200, 50),
('PIN-LAT-020', 'Pintura Látex Interior Blanco 20 Lts', 'Pinturería', 18000.00, 29500.00, 8, 2),
('AMP-AMU-007', 'Amoladora Angular Bosch 700W 115mm', 'Herramientas Eléctricas', 22000.00, 36500.00, 15, 4),
('CAB-TPR-025', 'Cable Tipo Taller 3x2.5mm x 50 Metros', 'Electricidad', 28000.00, 44000.00, 10, 3),
('GAF-SEG-PRO', 'Gafas de Seguridad Policarbonato Transparente', 'Protección Personal', 750.00, 1300.00, 85, 15);
GO

USE [FerreteriaIndustrial]
GO

-- 6. Insertar 5 Órdenes de Compra
INSERT INTO [dbo].[OrdenCompra] ([fecha], [estado], [id_usuario], [id_proveedor]) VALUES
('2026-05-10', 'recibida', 5, 1),
('2026-05-15', 'recibida', 5, 2),
('2026-06-01', 'recibida', 6, 3),
('2026-06-10', 'pendiente', 6, 4),
('2026-06-16', 'cancelada', 5, 5);
GO

-- 7. Insertar Detalles de Compra (Vinculados a las 5 órdenes creadas arriba)
INSERT INTO [dbo].[DetalleCompra] ([id_orden], [id_producto], [cantidad], [precio_unitario]) VALUES
(1, 1, 10, 1250.00), -- Detalle OC 1
(1, 3, 100, 320.00),
(2, 2, 5, 45000.00),  -- Detalle OC 2
(2, 5, 5, 22000.00),
(3, 4, 10, 18000.00), -- Detalle OC 3
(4, 5, 4, 22000.00),  -- Detalle OC 4
(5, 6, 2, 28000.00);  -- Detalle OC 5
GO

USE [FerreteriaIndustrial]
GO

-- 8. Insertar 5 Ventas (Totales calculados según sus detalles correspondientes)
INSERT INTO [dbo].[Venta] ([fecha], [total], [id_cliente], [id_usuario_vendedor]) VALUES
('2026-06-01', 149800.00, 1, 3), -- Venta 1
('2026-06-02', 3400.00, 2, 3),   -- Venta 2
('2026-06-05', 73000.00, 3, 3),  -- Venta 3
('2026-06-12', 113000.00, 4, 4), -- Venta 4
('2026-06-17', 2600.00, 5, 4);   -- Venta 5
GO

-- 9. Insertar Detalles de Venta (Vinculados a las 5 ventas anteriores)
INSERT INTO [dbo].[DetalleVenta] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES
(1, 2, 2, 72000.00), -- Detalle Venta 1 (2 taladros + 10 discos)
(1, 3, 10, 580.00),
(2, 1, 1, 2100.00),  -- Detalle Venta 2 (1 bulón + 1 gafa)
(2, 7, 1, 1300.00),
(3, 5, 2, 36500.00), -- Detalle Venta 3 (2 amoladoras)
(4, 2, 1, 72000.00), -- Detalle Venta 4 (1 taladro + 1 cable)
(4, 6, 1, 44000.00),
(5, 7, 2, 1300.00);  -- Detalle Venta 5 (2 gafas)
GO