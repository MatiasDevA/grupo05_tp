using System;
using System.Collections.Generic;
using System.Data;
using DAL_FERRETERIA;
using ENTIDADES.FERRETERIA;

namespace BLL_FERRETERIA
{
    public class AdminService
    {
        private readonly AdminDatos _dal = new AdminDatos();

        private static string SafeString(DataRow row, string columnName)
        {
            if (!row.Table.Columns.Contains(columnName))
                return null;
            return row[columnName] == DBNull.Value ? null : row[columnName].ToString();
        }

        private static int SafeInt(DataRow row, string columnName, int defaultValue = 0)
        {
            if (!row.Table.Columns.Contains(columnName))
                return defaultValue;
            if (row[columnName] == DBNull.Value)
                return defaultValue;
            return Convert.ToInt32(row[columnName]);
        }

        public UsuarioBE AltaUsuario(string nombre, string apellido, string email, string usuario, string clave, string telefono, int idPerfil)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido es obligatorio.");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("El email es obligatorio.");
            if (string.IsNullOrWhiteSpace(usuario))
                throw new ArgumentException("El usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("La contraseña es obligatoria.");
            if (idPerfil <= 0)
                throw new ArgumentException("Seleccione un perfil.");

            DataTable dt = _dal.AltaUsuario(nombre, apellido, email, usuario, clave, telefono, idPerfil);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new UsuarioBE
                {
                    IdUsuario = SafeInt(row, "id_usuario"),
                    Nombre = SafeString(row, "nombre"),
                    Apellido = SafeString(row, "apellido"),
                    Email = SafeString(row, "email"),
                    Usuario = SafeString(row, "usuario"),
                    Telefono = SafeString(row, "nro_telefono"),
                    Estado = SafeString(row, "estado"),
                    NombrePerfil = SafeString(row, "perfil")
                };
            }

            return null;
        }

        public string ModificarUsuario(int idUsuario, string nombre, string apellido, string email, string telefono)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("ID de usuario no válido.");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido es obligatorio.");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("El email es obligatorio.");

            DataTable dt = _dal.ModificarUsuario(idUsuario, nombre, apellido, email, telefono);

            if (dt != null && dt.Rows.Count > 0)
                return SafeString(dt.Rows[0], "resultado");

            return "Modificado correctamente.";
        }

        public string CambiarEstadoUsuario(int idUsuario, string estado)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("ID de usuario no válido.");
            if (string.IsNullOrWhiteSpace(estado))
                throw new ArgumentException("El estado es obligatorio.");

            DataTable dt = _dal.CambiarEstadoUsuario(idUsuario, estado);

            if (dt != null && dt.Rows.Count > 0)
                return $"Estado cambiado a '{SafeString(dt.Rows[0], "estado_nuevo")}'.";

            return "Estado cambiado.";
        }

        public string CambiarPerfilUsuario(int idUsuario, int idPerfil)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("ID de usuario no válido.");
            if (idPerfil <= 0)
                throw new ArgumentException("Seleccione un perfil.");

            DataTable dt = _dal.CambiarPerfilUsuario(idUsuario, idPerfil);

            if (dt != null && dt.Rows.Count > 0)
                return $"Perfil cambiado a '{SafeString(dt.Rows[0], "perfil_nuevo")}'.";

            return "Perfil cambiado.";
        }

        public List<UsuarioBE> ListarUsuarios(int? idPerfil = null, string estado = null, string textoBusqueda = null)
        {
            DataTable dt = _dal.ListarUsuarios(idPerfil, estado, textoBusqueda);
            var lista = new List<UsuarioBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new UsuarioBE
                {
                    IdUsuario = SafeInt(row, "id_usuario"),
                    Nombre = SafeString(row, "nombre"),
                    Apellido = SafeString(row, "apellido"),
                    Email = SafeString(row, "email"),
                    Usuario = SafeString(row, "usuario"),
                    Telefono = SafeString(row, "nro_telefono"),
                    Estado = SafeString(row, "estado"),
                    NombrePerfil = SafeString(row, "perfil")
                });
            }

            return lista;
        }

        public List<PerfilBE> ObtenerPerfiles()
        {
            DataTable dt = _dal.ObtenerPerfiles();
            var lista = new List<PerfilBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new PerfilBE
                {
                    IdPerfil = SafeInt(row, "id_perfil"),
                    Nombre = SafeString(row, "nombre"),
                    Descripcion = SafeString(row, "descripcion")
                });
            }

            return lista;
        }

        public UsuarioBE ObtenerUsuarioPorId(int idUsuario)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("ID de usuario no válido.");

            DataTable dt = _dal.ObtenerUsuarioPorId(idUsuario);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new UsuarioBE
                {
                    IdUsuario = SafeInt(row, "id_usuario"),
                    Nombre = SafeString(row, "nombre"),
                    Apellido = SafeString(row, "apellido"),
                    Email = SafeString(row, "email"),
                    Usuario = SafeString(row, "usuario"),
                    Telefono = SafeString(row, "nro_telefono"),
                    Estado = SafeString(row, "estado"),
                    IdPerfil = SafeInt(row, "id_perfil"),
                    NombrePerfil = SafeString(row, "perfil")
                };
            }

            return null;
        }

        public string ModificarUsuarioClave(int idUsuario, string usuario, string clave)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("ID de usuario no válido.");
            if (string.IsNullOrWhiteSpace(usuario))
                throw new ArgumentException("El usuario es obligatorio.");

            DataTable dt = _dal.ModificarUsuarioClave(idUsuario, usuario, clave);

            if (dt != null && dt.Rows.Count > 0)
                return SafeString(dt.Rows[0], "resultado");

            return "Usuario y contraseña modificados.";
        }
    }
}
