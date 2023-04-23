class A
{
public override string M1()
=> "A.M1";
}
class B : A
{
public override string M1()
=> "B.M1";
}

/*
  El error esta en que el metodo M1 de la clase A intenta hacer override (invalidar) otro metodo string pero no existe tal metodo.
*/
