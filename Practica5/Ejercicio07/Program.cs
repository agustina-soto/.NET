/*
Definir la clase Persona con las siguientes propiedades de lectura y escritura: Nombre de tipo
string, Sexo de tipo char, DNI de tipo int, y FechaNacimiento de tipo DateTime. Además
definir una propiedad de sólo lectura (calculada) Edad de tipo int. Definir un indizador de
lectura/escritura que permita acceder a las propiedades a través de un índice entero. Así, si p es un
objeto Persona, con p[0] se accede al nombre, p[1] al sexo p[2] al DNI, p[3] a la fecha de
nacimiento y p[4] a la edad. En caso de asignar p[4] simplemente el valor es descartado. Observar
que el tipo del indizador debe ser capaz almacenar valores de tipo int, char, DateTime y string.

*/

using System;
using ejercicio07;


Persona p = new Persona ();


p.Nombre = "Agustina Soto";
p.Sexo = 'f';
p.DNI = 42941724;
p.FechaNacimiento = new DateTime (2000, 9, 23);


Console.WriteLine($" {p[0]} {p[1]} {p[2]} {p[3]} {p[4]}"); // Nombre Sexo DNI Fecha(dia/mes/año) Edad
