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

void generarTabla(char[] caracteres){
    char caracter = 'A';
    int i;
    for (i = 0; i < caracteres.Length-1; i++, caracter++){ // < (length-1) para que la ultima pos quede para cargarle el space
        caracteres[i] = caracter;
    }
    caracteres[i] = ' ';
}

// chequear que esto compile, lo modifique en el tren!!!
List<char> cifrarMensaje(string mensajeACifrar, Queue<int> claveRepetida){
    List<char> mensaje = new List<char>();
    for (int i = 0; i < mensajeACifrar.Length; i++){
        mensaje.Insert(i, mensajeACifrar[i] +  claveRepetida.Peek(i) ); // //mensaje[i] = mensajeACifrar[i]; ES LO MISMO?
    }
    return mensaje;
} // chequear lo de peek en teoría, no sé si se usaba asi

List<char> decifrarMensaje(string mensajeADecifrar){
    List<char> mensaje = new List<char>();
    for (int i = 0; i < mensajeADecifrar.Length; i++){
        mensaje.Insert(i, mensajeADecifrar[i]);
    }
    return mensaje;
}

Queue<int> generarClaveRepetida(List<int> clave, int cantChar){
    Queue<int> claveRepetida = new Queue<int>();
    int i = 0;
    while (i < cantChar) {
        int j = 0;
        while ( (i < cantChar) && (j < clave.Count) ){
            claveRepetida.Enqueue(clave[j]);
            j++; i++;
        }
    }
    return claveRepetida;
}

char[] abc = new char[28]; // tiene el abcdario y el space
generarTabla(abc);

string mensajeACifrar = "MENSAJE CIFRADO";
List<char> mensajeCifrado = cifrarMensaje(mensajeACifrar);

List<int> clave = new List<int>(){ 2, 3, 0, 9};
Queue<int> claveRepetida = generarClaveRepetida(clave, mensajeACifrar.Length);

List<char> mensajeDecifrado = decifrarMensaje(mensajeACifrar);


Console.ReadLine();
