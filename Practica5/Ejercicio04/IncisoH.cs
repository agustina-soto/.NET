class A
{
    static double PI = 3.1416;
    const double DoblePI = 2*PI;
}

/*
    La declaracion de la clase A es incorrecta. Las constantes se inicializan en tiempo de compilación, mientras que las
    variables lo hacen en tiempo de ejecución; por lo tanto no se les puede asignar una variable aunque la misma sea estática.
*/
