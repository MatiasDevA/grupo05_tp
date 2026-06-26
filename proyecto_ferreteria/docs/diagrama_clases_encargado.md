# Diagrama de Clases - Módulo Encargado de Depósito

## Capa de Presentación (UI)

```
┌─────────────────────────────────────────────────┐
│              FormEncargadoDeposito               │
├─────────────────────────────────────────────────┤
│ - _ordenService: OrdenCompraService             │
│ - _productoService: ProductoService             │
│ - _proveedorService: ProveedorService           │
│ - _idUsuarioActual: int                         │
├─────────────────────────────────────────────────┤
│ + CargarCategorias()                            │
│ + CargarProveedores()                           │
│ + CargarProductos()                             │
│ + CargarEstadosOrden()                          │
│ + CargarListadoProductos()                      │
│ + btnBuscar_Click()                             │
│ + btnRegistrarEgreso_Click()                    │
│ + btnRegistrarOrden_Click()                     │
│ + btnAgregarDetalle_Click()                     │
│ + btnConfirmarOrden_Click()                     │
│ + btnCancelarOrden_Click()                      │
│ + btnVerItemsOrden_Click()                      │
│ + btnAlertas_Click()                            │
│ + btnHistorial_Click()                          │
│ + btnActivarPanel_Click()                       │
│ + btnVolver_Click()                             │
│ + btnVolverAtras_Click()                        │
└───────────────────┬─────────────────────────────┘
                    │ usa
        ┌───────────┼───────────┐
        ▼           ▼           ▼
┌──────────────┐ ┌──────────────┐ ┌──────────────┐
│  OrdenCompra │ │  Producto    │ │  Proveedor   │
│  Service     │ │  Service     │ │  Service     │
└──────┬───────┘ └──────┬───────┘ └──────┬───────┘
       │                │                │
       ▼                ▼                ▼
┌──────────────┐ ┌──────────────┐ ┌──────────────┐
│ OrdenCompra  │ │  Producto    │ │  Proveedor   │
│ DAL          │ │  DAL         │ │  DAL         │
└──────┬───────┘ └──────┬───────┘ └──────┬───────┘
       │                │                │
       └────────────────┼────────────────┘
                        ▼
               ┌──────────────┐
               │   Conexion   │
               └──────────────┘
```

## Capa de Negocio (BLL)

### OrdenCompraService
```
┌─────────────────────────────────────────────────┐
│              OrdenCompraService                  │
├─────────────────────────────────────────────────┤
│ - _dal: OrdenCompraDAL                          │
├─────────────────────────────────────────────────┤
│ + RegistrarOrdenCompra(idUsuario, idProveedor,  │
│     fecha): OrdenCompraBE                       │
│ + AgregarDetalleOrden(idOrden, idProducto,      │
│     cantidad, precio): List<ItemOrdenBE>        │
│ + ConfirmarOrden(idOrden): int                  │
│ + CancelarOrden(idOrden): int                   │
│ + ObtenerHistorialOrdenes(...):                 │
│     List<HistorialOrdenBE>                      │
│ + ObtenerDetalleOrden(idOrden): OrdenCompraBE   │
│ + ObtenerItemsOrden(idOrden):                   │
│     List<ItemOrdenBE>                           │
│ + ObtenerEstadosOrden():                        │
│     List<EstadoOrdenBE>                         │
└─────────────────────────────────────────────────┘
```

### ProductoService
```
┌─────────────────────────────────────────────────┐
│              ProductoService                     │
├─────────────────────────────────────────────────┤
│ - _dal: ProductoDAL                             │
├─────────────────────────────────────────────────┤
│ + ObtenerListadoProductos(categoria,            │
│     soloAlertas): List<ListadoProductoBE>       │
│ + GenerarAlertaStock():                         │
│     List<AlertaStockBE>                         │
│ + RegistrarEgresoStock(idProducto,              │
│     cantidad): int                              │
│ + ObtenerCategorias(): List<CategoriaBE>        │
│ + ObtenerProductos(): List<ProductoBE>          │
└─────────────────────────────────────────────────┘
```

