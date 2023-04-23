class A
{
    virtual string M1() => "A.M1";
}
class B : A
{
    override string M1() => "B.M1";
}

// El error esta en que el modificador virtual no se puede usar con el modificador private
