namespace aplicacion;

class Titular : Persona {

    private static int s_id = 0;
    public string Direccion { get; set; }
    public string Correo { get; set; }

    public Titular(string dni, string apellido, string nombre, string telefono, string direccion, string correo) : base(dni, apellido, nombre, telefono){
        Id = ++s_id;
        Direccion = direccion;
        Correo = correo;
    }

    public override string ToString() => base.ToString() + " " + this.Direccion + " " + base.Telefono + " " + this.Correo;
}
