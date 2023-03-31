/*
12. Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto
aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un
carácter una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave.

A cada carácter del mensaje original se le suma la cantidad indicada en la clave. En el caso que
la suma fuese mayor que 28 se debe volver a contar desde el principio, Implementar una cola
con los números de la clave encolados y a medida que se desencolen para utilizarlos en el
cifrado, se vuelvan a encolar para su posterior utilización. Programar un método para cifrar y
otro para descifrar.
*/
using System; using System.Collections.Generic;

void cargarTabla(char[] caracteres){
    char caracter = 'A';
    int i;
    for (i = 0; i < caracteres.Length-1; i++, caracter++){ // < (length-1) para que la ultima pos quede para cargarle el space
        caracteres[i] = caracter;
    }
    caracteres[i] = ' ';
}

List<char> cifrarMensaje(string mensajeACifrar){
    List<char> mensaje = new List<char>();
    for (int i = 0; i < mensajeACifrar.Length; i++){
        mensaje.Insert(i, mensajeACifrar[i]); // //mensaje[i] = mensajeACifrar[i]; ES LO MISMO?
    }
    return mensaje;
}

List<char> decifrarMensaje(string mensajeADecifrar){
    List<char> mensaje = new List<char>();
    for (int i = 0; i < mensajeADecifrar.Length; i++){
        mensaje.Insert(i, mensajeADecifrar[i]);
    }
    return mensaje;
}

Queue<int> cargarClaveRepetida(List<int> clave){
    Queue<int> claveRepetida = new Queue<int>();
    for (int i = 0){

    }
    return claveRepetida;
}

char[] abc = new char[28]; // tiene el abcdario y el space
cargarTabla(abc);

string mensajeACifrar = "MENSAJE CIFRADO";
List<char> mensajeCifrado = cifrarMensaje(mensajeACifrar);
List<char> mensajeDecifrado = decifrarMensaje(mensajeACifrar);
List<int> clave = new List<int>(){ 2, 3, 0, 9};
Queue<int> claveRepetida = cargarClaveRepetida(clave);

Queue<char> cola = new Queue<char>();


Console.ReadLine();
