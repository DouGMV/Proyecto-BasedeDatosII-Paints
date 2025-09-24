using Microsoft.Data.SqlClient;
using System.Data;

// Acceso a datos para la entidad Producto
public class ProductoDAL
{
    // Método para listar productos desde la base de datos
    public List<ProductoDTO> Listar()
    {
        // Ejecuta el procedimiento almacenado ListarProductos
        var dt = DbHelper.EjecutarSpTabla("ListarProductos");

        var list = new List<ProductoDTO>();
        foreach (DataRow r in dt.Rows)
        {
            list.Add(new ProductoDTO
            {
                IdProducto = Convert.ToInt32(r["idProducto"]),
                Nombre = r["nombre"].ToString(),
                Marca = r["marca"]?.ToString(),
                Descripcion = r["descripcion"]?.ToString(),
                PrecioVenta = Convert.ToDecimal(r["precioVenta"]),
                EstadoProducto = Convert.ToBoolean(r["estadoProducto"]),
                IdUnidadProducto = Convert.ToInt32(r["idUnidadProducto"]),
                IdCategoriaProducto = Convert.ToInt32(r["idCategoriaProducto"]),
                Stock = Convert.ToInt32(r["stock"] ?? 0)
            });
        }
        return list;
    }

    // Método para insertar un nuevo producto en la base de datos
    public int Insertar(ProductoDTO p)
    {
        // Ejecuta el procedimiento almacenado "InsertarProducto"
        var res = DbHelper.EjecutarSpEscalar("InsertarProducto",
            new SqlParameter("@nombre", p.Nombre),
            new SqlParameter("@marca", string.IsNullOrEmpty(p.Marca) ? (object)DBNull.Value : p.Marca),
            new SqlParameter("@descripcion", string.IsNullOrEmpty(p.Descripcion) ? (object)DBNull.Value : p.Descripcion),
            new SqlParameter("@precioVenta", p.PrecioVenta),
            new SqlParameter("@estadoProducto", p.EstadoProducto),
            new SqlParameter("@idUnidadProducto", p.IdUnidadProducto),
            new SqlParameter("@idCategoriaProducto", p.IdCategoriaProducto)
        );

        // Convierte el resultado (SCOPE_IDENTITY) a int (nuevo IdProducto)
        return Convert.ToInt32(res);
    }

    // Método para actualizar un producto existente
    public int Actualizar(ProductoDTO p)
    {
        // Ejecuta el procedimiento almacenado "ActualizarProducto"
        return DbHelper.EjecutarSpNoConsulta("ActualizarProducto",
            new SqlParameter("@idProducto", p.IdProducto),
            new SqlParameter("@nombre", p.Nombre),
            new SqlParameter("@marca", string.IsNullOrEmpty(p.Marca) ? (object)DBNull.Value : p.Marca),
            new SqlParameter("@descripcion", string.IsNullOrEmpty(p.Descripcion) ? (object)DBNull.Value : p.Descripcion),
            new SqlParameter("@precioVenta", p.PrecioVenta),
            new SqlParameter("@estadoProducto", p.EstadoProducto),
            new SqlParameter("@idUnidadProducto", p.IdUnidadProducto),
            new SqlParameter("@idCategoriaProducto", p.IdCategoriaProducto)
        );
    }

    // Método para eliminar un producto por su ID
    public int Eliminar(int idProducto)
    {
        // Ejecuta el procedimiento almacenado "EliminarProducto"
        return DbHelper.EjecutarSpNoConsulta("EliminarProducto",
            new SqlParameter("@idProducto", idProducto));
    }
}
