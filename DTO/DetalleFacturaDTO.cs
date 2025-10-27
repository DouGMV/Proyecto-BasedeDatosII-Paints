public class DetalleFacturaDTO
{
    public int IdDetalleFactura { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnidad { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Descuento { get; set; }
    public decimal Impuestos { get; set; }
    public int IdProducto { get; set; }
}

