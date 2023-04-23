abstract class A
{
    public int Prop {set; get;}
}


class B : A
{
    public override int Prop {
    get => 5;
    set {}
    }
}

/*
    El error esta en que una propiedad no se puede invalidar. Para hacerlo, hace falta usar la palabra clave virtual en el encabezado de la declaracion de la propiedad.
*/
