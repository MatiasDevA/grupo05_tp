using System;

namespace ENTIDADES.FERRETERIA
{
    public class HistorialOrdenBE
    {
        public int IdOrden { get; set; }
        public string Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
    }
}
