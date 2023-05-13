namespace tp7;

class Libro : IAlquilable, IReciblable {

    public Libro(){
        
    }

    public void SeAlquilaA(Persona p) => Console.WriteLine("Alquilando libro a persona");

    public void DevueltoPor(Persona p) => Console.WriteLine("Libro devuelto por persona");

    public void Reciclando() => Console.WriteLine("Reciclando libro");
}
