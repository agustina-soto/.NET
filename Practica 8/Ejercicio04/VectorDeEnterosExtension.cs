namespace ejercicio04;

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
}
