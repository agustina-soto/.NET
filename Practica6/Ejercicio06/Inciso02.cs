class A
{
public abstract string M1();
}
class B : A
{
public override string M1()
=> "B.M1";
}

/*
  El error esta en que se declara un metodo abstracto (M1) en una clase no abstracta (A)
*/
