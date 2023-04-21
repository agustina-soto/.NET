class A {
    static int s_a = 0;
    static A(int a) {
        s_a=a;
    }
    A(int a) {
        s_a = a;
    }
}

/*
    La declaracion de la clase A es incorrecta. Un constructor estatico no puede tener parametros.
    ADVERTENCIA: El constructor de instancia no tiene un modificador de acceso declarado, por lo
    que se le asignará "private"; con lo cual no se podrán instanciar objetos de la clase A fuera de la misma.
*/
