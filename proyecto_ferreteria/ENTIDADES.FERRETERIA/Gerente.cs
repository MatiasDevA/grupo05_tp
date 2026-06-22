using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public class Gerente : Usuario
    {
        public Gerente(int idUsuario,string nombreUsuario,string clave,string nombre,string apellido)
            : base(idUsuario, nombreUsuario, clave, nombre, apellido)
        /* El constructor de Gerente llama al constructor de la clase base Usuario
         * para inicializar los campos heredados.
         */
        {
        }
    }
}
