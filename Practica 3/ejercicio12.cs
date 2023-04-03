/*
ME IMPRIME "HOLAAMUNDO" :(
*/

using System;
using System.Collections.Generic;
using System.Text;

/* Genera una tabla de caracteres con el abecedario y el space*/
char[] generarTabla(){
    char caracter = 'A';
    char[] tabla = new char[27]; // .net no considera la ñ: son 26 letras + el space
    int i;
    
    for (i = 0; i < tabla.Length-1; i++, caracter++)
    { // < (length-1) para que la ultima pos quede para cargarle el space
        tabla[i] = caracter;
    }
    tabla[i] = ' ';

    return tabla;
}

void imprimirTabla(char[] tabla){
    foreach(char c in tabla)
    {
        Console.WriteLine(c);
    }
}

/* Devuelve una cola de enteros cargada con una clave recibida por parametro */
Queue<int> generarClaveRepetida(List<int> clave){
    Queue<int> cola = new Queue<int>();
    
    for (int i = 0; i < clave.Count; i++)
    {
        cola.Enqueue(clave[i]);
    }
    return cola;
}

/* Devuelve la posicion donde de encuentra c */
int buscarPos(char[] tabla, char c){
    int pos = 0;
    
    for (int i = 0; i < tabla.Length; i++)
    {
        if (tabla[i] == c){
            pos = i;
            break;
        }
    }
    return pos;
}

/* Devuelve cifrado un mensaje recibido por parametro */
StringBuilder cifrarMensaje(char[] tabla, Queue<int> clave, string msj){
    StringBuilder sb = new StringBuilder();
    int pos, elem;
    
    for (int i = 0; i < msj.Length; i++)
    {
        pos = buscarPos(tabla, msj[i]); // Busca la pos donde se encuentra el caracter actual
        elem = clave.Dequeue(); // Saca elem de la cola
        clave.Enqueue(elem); // Vuelve a encolar elem
        elem += pos;
        if (elem == 27) Console.WriteLine($"este es el space = {elem}");
        if (elem > 26){
            elem -= 26; // pos maxima a la que acceder = 26
        }
        if (elem == 1) Console.WriteLine($"este es el space actualizado = {elem}");
        sb.Append(tabla[elem]);
    }
    return sb; // Queda cargado un string de char modificable
}


/* Devuelve decifrado un mensaje cifrado recibido por parametro */
StringBuilder descifrarMensaje(char[] tabla, Queue<int> clave, StringBuilder msjCifrado){
    int pos, elem;
    StringBuilder sb = new StringBuilder();
    
    for (int i = 0; i < msjCifrado.Length; i++)
    {
        pos = buscarPos(tabla, msjCifrado[i]); // Busca la pos donde se encuentra el caracter actual
        Console.WriteLine($"pos = {pos}");
        elem = clave.Dequeue(); // Saca elem de la cola
        clave.Enqueue(elem); // Vuelve a encolar elem
        Console.WriteLine($"elem = {elem}");
        pos -= elem;
        Console.WriteLine($"resta = {pos}");
        if (pos < 0){
            pos += 26;
            Console.WriteLine($"pos actuaizada = {pos}");
        }
        sb.Append(tabla[pos]);
    }
    return sb;
}

string mensaje = "HOLA MUNDO";
List<int> clave = new List<int>() {1, 2, 3, 4};
char[] tabla = generarTabla();
imprimirTabla(tabla);
Queue<int> cola = generarClaveRepetida(clave);

StringBuilder mensajeCifrado = cifrarMensaje(tabla, generarClaveRepetida(clave), mensaje);
Console.WriteLine($"Mensaje cifrado: {mensajeCifrado}");
StringBuilder mensajeDescifrado = descifrarMensaje(tabla, generarClaveRepetida(clave), mensajeCifrado);
Console.WriteLine($"Mensaje descifrado: {mensajeDescifrado}");


/*
ESTE SI FUNCIONA PERO NOME CONVENCE
*/
using System; using System.Text;

/* Genera una tabla de caracteres con el abecedario y el space*/
char[] generarTabla(){
    char caracter = 'A';
    char[] tabla = new char[28];
    int i;
    
    for (i = 1; i < tabla.Length-1; i++)
    { // < (length-1) para que la ultima pos quede para cargarle el space
        tabla[i] = caracter;
        caracter++;
    }
    tabla[tabla.Length-1] = ' ';

    return tabla;
}

/* Devuelve una cola de enteros cargada con una clave recibida por parametro */
Queue<int> generarClaveRepetida(){
    Queue<int> cola = new Queue<int>();
    cola.Enqueue(5);
    cola.Enqueue(3);
    cola.Enqueue(9);
    cola.Enqueue(7);
    return cola;
}

/* Devuelve la posicion donde de encuentra c o -1 si no lo encuentra */
int buscarPos(char[] tabla, char c){
    int pos = 0;
    
    for (int i = 1; i < tabla.Length; i++)
    {
        if (tabla[i] == c){
            pos = i;
            break;
        }
    }
    return pos;
}

/* Devuelve cifrado un mensaje recibido por parametro */
StringBuilder cifrarMensaje(char[] tabla, Queue<int> clave, StringBuilder msj){
    StringBuilder sb = new StringBuilder();
    int pos, elem;
    
    for (int i = 0; i < msj.Length; i++)
    {
        pos = buscarPos(tabla, msj[i]); // Busca la pos donde se encuentra el caracter actual
        
        elem = clave.Dequeue(); // Saca elem de la cola
        clave.Enqueue(elem); // Vuelve a encolar elem
        
        elem += pos; // codigo sin cifrar + clave repetida = codigo cifrado
        
        if (elem > 27) elem -= 27;
        
        sb.Append(tabla[elem]);
    }
    return sb; // Queda cargado un string de char modificable
}


/* Devuelve decifrado un mensaje cifrado recibido por parametro */
StringBuilder descifrarMensaje(char[] tabla, Queue<int> clave, StringBuilder msjCifrado){
    int pos, elem;
    StringBuilder sb = new StringBuilder();
    
    for (int i = 0; i < msjCifrado.Length; i++)
    {
        pos = buscarPos(tabla, msjCifrado[i]); // Busca la pos donde se encuentra el caracter actual

        elem = clave.Dequeue(); // Saca elem de la cola
        clave.Enqueue(elem); // Vuelve a encolar elem
        
        pos -= elem; // codigo cifrado - clave repetida = codigo descifrado
        
        if (pos <= 0) pos += 27;

        sb.Append(tabla[pos]);
    }
    return sb;
}

StringBuilder msj = new StringBuilder("HOLA MUNDO"); // para mi esto deberia ser un string normal 

char[] tabla = generarTabla();

StringBuilder mensajeCifrado = cifrarMensaje(tabla, generarClaveRepetida(), msj);
Console.WriteLine($"Mensaje cifrado: {mensajeCifrado}");

StringBuilder mensajeDescifrado = descifrarMensaje(tabla, generarClaveRepetida(), mensajeCifrado);
Console.WriteLine($"Mensaje descifrado: {mensajeDescifrado}");
