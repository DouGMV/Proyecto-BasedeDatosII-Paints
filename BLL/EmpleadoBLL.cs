public class EmpleadoBLL
{
    private EmpleadoDAL empleadodal = new EmpleadoDAL();

    // Método para obtener la lista de empleados
    public List<EmpleadoDTO> Listar()
    {
        return empleadodal.Listar();
    }

    // Método para insertar o actualizar un empleado
    public int Guardar(EmpleadoDTO e)
    {
        // Validaciones
        if (string.IsNullOrWhiteSpace(e.Nombre))
            throw new Exception("El nombre es obligatorio.");
        if (string.IsNullOrWhiteSpace(e.Apellido))
            throw new Exception("El apellido es obligatorio.");

        if (e.IdEmpleado == 0)
            return empleadodal.Insertar(e);
        else
        {
            empleadodal.Actualizar(e);
            return e.IdEmpleado;
        }
    }

    // Método para eliminar un empleado por su ID
    public void Eliminar(int idEmpleado)
    {
        // Validación
        if (idEmpleado <= 0)
            throw new Exception("ID inválido.");

        empleadodal.Eliminar(idEmpleado);
    }
}

