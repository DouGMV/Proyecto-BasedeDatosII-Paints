using Microsoft.Data.SqlClient;
using System.Data;

// Acceso a datos para la entidad Cliente
public class ClienteDAL
{
    // Método para listar clientes desde la base de datos
    public List<ClienteDTO> Listar()
    {
        // Llama al procedimiento almacenado ListarClientes
        var dt = DbHelper.EjecutarSpTabla("ListarClientes");

        // Convierte el resultado en una lista de objetos ClienteDTO
        var list = new List<ClienteDTO>();
        foreach (DataRow r in dt.Rows)
        {
            list.Add(new ClienteDTO
            {
                IdCliente = Convert.ToInt32(r["idCliente"]),
                Nombre = r["nombre"].ToString(),
                Apellido = r["apellido"].ToString(),
                Dpi = r["dpi"]?.ToString(),
                Nit = r["nit"]?.ToString(),
                Direccion = r["direccion"]?.ToString(),
                Telefono = r["telefono"]?.ToString(),
                Email = r["email"]?.ToString()
            });
        }
        return list;
    }

    // Método para insertar un nuevo cliente
    public int Insertar(ClienteDTO c)
    {
        // Llama al procedimiento almacenado InsertarCliente
        var res = DbHelper.EjecutarSpEscalar("InsertarCliente",
            new SqlParameter("@nombre", c.Nombre),
            new SqlParameter("@apellido", c.Apellido),
            new SqlParameter("@dpi", string.IsNullOrEmpty(c.Dpi) ? (object)DBNull.Value : c.Dpi),
            new SqlParameter("@nit", string.IsNullOrEmpty(c.Nit) ? (object)DBNull.Value : c.Nit),
            new SqlParameter("@direccion", string.IsNullOrEmpty(c.Direccion) ? (object)DBNull.Value : c.Direccion),
            new SqlParameter("@telefono", string.IsNullOrEmpty(c.Telefono) ? (object)DBNull.Value : c.Telefono),
            new SqlParameter("@correo", string.IsNullOrEmpty(c.Email) ? (object)DBNull.Value : c.Email)
        );
        return Convert.ToInt32(res);
    }

    // Método para actualizar un cliente existente
    public int Actualizar(ClienteDTO c)
    {
        // Llama al procedimiento almacenado ActualizarCliente
        return DbHelper.EjecutarSpNoConsulta("ActualizarCliente",
            new SqlParameter("@idCliente", c.IdCliente),
            new SqlParameter("@nombre", c.Nombre),
            new SqlParameter("@apellido", c.Apellido),
            new SqlParameter("@dpi", string.IsNullOrEmpty(c.Dpi) ? (object)DBNull.Value : c.Dpi),
            new SqlParameter("@nit", string.IsNullOrEmpty(c.Nit) ? (object)DBNull.Value : c.Nit),
            new SqlParameter("@direccion", string.IsNullOrEmpty(c.Direccion) ? (object)DBNull.Value : c.Direccion),
            new SqlParameter("@telefono", string.IsNullOrEmpty(c.Telefono) ? (object)DBNull.Value : c.Telefono),
            new SqlParameter("@correo", string.IsNullOrEmpty(c.Email) ? (object)DBNull.Value : c.Email)
        );
    }

    // Método para eliminar un cliente por ID
    public int Eliminar(int idCliente)
    {
        // Llama al procedimiento almacenado EliminarCliente
        return DbHelper.EjecutarSpNoConsulta("EliminarCliente",
            new SqlParameter("@idCliente", idCliente));
    }
}
