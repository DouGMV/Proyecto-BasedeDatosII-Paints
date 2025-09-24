public class ClienteBLL
{
    private ClienteDAL clientedal = new ClienteDAL();

    // Método para listar todos los clientes
    public List<ClienteDTO> Listar() => clientedal.Listar();

    // Método para insertar o actualizar un cliente
    public int Guardar(ClienteDTO c)
    {
        // Validaciones
        if (string.IsNullOrWhiteSpace(c.Nombre))
            throw new ArgumentException("Nombre es obligatorio");
        if (string.IsNullOrWhiteSpace(c.Apellido))
            throw new ArgumentException("Apellido es obligatorio");

        if (c.IdCliente == 0)
            return clientedal.Insertar(c);
        else
        {
            clientedal.Actualizar(c);
            return c.IdCliente;
        }
    }

    // Método para eliminar un cliente por ID
    public void Eliminar(int id) => clientedal.Eliminar(id);
}


