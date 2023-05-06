namespace aplicacion;

class Siniestro {

    private static int s_id = 0;
    public int Id { get; }
    public DateTime FechaIngreso { get; set; }
    public DateTime FechaOcurrencia { get; set; }
    public string Direccion { get; set; }
    public string Descripcion { get; set; }
    public int PolizaId { get; set; }

    public Siniestro(DateTime fechaIngreso, DateTime fechaOcurrencia, string direccion, string descripcion, int idPoliza){
        Id = ++s_id;
        FechaIngreso = fechaIngreso;
        FechaOcurrencia = fechaOcurrencia;
        Direccion = direccion;
        Descripcion = descripcion;
        PolizaId = idPoliza;
    }    
}
