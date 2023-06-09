namespace tp7;

class PeliculaClasica : Pelicula, IVendible {

    public PeliculaClasica() : base() { }

    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo película clásica a persona");
    public override void SeAlquilaA(Persona p) => Console.WriteLine("Alquilando pelicula clasica a persona");
    public override void DevueltoPor(Persona p) => Console.WriteLine("Pelicula clasica devuelta por persona");

}