### ProveedorService
```
┌─────────────────────────────────────────────────┐
│              ProveedorService                    │
├─────────────────────────────────────────────────┤
│ - _dal: ProveedorDAL                            │
├─────────────────────────────────────────────────┤
│ + ObtenerProveedores():                         │
│     List<ProveedorBE>                           │
└─────────────────────────────────────────────────┘
```

## Capa de Acceso a Datos (DAL)

### OrdenCompraDAL
```
┌─────────────────────────────────────────────────┐
│              OrdenCompraDAL                      │
├─────────────────────────────────────────────────┤
│ - _conexion: Conexion                           │
├─────────────────────────────────────────────────┤
│ + RegistrarOrdenCompra(idUsuario, idProveedor,  │
│     fecha): DataTable                           │
│   → SP_Encargado_RegistrarOrdenCompra           │
│ + AgregarDetalleOrden(idOrden, idProducto,      │
│     cantidad, precio): DataTable                │
│   → SP_Encargado_AgregarDetalleOrden            │
│ + ConfirmarOrden(idOrden): int                  │
│   → SP_Encargado_ConfirmarOrden                 │
│ + CancelarOrden(idOrden): int                   │
│   → SP_Encargado_CancelarOrden                  │
│ + ObtenerHistorialOrdenes(...): DataTable       │
│   → SP_Encargado_ObtenerHistorialOrdenes        │
│ + ObtenerDetalleOrden(idOrden): DataTable       │
│   → SP_Encargado_ObtenerDetalleOrden            │
│ + ObtenerItemsOrden(idOrden): DataTable         │
│   → SP_Encargado_ObtenerItemsOrden              │
│ + ObtenerEstadosOrden(): DataTable              │
│   → SP_Encargado_ObtenerEstadosOrden            │
└─────────────────────────────────────────────────┘
```

### ProductoDAL
```
┌─────────────────────────────────────────────────┐
│              ProductoDAL                         │
├─────────────────────────────────────────────────┤
│ - _conexion: Conexion                           │
├─────────────────────────────────────────────────┤
│ + ObtenerListadoProductos(categoria,            │
│     soloAlertas): DataTable                     │
│   → SP_Encargado_ObtenerListadoProductos        │
│ + GenerarAlertaStock(): DataTable               │
│   → SP_Encargado_GenerarAlertaStock             │
│ + RegistrarEgresoStock(idProducto,              │
│     cantidad): int                              │
│   → SP_Encargado_RegistrarEgresoStock           │
│ + ObtenerCategorias(): DataTable                │
│   → SP_Encargado_ObtenerCategorias              │
│ + ObtenerProductos(): DataTable                 │
│   → SP_Encargado_ObtenerProductos               │
└─────────────────────────────────────────────────┘
```

### ProveedorDAL
```
┌─────────────────────────────────────────────────┐
│              ProveedorDAL                        │
├─────────────────────────────────────────────────┤
│ - _conexion: Conexion                           │
├─────────────────────────────────────────────────┤
│ + ObtenerProveedores(): DataTable               │
│   → SP_Encargado_ObtenerProveedores             │
└─────────────────────────────────────────────────┘
```

### Conexion (compartida)
```
┌─────────────────────────────────────────────────┐
│              Conexion                            │
├─────────────────────────────────────────────────┤
├─────────────────────────────────────────────────┤
│ + LeerPorStoreProcedure(nombreSP,               │
│     parametros?): DataTable                     │
│ + EscribirPorStoreProcedure(nombreSP,           │
│     parametros): int                            │
│ + crearParametro(nombre, valor): SqlParameter   │
└─────────────────────────────────────────────────┘
```

## Entidades (BE)

