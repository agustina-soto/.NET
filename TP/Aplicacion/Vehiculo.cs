namespace aplicacion;

class Vehiculo {

    private static int s_id = 0;
    public int Id { get; }
    public string Dominio { get; set; }
    public string Marca { get; set; }
    public int FechaFabricacion { get; set; }
    public int TitularId { get; set; }

    public Vehiculo(){

    }
}
