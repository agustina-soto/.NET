namespace ejercicio4;

class Hora
{
    private int _segundos;
    private int _minutos;
    private int _horas;

    public Hora(int horas, int minutos, int segundos){
        this._segundos = segundos;
        this._minutos = minutos;
        this._horas = horas;
    }

    public void Imprimir(){
        Console.WriteLine($"{this._horas} horas, {this._minutos} minutos y {this._segundos} segundos");
    }
}
