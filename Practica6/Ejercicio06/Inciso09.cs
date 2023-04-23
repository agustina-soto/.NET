class A
{
    private int _id; // puede acceder A
    protected A(int i) => _id = i; // puede acceder A y sus subclases
}
class B : A
{
    B(int i):base(5) { // constructor
    _id=i;
    }
}

/*
    El error esta en que se intenta acceder a la variable de instancia _id de la clase base cuando se declaro con el modificador de acceso privado (es decir: solo se la puede acceder desde la propia clase)
*/
