namespace aplicacion;

abstract class Persona {

    public int Id { get; protected set; } // MAITE: aca le puse protected al set asi tercero y titular lo pueden setear
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

    public override string ToString() => this.DNI + " " + this.Apellido + ", " + this.Nombre; // El telefono hay q imprimirlo manual en la clase derivada :)

}
