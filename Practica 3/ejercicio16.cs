/* Implementar un programa que permita al usuario ingresar números por la consola. Debe
ingresarse un número por línea finalizando el proceso cuando el usuario ingresa una línea vacía.
A medida que se van ingresando los valores el sistema debe mostrar por la consola la suma
acumulada de los mismos. Utilizar la instrucción try/catch para validar que la entrada
ingresada sea un número válido, en caso contrario advertir con un mensaje al usuario y
proseguir con el ingreso de datos. */

using System;

int num, suma = 0;
string car;
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Ingrese un numero entero o enter para finalizar");
    car = Console.ReadLine();
    try
    {
        if (string.IsNullOrWhiteSpace(car))
        {
            Console.WriteLine("Proceso finalizado");
            continuar = false;
        }
        else // si lo ingresado por teclado no fue un enter o espacios en blanco
        {
            num = Int32.Parse(car); // Intenta convertir el numero; si no se puede tira una excepcion
            suma += num;
            Console.WriteLine($"Suma de los nros ingresados hasta ahora: {suma}");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Debe ingresar numeros enteros");
    }
}
