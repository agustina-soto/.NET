namespace ejercicio12;

class Cuenta
{

    private string? _titularNombre;
    private int _titularDNI;
    private double _monto;

    public Cuenta(){
        _monto = 0;
        _titularNombre = "No especificado";
        _titularDNI = -1;
    }

    public Cuenta(int titularDNI) :this()
    {
        _titularDNI = titularDNI;
    }

    public Cuenta(String titularNombre) :this()
    {
        _titularNombre = titularNombre;
    }

    public Cuenta(String titularNombre, int titularDNI) :this() {
        _titularNombre = titularNombre;
        _titularDNI = titularDNI;
    }

    public void Imprimir() => Console.WriteLine($"Nombre: {_titularNombre}, DNI: {((_titularDNI == -1) ? "No especificado" : _titularDNI)}, Monto: {_monto}");

    public void Depositar(double monto) => _monto += monto;
    public void Extraer(double monto){
        try
        {
            if (_monto > monto) _monto -= monto;
            else throw new Exception("Operacion cancelada, monto insuficiente");  
        }
        catch (Exception e)
        {
            // Console.WriteLine("manejando la excepcion");
            Console.WriteLine(e.Message);
        }
    }

}
