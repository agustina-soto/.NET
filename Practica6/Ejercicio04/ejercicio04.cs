/*
¿Por qué no es necesario agregar :base en el constructor de Taxi?
Eliminar el segundo constructor de la clase Auto y modificar la clase Taxi para el programa siga funcionando
*/

Taxi t = new Taxi(3);
Console.WriteLine($"Un {Taxi.Marca} con {t.Pasajeros} pasajeros");

class Auto
{
    public static string Marca { get; private set; } = "Ford";
    public Auto(string marca) => Marca = marca;
}

class Taxi : Auto
{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) : base (Marca) => this.Pasajeros = pasajeros;
}

/*
    No es necesario agregar :base en el constructor de Taxi porque dentro de la clase Auto esta definido el constructor nulo.
    Cuando se ejecuta el constructor de Taxi se debe ejecutar un constructor de la clase base; como no esta explicito cual,
    por defecto se ejecuta el vacio (en caso de que este definido, si no lo esta tira error de compilacion).
*/
