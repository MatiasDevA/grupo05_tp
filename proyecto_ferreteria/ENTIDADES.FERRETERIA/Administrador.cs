using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public class Administrador : Usuario
    {
        public Administrador(int idUsuario, string nombreUsuario, string clave, string nombre, string apellido) 
            : base(idUsuario, nombreUsuario, clave, nombre, apellido)
        {
   
        }
        public void AltaUsuario(Usuario usuario)
        {
            // Lógica para dar de alta a un nuevo usuario
        }
        
    }
}
