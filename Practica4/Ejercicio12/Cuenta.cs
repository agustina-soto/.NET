namespace ejercicio12;

class Cuenta
{

    private String _titular;
    private int _numero;
    private int _monto = 0; // Esta mal hacerlo aca y no en los constructores? calculo q tendria q hacerlo en todos...

    public Cuenta(){

    }

    public Cuenta(String titular, int numero){
        _titular = titular;
        _numero = numero;
    }

    public Cuenta(int numero){
        _numero = numero;
    }

    public Cuenta(String titular){
        _titular = titular;
    }

    public void Imprimir() => Console.WriteLine($"NUMERO DE LA CUENTA: {_numero} | TITULAR: {_titular} | MONTO DISPONIBLE: {_monto}");

    public void Depositar(int monto) => _monto += monto;
    public void Extraer(int monto){
        try
        {
            if (_monto > monto) _monto -= monto;
            else throw new Exception("Dinero insuficiente. No se puede extraer esa cantidad");  
        }
        catch (Exception e)
        {
            // Console.WriteLine("manejando la excepcion");
            Console.WriteLine(e.Message);
        }
    }


}
