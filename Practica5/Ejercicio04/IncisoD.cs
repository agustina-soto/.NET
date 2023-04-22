class A {
    static int s_a = 0;
    int a = 0;
    static A() {
        s_a = 30;
    }
    A(int a) {
        s_a = a;
        this.a = a;
    }
}

/*
    La declaracion de la clase A es correcta.
    ADVERTENCIA: El constructor de instancia (al no tener explicito el modificador de acceso)
    es private, por lo que no se van a poder instanciar objetos fuera de a clase.
*/
