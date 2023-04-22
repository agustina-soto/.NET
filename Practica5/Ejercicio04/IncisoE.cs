class A {
    static int s_a = 0;
    int a = 0;
    static A() {
        a = 30;
    }
    A(int a) {
        a = s_a;
    }
}

/*
    La declaracion de la clase A es incorrecta. En cuanto a tiempos, lo primero que se inicializa es la variable estática
    seguido por el constructor estático y luego lo demás; por ende no se puede asignar el valor "30" a la variable de
    instancia "a" porque en ese momento la variable todavia no existe.
*/
