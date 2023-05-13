namespace ejercicio01;

class Pelicula : IAlquilable {

    public Pelicula(){
        
    }

    public void SeAlquilaA(Persona p) => Console.WriteLine("Alquilando pelicula a persona");
    public void DevueltoPor(Persona p) => Console.WriteLine("Pelicula devuelta por persona");
}
