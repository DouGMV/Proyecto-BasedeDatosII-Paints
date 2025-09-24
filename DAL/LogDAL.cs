using Microsoft.Data.SqlClient;
// Acceso a datos para manejar registros en la tabla LogUsuario
public class LogDAL
{
    // Método para insertar un registro en el log de usuario
    public void InsertarLog(int idUsuario, string accion)
    {
        // Ejecuta el procedimiento almacenado InsertarLogUsuario
        DbHelper.EjecutarSpNoConsulta("InsertarLogUsuario",
            new SqlParameter("@idUsuario", idUsuario),
            new SqlParameter("@accion", accion)
        );
    }
}
