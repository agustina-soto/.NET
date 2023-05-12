namespace ejercicio01;

class Auto : IVendible, ILavable, IReciblable {

    public Auto(){
        
    }

    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo auto a persona");

    public void Lavando() => Console.WriteLine("Lavando auto");

    public void Secando() => Console.WriteLine("Secando auto");

    public void Reciclando() => Console.WriteLine("Reciclando auto");

}
