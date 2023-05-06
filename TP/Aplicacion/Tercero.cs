namespace aplicacion;

class Tercero : Persona {

    private static int s_Id = 0;
    public string? Aseguradora { get; set; }
    public int SiniestroId { get; private set; } // chequear los accesos

    public Tercero(string dni, string apellido, string nombre, string telefono, string aseguradora, int idSiniestro) : base(dni, apellido, nombre, telefono){
        Id = ++s_Id;
        Aseguradora = aseguradora;
        SiniestroId = idSiniestro;
    }

}
