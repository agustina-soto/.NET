using System;
using System.Collections;
using ejercicio01;

A[] vector = new A[] { new A(3), new B(5), new C(15), new D(41) };

foreach (A a in vector)
{
    a.Imprimir();
}
