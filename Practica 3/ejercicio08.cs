/* ¿Qué líneas del siguiente método provocan error de compilación y por qué? */

var a = 3L; // a es un System.Long
dynamic b = 32; // b es un System.Int32
object obj = 3; // obj es un System.Int32

a = a * 2.0; // ERROR DE COMPILACION
/*No se puede convertir implícitamente el tipo 'double' en 'long'. Ya existe una conversión explícita
El tipo ya fue inferido por el compilador cuando se declaro "a" y se la tomo como Long;
como son inmutables, una vez inferidos no se puede cambiar el tipo a double */

b = b * 2.0; // b es un System.Double
b = "hola"; // b es un System.String
obj = b; // obj queda siendo de tipo System.String (que es un Object)
b = b + 11; // Concatena: "hola11"

obj = obj + 11; // ERROR DE COMPILACION
/* El operador '+' no se puede aplicar a operandos del tipo 'object' y 'int' */

// Tipos anonimos: son de solo lectura. Evitan que se necesite especificar un tipo para trabajar con un dato de solo lectura
var c = new { Nombre = "Juan" };
var d = new { Nombre = "María" };
var e = new { Nombre = "Maria", Edad = 20 };
var f = new { Edad = 20, Nombre = "Maria" };
f.Edad = 22; // No se puede asignar porque es de solo lectura
d = c; // Permitido porque ?????????????????
        // ?????????????????
        // ?????????????????
        // ?????????????????

e = d; // No se puede convertir implícitamente el tipo '<anonymous type: string Nombre>' en '<anonymous type: string Nombre, int Edad>'

f = e; // No se puede convertir implícitamente el tipo '<anonymous type: string Nombre, int Edad>' en '<anonymous type: int Edad, string Nombre>'
