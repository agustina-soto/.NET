/* Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que devuelven
un vector con la diagonal correspondiente de la matriz pasada como parámetro.
Si la matriz no es cuadrada generar una excepción ArgumentException. */

using System;

// Devuelve un vector con la diagonal principal de una matriz recibida como parametro
double[] GetDiagonalPrincipal(double[,] matriz){
    double[] vector = new double[matriz.GetLength(0)];
    
    for (int i = 0; i < matriz.GetLength(0); i++){
            vector[i] = matriz[i, i];
    }
    return vector;
}

// Devuelve un vector con la diagonal secundaria de una matriz recibida como parametro
double[] GetDiagonalSecundaria(double[,] matriz){
    double[] vector = new double[matriz.GetLength(0)];
    int columnas = matriz.GetLength(1) -1; // Variable auxiliar para no hacer 2 for anidados
    for (int i = 0; i < matriz.GetLength(0) ; i++){ // Recorre filas
        vector[i] = matriz[i, columnas - i]; // columnas siempre es = 3
                                                // 0,3
                                                // 1,2
                                                // 2,1
    }
    return vector;
}

// Devuelve si una matriz es cuadrada
bool esCuadrada(double[,] matriz) => matriz.GetLength(0) == matriz.GetLength(1);

// Imprime los elementos de un vector de double
void mostrarVector(double[] vector){
    for (int i = 0; i < vector.Length; i++){
        Console.Write(vector[i] + " | ");
    }
}

// Declara, crea y carga una matriz de double
double [,] matriz = new double [,]
{
                                    // {0, 0, 0, 0}, // Para chequear si maneja bien la excepcion
                                    {1, 2, 3, 4},
                                    {5, 6, 7, 8},
                                    {9, 10, 11, 12},
                                    {13, 14, 15, 16},
};


try{
    if (esCuadrada(matriz)){
        double[] vectorDiagonalPrincipal = GetDiagonalPrincipal(matriz);
        double[] vectorDiagonalSecundaria = GetDiagonalSecundaria(matriz);
        Console.WriteLine("Mostrando diagonal pincipal");
        mostrarVector(vectorDiagonalPrincipal);
        Console.WriteLine("\nMostrando diagonal secundaria");
        mostrarVector(vectorDiagonalSecundaria);
    }
    else throw new ArgumentException("La matriz no es cuadrada");
}
catch (ArgumentException e){
    Console.WriteLine(e.Message);
}

Console.ReadLine();
