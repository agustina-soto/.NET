/*
3) Agregar a la clase Persona un método EsMayorQue(Persona p) que devuelva verdadero
si la persona que recibe el mensaje tiene más edad que la persona enviada como parámetro.
Utilizarlo para realizar un programa que devuelva la persona más jóven de la lista.
*/

using System;
using ejercicio3;

String archivo_de_texto = @"C:\Users\agust\proyectosDotnet\tp4\personas.txt";
Console.SetIn(new System.IO.StreamReader(archivo_de_texto)); // Redirecciona la entrada estandar de la consola con la entrada del archivo de texto

String linea;
Persona personaMasJoven = new Persona(999); // Instancia una persona con edad 999

try
{
    linea = Console.ReadLine(); // Lee la primer linea del archivo de texto
    // Lee hasta que llega al final del archivo
    while (linea != null)
    {
        // Separa los strings usando como delimitador la coma y el salto de linea
        String [] datos = linea.Split(',' , '\n');

        // Variable auxiliar para posicionarse sobre el vector
        int pos = 0;

        // Instancia una Persona y le carga los datos leidos
        Persona p = new Persona();
        p.setNombre(datos[pos]);
        p.setEdad(Int32.Parse(datos[++pos])); // Puede tirar excepcion si no puede hacer la conversion
        p.setDNI(datos[++pos]);
  
        if (personaMasJoven.EsMayorQue(p)){
            personaMasJoven = p;
        }

        // Imprime lo guardado en Persona
        Console.WriteLine(p.Imprimir());

        // Lee la siguiente linea
        linea = Console.ReadLine();
    }
}
catch(FormatException)
{
    Console.WriteLine("No se pudo hacer la conversion de la edad");
}
catch(Exception e)
{
    Console.WriteLine("No se pudo leer el archivo");
}

if (personaMasJoven.getEdad() < 999) Console.WriteLine($"La persona mas joven es: {personaMasJoven.Imprimir()}");

Console.ReadLine();
