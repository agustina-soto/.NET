/*
13. Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están
bien balanceados. Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena
de entrada. Utilizar una pila para resolverlo. Los paréntesis de apertura de la entrada se
almacenan en una pila hasta encontrar uno de cierre, realizándose entonces la extracción del
último paréntesis de apertura almacenado. Si durante el proceso se lee un paréntesis de cierre y
la pila está vacía, entonces la cadena es incorrecta. Al finalizar el análisis, la pila debe quedar
vacía para que la cadena leída sea aceptada, de lo contrario la misma no es válida.
*/
using System; using System.Collections.Generic;

bool estaBalanceada(string exp, Stack<char> pila){
    bool ok = true;
    for (int i = 0; i < exp.Length; i++)
    {
        if (exp[i] == '(') // Si encontro un parentesis de apertura
        {
            pila.Push(exp[i]); // Pushear en la pila
        }
        else if (exp[i] == ')') // Si encontro un parentesis de cierre
        {
            if (pila.Count > 0){
                pila.Pop(); // Popear de la pila
            }
            else{
                ok = false;
            }
        }
    }
    return ok;
}


string exp = "(((()))";
Stack<char> pila = new Stack<char>();

if ( (estaBalanceada(exp, pila)) && (pila.Count == 0) )
    {
        Console.Write("La expresion aritmetica esta balanceada");
    }
else
    {
        Console.WriteLine("La cadena no es valida");
    }
