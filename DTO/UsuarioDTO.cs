// Objeto de transferencia de datos para representar un Usuario
public class UsuarioDTO
{
    public int IdUsuario { get; set; }
    public string Usuario { get; set; }
    public string Contrasena { get; set; }
    public bool EstadoUsuario { get; set; }
    public int IdRol { get; set; }
}
