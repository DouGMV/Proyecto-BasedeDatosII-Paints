public class FacturaBLL
{
    private FacturaDAL dal = new FacturaDAL();

    public int GuardarFactura(FacturaDTO factura)
    {
        if (factura.Detalles == null || factura.Detalles.Count == 0)
            throw new Exception("Debe agregar al menos un producto.");

        if (factura.Total <= 0)
            throw new Exception("El total no puede ser 0.");

        return dal.Insertar(factura);
    }

    public void AnularFactura(string numeroFactura)
    {
        if (string.IsNullOrWhiteSpace(numeroFactura))
            throw new Exception("El número de factura es obligatorio.");

        dal.AnularPorNumero(numeroFactura);
    }
}

