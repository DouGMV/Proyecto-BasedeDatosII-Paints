using Microsoft.Data.SqlClient;
using System.Data;

// Acceso a Datos para la entidad Empleado
public class EmpleadoDAL
{
    // Método para listar todos los empleados
    public List<EmpleadoDTO> Listar()
    {
        // Ejecuta el procedimiento almacenado ListarEmpleados
        var dt = DbHelper.EjecutarSpTabla("ListarEmpleados");

        var list = new List<EmpleadoDTO>();
        foreach (DataRow r in dt.Rows)
        {
            list.Add(new EmpleadoDTO
            {
                IdEmpleado = Convert.ToInt32(r["idEmpleado"]),
                Nombre = r["nombre"].ToString(),
                Apellido = r["apellido"].ToString(),
                Dpi = r["dpi"]?.ToString(),
                Direccion = r["direccion"]?.ToString(),
                Telefono = r["telefono"]?.ToString(),
                Email = r["email"]?.ToString(),

                // Manejo de campos que pueden ser NULL en la BD
                FechaNacimiento = r["fechaNacimiento"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["fechaNacimiento"]),
                FechaContratacion = r["fechaContratacion"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["fechaContratacion"]),
                Sueldo = r["sueldo"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["sueldo"]),
                IdUsuario = r["idUsuario"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["idUsuario"])
            });
        }
        return list;
    }

    // Método para insertar un empleado nuevo
    public int Insertar(EmpleadoDTO e)
    {
        // Ejecuta el procedimiento almacenado InsertarEmpleado
        var res = DbHelper.EjecutarSpEscalar("InsertarEmpleado",
            new SqlParameter("@nombre", e.Nombre),
            new SqlParameter("@apellido", e.Apellido),
            new SqlParameter("@dpi", string.IsNullOrEmpty(e.Dpi) ? (object)DBNull.Value : e.Dpi),
            new SqlParameter("@direccion", string.IsNullOrEmpty(e.Direccion) ? (object)DBNull.Value : e.Direccion),
            new SqlParameter("@telefono", string.IsNullOrEmpty(e.Telefono) ? (object)DBNull.Value : e.Telefono),
            new SqlParameter("@correo", string.IsNullOrEmpty(e.Email) ? (object)DBNull.Value : e.Email),
            new SqlParameter("@fechaNacimiento", e.FechaNacimiento ?? (object)DBNull.Value),
            new SqlParameter("@fechaContratacion", e.FechaContratacion ?? (object)DBNull.Value),
            new SqlParameter("@sueldo", e.Sueldo ?? (object)DBNull.Value),
            new SqlParameter("@idUsuario", e.IdUsuario ?? (object)DBNull.Value)
        );

        return Convert.ToInt32(res);
    }

    // Método para actualizar un empleado existente
    public int Actualizar(EmpleadoDTO e)
    {
        // Ejecuta el procedimiento almacenado ActualizarEmpleado
        return DbHelper.EjecutarSpNoConsulta("ActualizarEmpleado",
            new SqlParameter("@idEmpleado", e.IdEmpleado),
            new SqlParameter("@nombre", e.Nombre),
            new SqlParameter("@apellido", e.Apellido),
            new SqlParameter("@dpi", string.IsNullOrEmpty(e.Dpi) ? (object)DBNull.Value : e.Dpi),
            new SqlParameter("@direccion", string.IsNullOrEmpty(e.Direccion) ? (object)DBNull.Value : e.Direccion),
            new SqlParameter("@telefono", string.IsNullOrEmpty(e.Telefono) ? (object)DBNull.Value : e.Telefono),
            new SqlParameter("@correo", string.IsNullOrEmpty(e.Email) ? (object)DBNull.Value : e.Email),
            new SqlParameter("@fechaNacimiento", e.FechaNacimiento ?? (object)DBNull.Value),
            new SqlParameter("@fechaContratacion", e.FechaContratacion ?? (object)DBNull.Value),
            new SqlParameter("@sueldo", e.Sueldo ?? (object)DBNull.Value),
            new SqlParameter("@idUsuario", e.IdUsuario ?? (object)DBNull.Value)
        );
    }

    // Método para eliminar un empleado por ID
    public int Eliminar(int idEmpleado)
    {
        // Ejecuta el procedimiento almacenado EliminarEmpleado
        return DbHelper.EjecutarSpNoConsulta("EliminarEmpleado",
            new SqlParameter("@idEmpleado", idEmpleado));
    }
}
