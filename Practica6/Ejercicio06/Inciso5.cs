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

*/
