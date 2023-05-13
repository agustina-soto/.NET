using tp7;

Auto auto = new Auto();
Libro libro = new Libro();
Persona persona = new Persona();
Perro perro = new Perro();
Pelicula pelicula = new Pelicula();

Procesador.Alquilar(pelicula, persona);
Procesador.Alquilar(libro, persona);

Procesador.Atender(persona);
Procesador.Atender(perro);

Procesador.Devolever(pelicula, persona);
Procesador.Devolever(libro, persona);

Procesador.Lavar(auto);

Procesador.Reciclar(libro);
Procesador.Reciclar(auto);

Procesador.Secar(auto);

Procesador.Vender(auto, persona);
Procesador.Vender(perro, persona);

Procesador.Lavar(perro);

Procesador.Secar(perro);

PeliculaClasica peliculaClasica = new PeliculaClasica();
Procesador.Alquilar(peliculaClasica, persona);
Procesador.Devolever(peliculaClasica, persona);
Procesador.Vender(peliculaClasica, persona);


var lista = new List<object>() {

new Persona(),
new Auto()
};
foreach (IComercial c in lista)
{
c.Importa();
}
foreach (IImportante i in lista)
{
i.Importa();
}
(lista[0] as Persona)?.Importa();
(lista[1] as Auto)?.Importa();
