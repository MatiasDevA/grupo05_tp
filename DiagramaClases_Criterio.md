TP 1 – Grupo 5. Ferretería industrial y venta de herramientas.

Diagrama de clases
Identificar componentes del sistema
Ferretería Industrial y Venta de Herramientas:
•	Orientado a la gestión administrativa de herramientas pesadas y materiales de construcción, donde el rol del Gerente es clave para ver reportes de ventas semanales y mensuales
Requerimientos mínimos de TP : 
•	Deberá contar con 4 tipos de usuarios distintos como mínimo:
o	Administrador de sistemas:
	Es quién se encarga de dar de alta nuevos usuarios con su respectivo perfil (administrativo, gerente, vendedor, etc.).
o	Control de stock/Encargado de inventario y logística:
	Ingresa en el sistema la llegada de la mercadería en el depósito (aumenta el inventario).
	Controla el stock de los productos del inventario (listado).
	Reporte de alertas por productos con cantidad de stock menor que el mínimo por el producto.
o	Vendedor:
	Vende productos.
	Gestiona clientes (alta y modificaciones)
o	Gerente: 
	Ve reportes de ventas por semana, por mes y por vendedor.
 
Criterio para determinar las clases que forman parte del negocio
Se toman los roles como diferenciador de entidades de usuario.
Posibles clases: Sustantivos, posibles relaciones o comportamientos: Verbos. 
1.	USUARIO :
a.	ADMINISTRADOR
i.	Atributos:
1.	idUsuario
2.	nombreUsuario
3.	nombre
4.	apellido
5.	clave
ii.	Métodos:
1.	getUsuario
2.	setUsuario
3.	ModificarPropiedades
b.	RESPONSABLE_INVENTARIO/LOGISTICA
i.	Métodos:
1.	Registra ingreso de PRODUCTOS
2.	Registra egreso de PRODUCTOS
3.	Controla Stock de PRODUCTOS
c.	VENDEDOR
i.	Métodos:
1.	Venta de PRODUCTOS
2.	Alta CLIENTE
3.	Modificación CLIENTE
d.	GERENTE
i.	Métodos:
1.	Consulta REPORTE de VENTA:
a.	Resumen por VENDEDOR
b.	Resumen por semana
c.	Resumen por mes
2.	PRODUCTOS 
a.	Atributos:
i.	idProducto
ii.	stock
iii.	stockMinimo
iv.	nombre
v.	descripción
vi.	precioUnitario
b.	Métodos:
i.	getProducto
ii.	setProducto
iii.	ModificaProducto
3.	CLIENTE
a.	Atributos
i.	idCliente
ii.	nombre
iii.	teléfono
iv.	dirección
v.	cuit
vi.	email
b.	Métodos
i.	getCliente
ii.	setCliente
iii.	ModificaCliente
4.	REPORTE
a.	Atributos:
i.	idReporte
ii.	fechaCreacion
iii.	tipoReporte
iv.	totalVentas
b.	Métodos:
i.	getReporte
ii.	setReporte
iii.	ModificaReporte
5.	VENTA
a.	Atributos:
i.	idVenta
ii.	fecha
iii.	totalVenta
b.	Métodos:
i.	getVenta
ii.	setVenta
iii.	CancelaVenta
6.	DETALLE_VENTA
a.	Atributos:
i.	idItemVenta
ii.	cantidad
iii.	valorUnitario
iv.	subTotal
b.	Métodos:
i.	getDetalleVenta
ii.	setDetalleVenta
iii.	ModificaDetalleVenta
Relaciones entre clases
1.	Vendedor – Venta:
a.	Multiplicidad:
i.	Mínima: Puede existir un vendedor, sin que exista una venta. No puede existir una venta sin que exista un vendedor.
ii.	Máxima: Un vendedor puede realizar multiples ventas, una venta es realizada por un unico vendedor
2.	Venta – DetalleVenta:
a.	Multiplicidad:
i.	Detalle de ventas representa los items que componen una venta.
ii.	En ese sentido toda venta tiene al menos un detalle de venta, pero puede tener más de 1.
3.	DetalleVenta – Producto:
a.	Multiplicidad:
i.	Cada detalle referencia un único producto.
ii.	Un producto puede aparecer en muchos detalles de venta
iii.	Pueden existir productos sin que necesariamente haya un detalle
iv.	Todo detalle tiene un producto
4.	Venta – Cliente:
a.	Multiplicidad:
i.	Un cliente tiene como mínimo un vendedor asignado y puede tener varios vendedores.
ii.	Un vendedor puede no tener clientes asignados o puede tener muchos
5.	EncargadoInventario – Producto:
a.	Multiplicidad:
i.	Un encargado puede gestionar muchos productos o ninguno (aunque sea temporalmente)
ii.	Un producto puede ser gestionado por muchos encargados
iii.	Todo producto tiene como mínimo un encargado responsable
6.	Administrador – Usuario:
a.	Multiplicidad:
7.	Gerente – Reporte:
8.	Venta – Reporte:
a.	Multiplicidad:
i.	No hay reporte sin venta. En la relación se requiere una venta mínima.
ii.	Un reporte puede contener más de una venta.
iii.	Una venta puede ser parte de uno, ninguno o más de un reporte
9.	Vendedor – Cliente:
a.	Multiplicidad:
i.	Un cliente tiene como mínimo un vendedor asignado y puede tener varios vendedores.
ii.	Un vendedor puede no tener clientes asignados o puede tener muchos
Diagrama


PROCESO DE MODELADO
 
Glosario
Usuario: Persona que interactúa con el sistema a la cual se le atribuyen roles (tipos de usuarios) y características. No se tienen en cuenta para el alcance del tp sistemas externos que interactúen con el mismo. Se diagrama como una clase abstracta, ya que no se puede instanciar directamente, sino que sirve como base para las clases definidas por roles (no hay usuario sin rol asignado).
Vendedor: Rol al que se le asignan comportamientos o tareas de ventas y gestión de clientes. Vende productos y Gestiona Clientes: Alta y modificación (no se incluye baja de clientes ya que eso puede afectar a los reportes de ventas y relaciones entre clases corrompiendo el sistema).
