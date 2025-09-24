class Program
{
    static void Main()
    {
        var autenticacion = new Autenticacion();
        int idAdmin = autenticacion.CrearUsuario("admin", "Admin2025", 3, true); // 3 = Gerente
        Console.WriteLine($"Usuario admin creado con ID: {idAdmin}");
    }
}
