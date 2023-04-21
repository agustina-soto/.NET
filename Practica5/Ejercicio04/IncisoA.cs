class A {
    static int s_a=0;
    static A() {
        s_a++;
    }
    public A() {
        s_a++;
    }
}

/* La definicion de la clase A es correcta. Es posible tener un constructor estático
   y un constructor de instancia ambos sin parámetros definidos en la misma clase.
*/
