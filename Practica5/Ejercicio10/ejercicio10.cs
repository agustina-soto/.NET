// v.i. = campo

class A
{
    private static int a; // v.i. estatica privada de tipo entera
    private static readonly int b; // v.i. estatica privada de solo lectura de tipo entera

    A() { } // Constructor nulo de instancia privado
    public A(int i) : this() { } // Sobrecarga del constructor de la clase. Este constructor de instancia publico llama al nulo
    static A() => b = 2; // Constructor estatico privado

    int c; // v.i. privada de tipo entera

    public static void A1() => a = 1; // Metodo estatico publico sin retorno

    public int A1(int a) => A.a + a; // Metodo de instancia publico que retorna un entero

    public static int A2; // v.i. estatica publica de tipo entera

    static int A3 => 3; // Propiedad estatica privada de solo lectura

    private int A4() => 4; // Metodo de instancia privado que retorna un entero

    public int A5 { get => 5; } // Propiedad publica auto-implementada de solo lectura de tipo entera

    int A6 { set => c = value; } // Propiedad privada de solo escritura de tipo entera

    public int A7 { get; set; } // Propiedad auto-implementada publica de lectura/escritura de tipo entera

    public int A8 { get; } = 8; // Propiedad auto-implementada publica de solo lectura de tipo entera

    public int this[int i] => i; // Indizador publico de tipo entero

}
