using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public abstract class Usuario
    {
        protected string _nombreUsuario, _clave, _nombre, _apellido;
        protected int _idUsuario;
        protected Boolean _activo;

        protected Usuario(
                          int idUsuario,
                          string nombreUsuario,
                          string clave,
                          string nombre,
                          string apellido
                         )
        {
            _idUsuario = idUsuario;
            _nombreUsuario = nombreUsuario;
            _clave = clave;
            _nombre = nombre;
            _apellido = apellido;
            _activo = true;
        }



        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public Boolean Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

    }
}

