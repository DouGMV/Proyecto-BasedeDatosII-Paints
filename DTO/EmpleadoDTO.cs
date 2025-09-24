// Objeto de transferencia de datos para representar un Empleado
public class EmpleadoDTO
{
    public int IdEmpleado { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Dpi { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public DateTime? FechaContratacion { get; set; }
    public decimal? Sueldo { get; set; }
    public int? IdUsuario { get; set; }
}
