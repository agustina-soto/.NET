/* Utilizar la clase Stack<T> (pila) para implementar un programa que pase un número en base 10
   a otra base realizando divisiones sucesivas.
   
   Por ejemplo para pasar 35 en base 10 a binario dividimos sucesivamente por dos hasta
   encontrar un cociente menor que el divisor, luego el resultado se obtiene leyendo de
   abajo hacia arriba el cociente de la última división seguida por todos los restos. */

using System;

// Apila el resto de una division sucesiva hasta encontrar un cociente menor que el divisor
void apilar(Stack<int> pila, int nueva_base, int num){
    int resto;
    while (num >= nueva_base) // Divide hasta que el resultado de la division sea menor que la base
    {
        resto = num%nueva_base;
        pila.Push(resto);
        num = num/nueva_base;
        // Console.WriteLine($"nro pusheado: {num}");
    }
    pila.Push(num); /* Popea el cociente de la ultima division. El resultado se obtiene leyendo de abajo
                       hacia arriba el cociente de la última división seguida por todos los restos. */
    // Console.WriteLine($"nro pusheado: {num}");
}

// Devuelve un numero traido por parametro convertido en una base traida por parametro
int convertirABase(int nueva_base, int num){
    string res = "";
    Stack<int> pila = new Stack<int>();
    apilar(pila, nueva_base, num);
    while (pila.Count != 0){
       res += pila.Pop();
    }
    return Int32.Parse(res); // Convierte el string con el nro convertido en un int32
}

int num = 35, nueva_base = 2;
int numConvertido = convertirABase(nueva_base, num);

Console.WriteLine($"Numero {num} en base {nueva_base} = {numConvertido}");

Console.ReadLine();
