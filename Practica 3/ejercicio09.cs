/* Señalar errores de compilación y/o ejecución en el siguiente código */

object obj = new int[10]; // obj es de tipo System.Int32[]
dynamic dyn = 13; // dyn toma el tipo System.Int32
Console.WriteLine(obj.Length); // Error de compilacion. System.Object no tiene definido el metodo Length, siempre va a tirar error de compilacion
Console.WriteLine(dyn.Length); // Error de ejecucion. int no tiene definido el metodo Length. dyn es int porque es el tipo que asumio por su declaracion
