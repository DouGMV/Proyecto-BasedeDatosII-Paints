// Objeto de transferencia de datos para representar un Producto
public class ProductoDTO
{
    public int IdProducto { get; set; }
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public string Descripcion { get; set; }
    public decimal PrecioVenta { get; set; }
    public bool EstadoProducto { get; set; }
    public int IdUnidadProducto { get; set; }
    public int IdCategoriaProducto { get; set; }
    public string Categoria { get; set; }
    public string UnidadMedida { get; set; }
    public int Stock { get; set; }
}

