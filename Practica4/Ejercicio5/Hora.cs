namespace ejercicio5;

class Hora
{
    private int _horas;
    private int _minutos;
    private int _segundos = -1;
    private double _segundosD = -1;

    public Hora(int horas, int minutos, int segundos) {
        _horas = horas;
        _minutos = minutos;
        _segundos = segundos;
    }

    public Hora(double hora) {
        _horas = (int)hora; // Trunca a entero
        double aux = (hora - _horas)*60;
        _minutos = (int)aux;
        _segundosD = (aux - _minutos)*60;
    }

    public void revisarSegundos() {
        if (_segundosD > 59.999) { // Si tengo que agregarle tiempo a  _minutos
            _segundosD = 0; // Si es mayor a 59.999 se considera 1 seg más
            _minutos += 1; // no puedo tener mas de un minuto para agregarle no??
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
            Console.WriteLine( $"{_horas} horas, {_minutos} minutos y {_segundosD:0.000} segundos" ); // _segundosD:0.000 => imprime 3 digitos decimales
        }
        Console.WriteLine("\n");
    }
}

/*  PARA QUE ME DIJO JUANI Q HAGA ESTO?? --> PREGUNTARLE
    public Hora(double segundos){
        _segundosD = segundos;
    }
*/