```
┌─────────────────────┐        ┌─────────────────────┐
│   OrdenCompraBE     │        │   ItemOrdenBE        │
├─────────────────────┤        ├─────────────────────┤
│ + IdOrdenCompra:int │  1  *  │ + IdOrden: int       │
│ + IdProveedor: int  │◄───────│ + IdProducto: int    │
│ + IdUsuario: int    │        │ + DescripcionProd:   │
│ + Fecha: DateTime   │        │     string           │
│ + Estado: string    │        │ + Cantidad: int      │
│ + Total: decimal    │        │ + PrecioUnitario:    │
└─────────────────────┘        │     decimal          │
                               │ + Subtotal: decimal  │
                               └─────────────────────┘

┌─────────────────────┐        ┌─────────────────────┐
│   ProveedorBE       │        │   ProductoBE         │
├─────────────────────┤        ├─────────────────────┤
│ + IdProveedor: int  │        │ + IdProducto: int    │
│ + RazonSocial:      │        │ + Codigo: string     │
│     string          │        │ + Descripcion:       │
│ + Cuit: string      │        │     string           │
│ + Direccion: string │        │ + Categoria: string  │
│ + Telefono: string  │        │ + PrecioCompra:      │
│ + Email: string     │        │     decimal          │
└─────────────────────┘        │ + PrecioVenta:       │
                               │     decimal          │
                               │ + StockActual: int   │
                               │ + StockMinimo: int   │
                               │ + Estado: string     │
                               └─────────────────────┘

┌─────────────────────┐        ┌─────────────────────┐
│ ListadoProductoBE   │        │   AlertaStockBE      │
├─────────────────────┤        ├─────────────────────┤
│ + IdProducto: int   │        │ + IdProducto: int    │
│ + Codigo: string    │        │ + Codigo: string     │
│ + Descripcion:      │        │ + Descripcion:       │
│     string          │        │     string           │
│ + Categoria: string │        │ + Categoria: string  │
│ + StockActual: int  │        │ + StockActual: int   │
│ + StockMinimo: int  │        │ + StockMinimo: int   │
│ + NivelAlerta:      │        │ + Nivel: string      │
│     string          │        └─────────────────────┘
└─────────────────────┘

┌─────────────────────┐        ┌─────────────────────┐
│   CategoriaBE       │        │  EstadoOrdenBE       │
├─────────────────────┤        ├─────────────────────┤
│ + Nombre: string    │        │ + Estado: string     │
└─────────────────────┘        └─────────────────────┘

┌─────────────────────┐
│  HistorialOrdenBE   │
├─────────────────────┤
│ + IdOrden: int      │
│ + Proveedor: string │
│ + Fecha: DateTime   │
│ + Estado: string    │
│ + Total: decimal    │
└─────────────────────┘
```

## Flujo de Datos

```
UI (WinForms)
    │
    │ List<BE>
    ▼
BLL (Service)
    │
    │ DataTable
    ▼
DAL
    │
    │ SQL
    ▼
SQL Server (SP)
```

## Resumen de SPs

| SP | DAL | Descripción |
|---|---|---|
| SP_Encargado_RegistrarOrdenCompra | OrdenCompraDAL | Crea una orden nueva |
| SP_Encargado_AgregarDetalleOrden | OrdenCompraDAL | Agrega item a la orden |
| SP_Encargado_ConfirmarOrden | OrdenCompraDAL | Confirma la orden |
| SP_Encargado_CancelarOrden | OrdenCompraDAL | Cancela la orden |
| SP_Encargado_ObtenerHistorialOrdenes | OrdenCompraDAL | Historial con filtros |
| SP_Encargado_ObtenerDetalleOrden | OrdenCompraDAL | Detalle de una orden |
| SP_Encargado_ObtenerItemsOrden | OrdenCompraDAL | Items de una orden |
| SP_Encargado_ObtenerEstadosOrden | OrdenCompraDAL | Lista de estados |
| SP_Encargado_ObtenerListadoProductos | ProductoDAL | Inventario con filtros |
| SP_Encargado_GenerarAlertaStock | ProductoDAL | Alertas de stock |
| SP_Encargado_RegistrarEgresoStock | ProductoDAL | Egreso de stock |
| SP_Encargado_ObtenerCategorias | ProductoDAL | Lista de categorías |
| SP_Encargado_ObtenerProductos | ProductoDAL | Lista de productos |
| SP_Encargado_ObtenerProveedores | ProveedorDAL | Lista de proveedores |
