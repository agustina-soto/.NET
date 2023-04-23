abstract class A
{
    public abstract int Prop {set; get;}
}


class B : A
{
    public override int Prop
    {
        get => 5;
    }
}

/*
    El error esta en que falta implementar en la clase B el descriptor de acceso de escritura de la propiedad abstracta definida en A.
*/
