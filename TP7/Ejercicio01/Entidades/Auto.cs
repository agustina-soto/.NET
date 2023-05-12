namespace tp7;

class Auto : IVendible, ILavable, IReciblable, IImportante, IComercial {

    public Auto(){
        
    }

    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo auto a persona");

    public void Lavando() => Console.WriteLine("Lavando auto");

    public void Secando() => Console.WriteLine("Secando auto");

    public void Reciclando() => Console.WriteLine("Reciclando auto");


    public void Importar() => Console.WriteLine("Método Importar() de la clase Auto");

}
