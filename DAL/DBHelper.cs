using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

// Clase que ayuda a ejecutar procedimientos almacenados en SQL Server
public static class DbHelper
{
    // Método para obtener la cadena de conexión desde appsettings.json
    public static string ObtenerCadenaConexion()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        return config.GetConnectionString("Paints");
    }

    // Ejecuta un procedimiento almacenado que devuelve una tabla de datos
    public static DataTable EjecutarSpTabla(string nombreSp, params SqlParameter[] parametros)
    {
        var dt = new DataTable();
        using (var cn = new SqlConnection(ObtenerCadenaConexion()))
        using (var cmd = new SqlCommand(nombreSp, cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null && parametros.Length > 0)
                cmd.Parameters.AddRange(parametros);

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
        }
        return dt;
    }

    // Ejecuta un procedimiento almacenado que devuelve un único valor
    public static object EjecutarSpEscalar(string nombreSp, params SqlParameter[] parametros)
    {
        using (var cn = new SqlConnection(ObtenerCadenaConexion()))
        using (var cmd = new SqlCommand(nombreSp, cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null && parametros.Length > 0)
                cmd.Parameters.AddRange(parametros);

            cn.Open();
            return cmd.ExecuteScalar();
        }
    }

    // Ejecuta un procedimiento almacenado que no devuelve datos
    public static int EjecutarSpNoConsulta(string nombreSp, params SqlParameter[] parametros)
    {
        using (var cn = new SqlConnection(ObtenerCadenaConexion()))
        using (var cmd = new SqlCommand(nombreSp, cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null && parametros.Length > 0)
                cmd.Parameters.AddRange(parametros);

            cn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
