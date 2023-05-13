namespace tp7;

class Auto : IVendible, ILavable, IReciblable, IImportante, IComercial {

    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo auto a persona");

    public void Lavando() => Console.WriteLine("Lavando auto");

    public void Secando() => Console.WriteLine("Secando auto");

    public void Reciclando() => Console.WriteLine("Reciclando auto");

    public void Importa() => Console.WriteLine("Método Importar() de la clase Auto");

    void IImportante.Importa() => Console.WriteLine("Auto importante"); // La implementación explícita de un método de interfaz no lleva el public!!

    void IComercial.Importa() => Console.WriteLine("Auto que se vende al exterior"); // La implementación explícita de un método de interfaz no lleva el public!!
}
