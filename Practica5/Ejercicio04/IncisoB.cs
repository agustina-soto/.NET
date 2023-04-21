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
    Además, el constructor de instancia no tiene un modificador de acceso declarado, por lo que se le asignará "private";
    con lo cual no se podrán instanciar objetos de la clase A fuera de la misma.
*/
