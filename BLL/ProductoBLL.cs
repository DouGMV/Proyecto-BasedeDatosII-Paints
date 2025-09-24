public class ProductoBLL
{
    private ProductoDAL productodal = new ProductoDAL();

    // Método para obtener todos los productos
    public List<ProductoDTO> Listar()
    {
        return productodal.Listar();
    }

    // Método para insertar o actualizar un producto
    public int Guardar(ProductoDTO p)
    {
        // Validaciones
        if (string.IsNullOrWhiteSpace(p.Nombre))
            throw new Exception("El nombre del producto es obligatorio.");

        if (p.PrecioVenta <= 0)
            throw new Exception("El precio debe ser mayor a 0.");

        if (p.IdProducto == 0)
            return productodal.Insertar(p);
        else
        {
            productodal.Actualizar(p);
            return p.IdProducto;
        }
    }

    // Método para eliminar un producto por ID
    public void Eliminar(int idProducto)
    {
        if (idProducto <= 0)
            throw new Exception("ID inválido.");

        productodal.Eliminar(idProducto);
    }
}
