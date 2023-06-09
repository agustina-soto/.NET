namespace ejercicio05;

static class VectorDeEnterosExtension
{
    public static void Print(this int[] vector, string leyenda)
    {
        string st = leyenda;
        if (vector.Length > 0)
        {
            foreach (int n in vector) st += n + ", ";
            st = st.Substring(0, st.Length - 2);
        }
        Console.WriteLine(st);
    }

    public static int[] Seleccionar(this int[] vector, FuncionEntera f)
    {
        int[] v = new int[vector.Length];

        for (int i = 0; i < v.Length; i++)
        {
            v[i] = f(vector[i]);
        }
        return v;
    }

    public static int[] Donde(this int[] vector, Predicado p){
        int[] v = new int[vector.Length]; // Vector donde se almacenan los elementos que cumplen con el Predicado
        int pos = -1; // El vector no tiene elementos
        for (int i = 0; i < vector.Length; i++)
        {
            if ( p ( vector[i]) ) { // Si el elemento actual del vector cumple la condicion
                v[++pos] = vector[i]; // Se agrega al vector nuevo
            }
        }
        return v;
    }
}
