namespace tp7;

class Perro : IVendible, IAtendible, ILavable {

    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo perro a persona");

    public void SeAtiendeA() => Console.WriteLine("Atendiendo a perro");

    public void Lavando() => Console.WriteLine("Lavando perro");

    public void Secando() => Console.WriteLine("Secando perro");

}
