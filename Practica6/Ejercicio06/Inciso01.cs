class A
{
public string M1()
=> "A.M1";
}
class B : A
{
public override string M1()
=> "B.M1";
}


/*
  La clase B intenta invalidar un metodo de su clase base pero en la clase base no se declaro la palabra clave virtual
*/
