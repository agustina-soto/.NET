using System;
using ejercicio08;


ListaDePersonas lista = new ListaDePersonas();

Persona p = new Persona();
p.Nombre = "AGUSTINA SOTO";
p.Sexo = 'F';
p.DNI = 42941724;
p.FechaNacimiento = new DateTime (2000, 9, 23);
lista.Agregar(p);


p = new Persona();

p.Nombre = "JOAQUIN SOTO";
p.Sexo = 'M';
p.DNI = 46695595;
p.FechaNacimiento = new DateTime (2005, 8, 16);
lista.Agregar(p);


p = new Persona();

p.Nombre = "JULIANA SOTO";
p.Sexo = 'F';
p.DNI = 44536262;
p.FechaNacimiento = new DateTime (2003, 3, 5);
lista.Agregar(p);


p = new Persona();

p.Nombre = "ALEJANDRA BELTRACHINI";
p.Sexo = 'F';
p.DNI = 17935232;
p.FechaNacimiento = new DateTime (1966, 6, 19);
lista.Agregar(p);


int DNIABuscar = 17935232;
Console.WriteLine($"Se encontro una persona con el DNI ingresado? DNI = {DNIABuscar} {lista[DNIABuscar].Nombre}");
DNIABuscar = 42941724;
Console.WriteLine($"Se encontro una persona con el DNI ingresado? DNI = {DNIABuscar} {lista[DNIABuscar].Nombre}");


char letraABuscar = 'J';
List<string> listaNombres = lista[letraABuscar]; // Devuelve una lista de string con los nombres que empiezan con J

Console.WriteLine($"Listado de nombres de la lista de personas que empiecen con la letra {letraABuscar}:");
foreach (string nombre in listaNombres)
{
    Console.WriteLine(nombre);
}
