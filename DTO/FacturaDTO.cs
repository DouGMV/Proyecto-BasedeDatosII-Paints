public class FacturaDTO
{
    public int IdFactura { get; set; }
    public string NumeroFactura { get; set; }
    public DateTime FechaEmision { get; set; }
    public decimal Total { get; set; }
    public int IdCliente { get; set; }
    public int IdEmpleado { get; set; }
    public int IdMedioPago { get; set; }
    public List<DetalleFacturaDTO> Detalles { get; set; } = new();
}

