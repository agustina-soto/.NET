namespace aplicacion;

class Poliza {

    private static int s_id = 0;
    public int Id { get; }
    public double ValorAsegurado { get; set; }
    public double Franquicia { get; set; }
    public string TipoCobertura { get; set; }
    public DateTime InicioVigencia { get; set; }
    public DateTime FinVigencia { get; set; }
    public int VehiculoId { get; private set; }

    public Poliza(double valorAsegurado, double franquicia, string tipoCobertura, DateTime inicioVigencia, DateTime finVigencia, int idVehiculo){
        Id = ++s_id;
        ValorAsegurado = valorAsegurado;
        Franquicia = franquicia;
        TipoCobertura = tipoCobertura;
        InicioVigencia = inicioVigencia;
        FinVigencia = finVigencia;
        VehiculoId = idVehiculo;
    }
}
