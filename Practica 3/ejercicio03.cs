/*
Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora con un
parámetro más que representa la plantilla de formato que debe aplicarse a los números al
imprimirse. La plantilla de formato es un string de acuerdo a las convenciones de formato
compuesto, por ejemplo “0.0” implica escribir los valores reales con un dígito para la parte
decimal.
*/
using System;

void ImprimirMatrizConFormato(double[,] matriz, string formatString){
    for (int i = 0; i < matriz.GetLength(0); i++){
        for (int j = 0; j < matriz.GetLength(1); j++){
            Console.WriteLine($"{matriz[i,j].ToString(formatString)}");
        }
    }
}

double [,] matriz = new double[,]
{
    {1.02, 2.3 , 3, 4},
    {5, 6, 7, 8.5},
    {9.57, 10.697, 11, 12}
};

string formato = "0.00";
ImprimirMatrizConFormato(matriz, formato);
Console.ReadLine();
