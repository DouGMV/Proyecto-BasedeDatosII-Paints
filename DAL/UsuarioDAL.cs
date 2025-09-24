using Microsoft.Data.SqlClient;
using System.Data;

// Acceso a datos para la entidad Usuario
public class UsuarioDAL
{
    // Obtener un usuario por su nombre de usuario
    public UsuarioDTO ObtenerPorNombre(string nombreUsuario)
    {
        // Llama al procedimiento almacenado ObtenerUsuarioPorNombre
        var dt = DbHelper.EjecutarSpTabla("ObtenerUsuarioPorNombre",
            new SqlParameter("@nombreUsuario", nombreUsuario));

        if (dt.Rows.Count == 0) return null;

        var r = dt.Rows[0];

        return new UsuarioDTO
        {
            IdUsuario = (int)r["idUsuario"],
            Usuario = r["usuario"].ToString(),
            Contrasena = r["contrasena"].ToString(),   // ← contraseña está almacenada en HASH
            EstadoUsuario = Convert.ToBoolean(r["estadoUsuario"]),
            IdRol = Convert.ToInt32(r["idRol"])
        };
    }

    // Método que inserta un nuevo usuario en la base de datos
    public int InsertarUsuario(string usuario, string hashContrasena, bool estado, int idRol)
    {
        // Llama al procedimiento almacenado InsertarUsuario
        var result = DbHelper.EjecutarSpEscalar("InsertarUsuario",
            new SqlParameter("@usuario", usuario),
            new SqlParameter("@contrasena", hashContrasena),
            new SqlParameter("@estadoUsuario", estado),
            new SqlParameter("@idRol", idRol));

        return Convert.ToInt32(result);
    }
}
