/*
1) Definir una clase Persona con 3 campos públicos: Nombre, Edad y DNI.

Escribir un algoritmo que permita al usuario ingresar en una consola una
serie de datos de la forma Nombre,Documento,Edad<ENTER>.

Una vez finalizada la entrada de datos, el programa debe imprimir en la
consola un listado con 4 columnas de la siguiente forma:
Nro) Nombre Edad DNI.

Ejemplo de listado por consola:
    1) Juan Perez 40 2098745
    2) José García 41 1965412
*/

using System;
using ejercicio1;

Console.SetIn(new System.IO.StreamReader("personas.txt")); // Redirecciona la entrada estandar de la consola con la entrada del archivo de texto


String linea;
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
  
        // Imprime lo guardado en Persona
        Console.WriteLine(p.toString());

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


Console.ReadLine();
