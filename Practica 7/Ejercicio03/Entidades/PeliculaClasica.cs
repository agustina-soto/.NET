namespace tp7;

class PeliculaClasica : Pelicula , IAlquilable, IVendible {

    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo película clásica a persona");

}
