// ¿Qué líneas del siguiente código provocan error de compilación y por qué?

class Persona
{
    public string Nombre { get; set; }
}


public class Auto
{
    private Persona _dueño1, _dueño2;
    public Persona GetPrimerDueño() => _dueño1;
    protected Persona SegundoDueño
    {
        set => _dueño2 = value;
    }
}

/*
    Los errores de compilacion se deben a que se declaró el metodo GetPrimerDueño() como publico y la propiedad SegundoDueño como protected, y se espera que devuelva y setee un tipo Persona.
    Eso genera problemas porque la clase Persona es de tipo internal. Esto significa que hay incoherencia de accesibilidad porque
    el metodo es más accesible que el tipo que quiere devolver y la propiedad es menos accesible que el tipo que quiere setear. 
*/
