class A {
    static readonly List<int> _lista;
    static A() {
        _lista = new List<int>();
    }
    public static void P(List<int> li) {
        _lista = li;
    }
}

/*
    La declaracion de la clase A es incorrecta. Un campo readonly solo se puede asignar en constructores.
*/
