using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public class OrdenCompraDetalleBE
    {
        private OrdenCompraBE _cabecera;
        private List<DetalleCompraBE> _detalles;

        public OrdenCompraBE Cabecera
        {
            get { return _cabecera; }
            set { _cabecera = value; }
        }

        public List<DetalleCompraBE> Detalles
        {
            get { return _detalles; }
            set { _detalles = value; }
        }
    }
}
