namespace ejercicio5;

class Hora
{
    private int _horas;
    private int _minutos;
    private int _segundos;
    private double _segundosD;

    public Hora(int horas, int minutos, int segundos) {
        _horas = horas;
        _minutos = minutos;
        _segundos = segundos;
    }

    public Hora(double hora) {
        _horas = (int)hora; // Trunca a entero
        _minutos = (int) ((hora-_horas)*60);
        _segundosD = ((hora-_horas)*60 - _minutos)*60;
        _segundos = -1;
    }

    public void revisarSegundos() {
        if (Math.Round(_segundosD) == 60) { // Si es mayor a 59.999 (redondeado: 60) se considera 1 min
            _segundosD = 0;
            _minutos += 1;
        }
    }


    public void revisarMinutos() {
            if (_minutos > 59) {
                _minutos -= 60;
                _horas += 1;
            }
    }

    public void Imprimir() {
        if (_segundos != -1) {
            Console.WriteLine( $"{_horas} horas, {_minutos} minutos y {_segundos} segundos" );
        }
        else {
            revisarSegundos();
            revisarMinutos();
            Console.WriteLine( $"{_horas} horas, {_minutos} minutos y {_segundosD:0.000} segundos" ); // _segundosD:0.000 => Imprime 3 digitos decimales
        }
        Console.WriteLine("\n");
    }
}
