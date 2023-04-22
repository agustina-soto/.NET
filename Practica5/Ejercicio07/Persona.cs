/*
Definir un indizador de
lectura/escritura que permita acceder a las propiedades a través de un índice entero. Así, si p es un
objeto Persona, con p[0] se accede al nombre, p[1] al sexo p[2] al DNI, p[3] a la fecha de
nacimiento y p[4] a la edad. En caso de asignar p[4] simplemente el valor es descartado. Observar
que el tipo del indizador debe ser capaz almacenar valores de tipo int, char, DateTime y string.
*/

namespace ejercicio07;

class Persona{
    private string? _nombre;
    private char _sexo;
    private int _DNI;
    private DateTime _fechaNacimiento;

    public string? Nombre {
        get => _nombre;
        set => _nombre = value;
    }
    
    public char Sexo {
        get => _sexo;
        set => _sexo = value;
    }

    public int DNI {
        get => _DNI;
        set => _DNI = value;
    }
    
    public DateTime FechaNacimiento {
        get => _fechaNacimiento;
        set => _fechaNacimiento = value;
    }
    
    public int Edad => DateTime.Now.Year - this._fechaNacimiento.Year; // PROPIEDAD DE SOLO LECTURA

    public Object? this [int i] { // INDIZADOR
        get {
            switch (i)
            {
                case 0 : return _nombre;
                case 1 : return _sexo;
                case 2 : return _DNI;
                case 3 : return _fechaNacimiento.ToShortDateString();
                case 4 : return Edad;
                default: Console.WriteLine("Indizador no reconocido"); 
                        return null;
            }
        }
        set {
            switch (i)
            {
                case 0: _nombre = (string?) value;
                break;
                case 1: _sexo = (char) value;
                break; 
                case 2: _DNI = (int) value;
                break;
                case 3: _fechaNacimiento = (DateTime) value;
                break;                
                case 4:
                break;
                default: Console.WriteLine("Indizador no reconocido");
                break;
            }
        }
    }

}
