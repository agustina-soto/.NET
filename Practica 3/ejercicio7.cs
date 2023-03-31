// ¿De qué tipo quedan definidas las variables x, y, z en el siguiente código?

int i = 10;
var x = i * 1.0;
var y = 1f;
var z = i * y;

Console.WriteLine(i.GetType()); // System.Int32
Console.WriteLine(x.GetType()); // System.Double
Console.WriteLine(y.GetType()); // System.Single
Console.WriteLine(z.GetType()); // System.Single
