// Utilizando el operador is

using System;
using ejercicio02;

A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector)
{
    if ( (! (a is C)) & (! (a is D) ) || (! (a is A) ) ){ // || (! (a is A) esta de mas no?
        a.Imprimir();
    }
}
