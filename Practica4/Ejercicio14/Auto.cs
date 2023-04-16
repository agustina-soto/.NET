namespace Automotores;

public class Auto{
    private string _marca;
    private int _modelo;

    public Auto(string marca, int modelo)
    {
        _marca = marca;
        _modelo = modelo;
    }
        public string ObtenerDescripcion() => $"Auto {_marca} {_modelo}";

    public Auto()
    {
        _marca = "Fiat";
        _modelo = DateTime.Now.Year;
    }


    public Auto(string marca) : this(marca, DateTime.Now.Year)
    {
    }

    public string GetDescripcion(){
        return $"Auto {_marca} {_modelo}";
    }
}
