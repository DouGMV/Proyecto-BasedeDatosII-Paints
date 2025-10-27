public class UsuarioBLL
{
    private readonly UsuarioDAL usuarioDAL = new UsuarioDAL();

    public List<UsuarioDTO> Listar()
    {
        return usuarioDAL.Listar();
    }

    public void Guardar(UsuarioDTO u)
    {
        if (u.IdUsuario == 0)
        {
            // Se está creando un usuario nuevo
            string hash = BCrypt.Net.BCrypt.HashPassword(u.Contrasena);
            usuarioDAL.InsertarUsuario(u.Usuario, hash, u.EstadoUsuario, u.IdRol);
        }
        else
        {
            // Se está actualizando usuario existente
            usuarioDAL.Actualizar(u);
        }
    }

    public void Eliminar(int idUsuario)
    {
        usuarioDAL.Eliminar(idUsuario);
    }

    public UsuarioDTO ObtenerPorNombre(string nombreUsuario)
    {
        return usuarioDAL.ObtenerPorNombre(nombreUsuario);
    }
}
