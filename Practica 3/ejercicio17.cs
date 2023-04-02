/*
Implementar un programa calculadora que calcule una expresión ingresada por el usuario
correspondiente a una operación binaria de las cuatro elementales (ejemplo “44.5/456”,
“456*45”, “549-12”, “54+6” ). Utilizar try/catch para validar los números y controlar
cualquier tipo de excepción que pudiese ocurrir en la evaluación de la expresión.
*/

// Calcula una expresion traida como parametro
float calculadora(string op, float num1, float num2){
    float res = 0;
    switch (op)
    {
        case "+": res = num1 + num2;
                              break; // Es necesario ponerle break a todos los case?? o cada vez que entra a uno ya no entra al resto?
        case "-": res = num1 - num2;
                              break;
        case "*": res = num1 * num2;
                              break;
        case "/": res = num1 / num2;
                              break;
        default: throw new Exception("No se ingreso una operacion valida");
    }
    return res;
}

// Valida los numeros y la operacion a realizar. Si el resultado es infinito tira una excepcion
void validarNumeros(string op, string st1, string st2, out float res){
    try
    {
        float num1 = float.Parse(st1);
        float num2 = float.Parse(st2);
        res = calculadora(op, num1, num2);
        if ( (res > float.MaxValue) || (res < float.MinValue) ) throw new Exception("El resultado de la operacion es infinito"); 
    }
    catch
    {
        throw;
    }
}

// Evalua una expresion traida por parametro y controla las posibles excepciones
void evaluarExpresion(string op, string st1, string st2){
    checked
    {
        try
        {
            validarNumeros(op, st1, st2, out float res);
            // Si llega hasta aca es porque no hubo ningun problema (excepcion)
            Console.WriteLine($"Resultado de la expresion {st1}{op}{st2} = {res}");
        }
        catch (FormatException) // Para cuando no se ingresa algun numero por ejemplo
        {
            Console.WriteLine("Format Exception");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow Exception");
        }
        catch (NullReferenceException) // podria tener una null exception aca??
        {
            Console.WriteLine("Null Reference Exception");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

Console.WriteLine("Ingrese una operacion binaria: + (suma) | - (resta) | * (multiplicacion) | / (division)");
string operacion = Console.ReadLine();

Console.WriteLine("Ingrese un numero con el que operar");
string numSt1 = Console.ReadLine();
Console.WriteLine("Ingrese el otro numero");
string numSt2 = Console.ReadLine();

evaluarExpresion(operacion, numSt1, numSt2);

Console.ReadLine();
