/*
Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices
pasadas como parámetros. Para el caso de la suma y la resta, las matrices deben ser del mismo
tamaño, en caso de no serlo devolver null. Para el caso de la multiplicación la cantidad de
columnas de A debe ser igual a la cantidad de filas de B, en caso contrario generar una
excepción ArgumentException.
*/

using System;

// Devuelve si dos matrices pasadas como parametros son del mismo tamaño
bool compartenTamanio(double[,]matrizA, double[,]matrizB) => (matrizA.GetLength(0) == matrizB.GetLength(0)) && (matrizA.GetLength(1) == matrizB.GetLength(1));

// Devuelve si la cantidad de columnas de A debe ser igual a la cantidad de filas de B
bool cantFilasIgualColumnas(double[,]matrizA, double[,]matrizB) => matrizA.GetLength(0) == matrizB.GetLength(1);


// Devuelve la suma de matrices pasadas como parámetros si son del mismo tamaño, sino devuelve null
double[,]? Suma(double[,] A, double[,] B){
    
    if(compartenTamanio(A, B)){

        // Crea matriz en la que se guarda la suma de matrices
        double[,] sumaMatrices = new double[A.GetLength(0),A.GetLength(1)];    
        
        for (int i = 0; i < A.GetLength(0); i++){
            for (int j = 0; j < A.GetLength(1); j++){
                sumaMatrices[i,j] = A[i,j] + B[i,j];
            }
        }
        return sumaMatrices;
    }
    
    else return null;
}

// Devuelve la resta de matrices pasadas como parámetros si son del mismo tamaño, sino devuelve null
double[,]? Resta(double[,] A, double[,] B){
    if(compartenTamanio(A, B)){

        // Crea matriz en la que se guarda la resta de matrices
        double[,] restaMatrices = new double[A.GetLength(0),A.GetLength(1)];    

        for (int i = 0; i < A.GetLength(0); i++){
            for (int j = 0; j < A.GetLength(1); j++){
                restaMatrices[i,j] = A[i,j] - B[i,j];
            }
        }
        return restaMatrices;
    }

    else return null;
}

// Devuelve la multiplicacion de matrices pasadas como parámetros si son cuadradas, sino devuelve null
double[,] Multiplicacion(double[,] A, double[,] B){
    
    int filas = (A.GetLength(0) > B.GetLength(0)) ? A.GetLength(0) : B.GetLength(0);
    int columnas = (A.GetLength(1) > B.GetLength(1)) ? A.GetLength(1) : B.GetLength(1);

    // Crea matriz en la que se guarda la multiplicacion de matrices
    double[,] multiplicacion = new double[filas, columnas];

    try{
        if (cantFilasIgualColumnas(A, B)){
            for (int i = 0; i < filas; i++){
                for (int j = 0; j < columnas; j++){
                    multiplicacion[i,j] = A[i,j] * B[i,j];
                }
            }
            return multiplicacion;
        }
        else throw new ArgumentException("La cantidad de columnas de A no es igual a la cantidad de filas de B");
    }
    catch (ArgumentException e){
        Console.WriteLine(e.Message);
        return multiplicacion;
    }
}

// Imprime el contenido de una matriz de double
void imprimirMatriz (double[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++){
        for (int j = 0; j < matriz.GetLength(1); j++){
            Console.Write($"{matriz[i,j]:0.00}  ");
        }
        Console.WriteLine();
    }
}


double[,] matrizA = new double[,]{ {1, 1, 1}, {2, 2, 2}, {3, 3, 3}};
double[,] matrizB = new double[,]{ {9, 9, 9}, {8, 8, 8}, {7, 7, 7}};
double[,] matrizAux = new double[,]{ {1, 2, 3} ,{4, 5, 6}}; // Aux para chequear que retorne bien cuando las matrices no son del mismo tamaño

double[,] suma = Suma(matrizA, matrizB);
double[,] resta = Resta(matrizA, matrizB);
double[,] mul = Multiplicacion(matrizA, matrizB);

Console.WriteLine("MATRIZ A");
Console.WriteLine("------------------------------------");
imprimirMatriz(matrizA);
Console.WriteLine("------------------------------------");

Console.WriteLine("MATRIZ B");
Console.WriteLine("------------------------------------");
imprimirMatriz(matrizB);
Console.WriteLine("------------------------------------");

Console.WriteLine("----- OPERACIONES -----");

Console.WriteLine("SUMA");
Console.WriteLine("------------------------------------");
imprimirMatriz(suma);
Console.WriteLine("------------------------------------");

Console.WriteLine("RESTA");
Console.WriteLine("------------------------------------");
imprimirMatriz(resta);
Console.WriteLine("------------------------------------");

Console.WriteLine("MULTIPLICACION");
Console.WriteLine("------------------------------------");
imprimirMatriz(mul);
Console.WriteLine("------------------------------------");

Console.ReadLine();
