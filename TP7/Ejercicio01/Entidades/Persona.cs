namespace tp7;

class Persona : IAtendible, IImportante, IComercial{

    public Persona(){
    }

    public void SeAtiendeA() => Console.WriteLine("Atendiendo a persona");

    public void Importar() => Console.WriteLine("Método Importar() de la clase Persona");
    
    // NO FUNCIONA, TENGO PROBLEMAS CON LAS NUEVAS INTERFACES
}
