using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

// Acceso a datos para la entidad Usuario
public class UsuarioDAL
{
    //  Obtener un usuario por su nombre de usuario (login)
    public UsuarioDTO ObtenerPorNombre(string nombreUsuario)
    {
        var dt = DbHelper.EjecutarSpTabla("ObtenerUsuarioPorNombre",
            new SqlParameter("@nombreUsuario", nombreUsuario));

        if (dt.Rows.Count == 0) return null;

        var r = dt.Rows[0];

        return new UsuarioDTO
        {
            IdUsuario = (int)r["idUsuario"],
            Usuario = r["usuario"].ToString(),
            Contrasena = r["contrasena"].ToString(), // hash
            EstadoUsuario = Convert.ToBoolean(r["estadoUsuario"]),
            IdRol = Convert.ToInt32(r["idRol"])
        };
    }

    //  Insertar un nuevo usuario (ya lo tienes)
    public int InsertarUsuario(string usuario, string hashContrasena, bool estado, int idRol)
    {
        var result = DbHelper.EjecutarSpEscalar("InsertarUsuario",
            new SqlParameter("@usuario", usuario),
            new SqlParameter("@contrasena", hashContrasena),
            new SqlParameter("@estadoUsuario", estado),
            new SqlParameter("@idRol", idRol));

        return Convert.ToInt32(result);
    }

    //  Listar todos los usuarios con su rol (para el CRUD visual)
    public List<UsuarioDTO> Listar()
    {
        var dt = DbHelper.EjecutarSpTabla("ListarUsuarios");
        var lista = new List<UsuarioDTO>();

        foreach (DataRow r in dt.Rows)
        {
            lista.Add(new UsuarioDTO
            {
                IdUsuario = Convert.ToInt32(r["idUsuario"]),
                Usuario = r["usuario"].ToString(),
                EstadoUsuario = Convert.ToBoolean(r["estadoUsuario"]),
                Rol = r["rol"].ToString(),
                IdRol = Convert.ToInt32(r["idRol"])
            });
        }

        return lista;
    }

    // Actualizar un usuario existente
    public int Actualizar(UsuarioDTO u)
    {
        return DbHelper.EjecutarSpNoConsulta("ActualizarUsuario",
            new SqlParameter("@idUsuario", u.IdUsuario),
            new SqlParameter("@usuario", u.Usuario),
            new SqlParameter("@estadoUsuario", u.EstadoUsuario),
            new SqlParameter("@idRol", u.IdRol));
    }

    // Eliminar usuario
    public int Eliminar(int idUsuario)
    {
        return DbHelper.EjecutarSpNoConsulta("EliminarUsuario",
            new SqlParameter("@idUsuario", idUsuario));
    }
}
