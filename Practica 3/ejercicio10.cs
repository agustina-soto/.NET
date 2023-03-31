/* 10. Verificar con un par de ejemplos si la sección opcional [:formatString] de formatos compuestos
redondea o trunca cuando se formatean números reales restringiendo la cantidad de decimales.
Plantear los ejemplos con cadenas de formato compuesto y con cadenas interpoladas. */

using System;

String formatear(float num, String formato){
    return $"{num.ToString(formato)}";
}

float num = 3.149f;
String formato = "0.00";
Console.WriteLine(formatear(num, formato)); // Imprime 3,15 --> Redondea
Console.ReadLine();
