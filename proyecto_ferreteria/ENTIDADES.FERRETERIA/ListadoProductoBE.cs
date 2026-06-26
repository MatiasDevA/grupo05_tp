namespace ENTIDADES.FERRETERIA
{
    public class ListadoProductoBE
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public string NivelAlerta { get; set; }
    }
}
