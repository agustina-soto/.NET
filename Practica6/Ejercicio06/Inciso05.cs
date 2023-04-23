class A
{
public virtual string M1()
=> "A.M1";
}
class B : A
{
protected override string M1()
=> "B.M1";
}

/*
  El error esta en que la clase B intenta sobreescribir el metodo M1 de la clase base cambiandole el modificador de acceso.
*/
