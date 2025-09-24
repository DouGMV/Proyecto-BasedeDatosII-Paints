//Libreria para encriptar contraseñas
using BCrypt.Net;

public class Autenticacion
{
    private readonly UsuarioDAL usuarioDal = new UsuarioDAL();
    private readonly LogDAL logDal = new LogDAL();

    // Metodo para obtener un usuario de la BD por su nombre
    public UsuarioDTO ObtenerUsuarioPorNombre(string usuario) => usuarioDal.ObtenerPorNombre(usuario);

    public (bool Success, string Message, UsuarioDTO Usuario) Login(string nombreUsuario, string contrasena)
    {
        // Buscar el usuario en la base de datos
        var usuario = usuarioDal.ObtenerPorNombre(nombreUsuario);

        // Validar si existe
        if (usuario == null) return (false, "Usuario no encontrado.", null);

        // Validar si está activo
        if (!usuario.EstadoUsuario) return (false, "Usuario inactivo.", null);

        // Comparar la contraseña ingresada con la contraseña almacenada
        bool ok = BCrypt.Net.BCrypt.Verify(contrasena, usuario.Contrasena);
        if (!ok) return (false, "Contraseña incorrecta.", null);

        // Registrar en la tabla LogUsuario
        logDal.InsertarLog(usuario.IdUsuario, $"Login exitoso ({DateTime.Now})");

        return (true, "Login correcto", usuario);
    }

    // Crear un usuario nuevo
    public int CrearUsuario(string nombreUsuario, string contrasena, int idRol, bool activo = true)
    {
        // Generar un hash seguro de la contraseña usando BCrypt
        var hash = BCrypt.Net.BCrypt.HashPassword(contrasena);

        // Insertar el nuevo usuario en la BD con el hash
        return usuarioDal.InsertarUsuario(nombreUsuario, hash, activo, idRol);
    }
}


