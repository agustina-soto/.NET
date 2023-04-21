class A
{
    static int[] vector = { 1, 2, 3 };
    public static int this[int i]
    {
       get { return vector[i]; }
    }
}

/*
    La declaracion de la clase A esincorrecta. Un indizador no puede ser estatico.
*/
