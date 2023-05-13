namespace tp7;

class Persona : IAtendible, IImportante, IComercial {

    public void SeAtiendeA() => Console.WriteLine("Atendiendo a persona");

    public void Importa() => Console.WriteLine("Método Importar() de la clase Persona");
    
    void IImportante.Importa() => Console.WriteLine("Persona importante"); // La implementación explícita de un método de interfaz no lleva el public!!

    void IComercial.Importa() => Console.WriteLine("Persona vendiendo al exterior"); // La implementación explícita de un método de interfaz no lleva el public!!

}
