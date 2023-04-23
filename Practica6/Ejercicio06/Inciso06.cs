class A
{
public static virtual string M1()
=> "A.M1";
}
class B : A
{
public static override string M1()
=> "B.M1";
}

/*
El error esta en que se marca un método estático como virtual, lo que provoca error de compilación.
El codigo corregido:

class A
{
    public static string M1()
    => "A.M1";
}
class B : A
{
    new public static string M1() // los metodos static no pueden invalidarse, solo ocultarse
    => "B.M1";
}

*/
