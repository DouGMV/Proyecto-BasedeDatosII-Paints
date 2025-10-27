using Microsoft.Data.SqlClient;
using System.Data;

public class FacturaDAL
{
    public int Insertar(FacturaDTO f)
    {
        using var cn = new SqlConnection(DbHelper.ObtenerCadenaConexion());
        cn.Open();

        using var cmd = new SqlCommand("InsertarFactura", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@numeroFactura", f.NumeroFactura);
        cmd.Parameters.AddWithValue("@idCliente", f.IdCliente);
        cmd.Parameters.AddWithValue("@idEmpleado", f.IdEmpleado);
        cmd.Parameters.AddWithValue("@idMedioPago", f.IdMedioPago);
        cmd.Parameters.AddWithValue("@total", f.Total);

        // Crear DataTable para los detalles
        var dtDetalles = new DataTable();
        dtDetalles.Columns.Add("cantidad", typeof(int));
        dtDetalles.Columns.Add("precioUnidad", typeof(decimal));
        dtDetalles.Columns.Add("subtotal", typeof(decimal));
        dtDetalles.Columns.Add("descuento", typeof(decimal));
        dtDetalles.Columns.Add("impuestos", typeof(decimal));
        dtDetalles.Columns.Add("idProducto", typeof(int));

        foreach (var d in f.Detalles)
        {
            dtDetalles.Rows.Add(d.Cantidad, d.PrecioUnidad, d.Subtotal, d.Descuento, d.Impuestos, d.IdProducto);
        }

        var paramDetalles = cmd.Parameters.AddWithValue("@detalleFactura", dtDetalles);
        paramDetalles.SqlDbType = SqlDbType.Structured;
        paramDetalles.TypeName = "dbo.DetalleFacturaType";

        return Convert.ToInt32(cmd.ExecuteScalar());
    }
}
