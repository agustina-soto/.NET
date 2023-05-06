namespace aplicacion;

abstract class Persona {

    public int Id { get; }
    public string DNI { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }

    protected Persona(string dni, string apellido, string nombre, string telefono){  // por que telefono no??
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
        Telefono = telefono;
    }

}
