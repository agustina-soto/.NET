class A
{
    static int s_a = 1;
    int a = 0;
    static A() => s_a += s_a; // Constructor
    public static A GetInstancia() => new A(1); // Devuelve una instancia de la clase
    A(int a) => this.a = a + s_a;
}

/*
    La declaracion de la clase A es correcta.
*/
