class A {
    static readonly List<int> _lista;
    static A() {
        _lista = new List<int>();
    }
    public static void P(int i) {
        _lista.Add(i);
    }
}

/*
    La declaracion de la clase A es correcta. La inicializacion dle readonly se hace dentro de un constructor.
*/
