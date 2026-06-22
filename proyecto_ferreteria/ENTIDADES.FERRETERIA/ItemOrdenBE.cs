namespace ENTIDADES.FERRETERIA
{
    public class ItemOrdenBE
    {
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
