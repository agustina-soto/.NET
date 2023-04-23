// ¿Por qué no funciona el siguiente código? ¿Cómo se puede solucionar fácilmente?

class Auto
{
    protected double velocidad;
    public virtual void Acelerar() => Console.WriteLine("Velocidad = {0}", velocidad += 10);
}


class Taxi : Auto
{
    public override void Acelerar() => Console.WriteLine("Velocidad = {0}", velocidad += 5);
}

/*
    El codigo no funcionaba porque la variable de instancia velocidad estaba declarada como private en la clase base.
    Ese modificador de acceso solo permite el acceso de la variable dentro de la misma clase, sin tener en cuenta las
    clases derivadas de la misma. Se soluciona facilmente declarando la variable velocidad como protected. 
*/
