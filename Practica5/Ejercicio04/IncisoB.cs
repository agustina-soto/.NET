class A {
    static int s_a = 0;
    public static A() {
        s_a++;
    }
    A() {
        s_a++;
    }
}

/*
    La declaracion de la clase A es incorrecta. Los constructores estaticos no pueden tener modificadores de acceso.
    ADVERTENCIA: El constructor de instancia (al no tener explicito el modificador de acceso)
    es private, por lo que no se van a poder instanciar objetos fuera de a clase.
*/
