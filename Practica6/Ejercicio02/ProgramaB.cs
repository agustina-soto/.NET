// Utilizando el método GetType() y el operador typeof()

using System;
using ejercicio02;

A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector)
{
    if (a.GetType() == typeof(B)) a.Imprimir();
}
