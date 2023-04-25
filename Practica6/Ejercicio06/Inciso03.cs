abstract class A
{
public abstract string M1()
=> "A.M1";
}
class B : A
{
public override string M1()
=> "B.M1";
}

/*
  El error esta en que el metodo abstracto M1 declara un cuerpo. Por definicion los metodos abstractos no tienen implementacion
*/
