namespace ejercicio01;

class Perro : IVendible, IAtendible {

    public Perro(){
    }

    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo perro a persona");

    public void SeAtiendeA() => Console.WriteLine("Atendiendo a perro");

}
