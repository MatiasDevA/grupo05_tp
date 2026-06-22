using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public class Vendedor : Usuario
    {
        public Vendedor(int idUsuario, string nombreUsuario, string clave, string nombre, string apellido) 
            : base(idUsuario, nombreUsuario, clave, nombre, apellido)
        {

        }
    }
}
