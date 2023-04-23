class A
{
    protected A(int i) { }
}
class B : A
{
    B() { }
}

/*
    El error esta en que al instanciar B no se invoca al constructor de A ni se recibe el parametro que necesita ese constructor.
    Advertencia: Solo pueden instanciar A desde dentro de A o desde sus clases derivadas.
*/
