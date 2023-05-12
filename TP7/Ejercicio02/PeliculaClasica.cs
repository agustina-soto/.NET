namespace ejercicio01;

class PeliculaClasica : Pelicula , IAlquilable, IVendible {

    public PeliculaClasica() : base() { }

    public void SeVendeA(Persona p) => Console.WriteLine("");

}
