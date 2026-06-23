namespace ENTIDADES.FERRETERIA
{
    public class ItemOrdenBE
    {
        public int IdDetalle { get; set; }
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string DescripcionProducto { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
