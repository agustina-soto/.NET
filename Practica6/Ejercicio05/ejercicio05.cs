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
    Los errores de compilacion se deben a que se declaró el metodo GetPrimerDueño() como publico y la propiedad SegundoDueño como protected, y se espera que
    devuelva y setee un tipo Persona. Eso genera problemas porque la clase Persona es de tipo internal. Esto significa que hay incoherencia de accesibilidad
    porque el metodo es más accesible que el tipo que quiere devolver y la propiedad es menos accesible que el tipo que quiere setear. 
*/



/*
class Persona
{
    public string Nombre { get; set; }
}

public class Auto
{
    private Persona _dueño1, _dueño2;
    public Persona GetPrimerDueño() => _dueño1; // La clase Auto es publica por ende si existe la posibilidad de que se quiera acceder a esta propiedad desde afuera 
                                                de la misma, pero la clase Persona es privada, es decir,  se intentaría devolver un objeto que es privado en una clase
                                                que es pública.
                                                #El tipo de valor devuelto 'Persona' es menos accesible que el método  'Auto.GetPrimerDueño()'
    
    protected Persona SegundoDueño // Se quiere declarar una apropiedad que settee sobre un objeto de la clase Perona que es privada por ende fuera de la clase 
                                     Auto no es visible, en otras palabras hay una incosistencia en los modificadores de acceso.
                                     #El tipo de propiedad 'Persona' es menos accesible que la propiedad  'Auto.SegundoDueño'
        set => _dueño2 = value;
    }
}

*/
