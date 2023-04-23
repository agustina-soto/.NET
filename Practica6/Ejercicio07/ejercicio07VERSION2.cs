// Ofrecer una implementación polimórfica para mejorar el siguiente programa:

Imprimidor.Imprimir(new A(), new B(), new C(), new D());


class X {
    protected char _letra;

    public char Letra
    {
        get => _letra;
        protected set => _letra = value; // Solo pueden cambiar el valor de _letra dentro de la clase X o de sus derivadas
    }
    
    public X (char letra){
        Letra = letra;
    }

    public void Imprimir() => Console.WriteLine($"Soy una instancia {Letra}");
}

class A : X {

    public A () : base('A') {

    }
}


class B : X {
    public B () : base('B') {

    }

}


class C : X {
    public C () : base('C') {

    }
}


class D : X {
    public D () : base('D') {

    }
}


static class Imprimidor {
    public static void Imprimir(params object[] vector) {
        foreach (X letra in vector) {
            letra.Imprimir();
        }
    }
}
