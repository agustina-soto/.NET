/* Implementar un método que devuelva un arreglo de arreglos con los mismos elementos
que la matriz pasada como parámetro: double[][] GetArregloDeArreglo(double [,] matriz) */

using System;

// Devuelve un arreglo de arreglos con los mismos elementos que la matriz pasada como parametro
double[][] GetArregloDeArreglo(double [,] matriz){

    // Crea el arreglo de arreglos de dimension[filasMatriz][columnasMatriz]
    double [][] arreglo = new double[matriz.GetLength(0)][]; // La inicializacion es "de a uno", el segundo [] se llena con un for

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        arreglo[i] = new double[matriz.GetLength(1)]; // En arreglo[i] queda otro arreglo de matriz.GetLength(1) elementos (incluyendo al arreglo donde se lo crea)
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            arreglo[i][j] = matriz[i,j];
        }
    }
    return arreglo;
}

// Declara, crea y carga una matriz de double
double[,] matriz = new double[,]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8}
};

double[][] arreglo = GetArregloDeArreglo(matriz);

// Imprime los elementos de un arreglo de arreglos de double
for (int i = 0; i < matriz.GetLength(0); i++){ // i representa la cantidad de filas
    for (int j = 0; j < matriz.GetLength(1); j++){ // j representa la cantidad de columnas
        Console.Write(arreglo[i][j] + " | ");
    }
    Console.WriteLine("\n");
}

Console.ReadLine();
