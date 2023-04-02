/*
  ¿Qué salida por la consola produce el siguiente código? INFINITO
  ¿Qué se puede inferir respecto de la excepción división por cero en relación al tipo de los operandos?
  - LA DIVISION POR CERO EN ENTEROS SIEMPRE VA A DAR UNA EXCEPCION.
  - EN LOS REALES (AL SER INFINITOS DE POR SI) EL RESULTADO DE DIVIDIR POR CERO TIENE QUE SER INFINITO.
*/

int x = 0;
try
{
    Console.WriteLine(1.0 / x);
    Console.WriteLine(1 / x);
    Console.WriteLine("todo OK");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
