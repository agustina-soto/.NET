// Ofrecer una implementación polimórfica para mejorar el siguiente programa:

Imprimidor.Imprimir(new A(), new B(), new C(), new D());


abstract class X {
    public char Letra
    {
        get;
        protected set;
    }

    public abstract void Imprimir();
}

class A : X {

    public A () {
        Letra = 'A';
    }

    public override void Imprimir() => Console.WriteLine($"Soy una instancia {Letra}");

}


class B : X {
    public B () {
        Letra = 'B';
    }

    public override void Imprimir() => Console.WriteLine($"Soy una instancia {Letra}");

}


class C : X {
    public C () {
        Letra = 'C';
    }

    public override void Imprimir() => Console.WriteLine($"Soy una instancia {Letra}");
}


class D : X {
    public D () {
        Letra = 'D';
    }

    public override void Imprimir() => Console.WriteLine($"Soy una instancia {Letra}");
}


static class Imprimidor {
    public static void Imprimir(params object[] vector) {
        foreach (X letra in vector) {
            letra.Imprimir();
        }
    }
}
