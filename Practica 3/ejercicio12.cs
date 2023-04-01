using System; using System.Text;

/* Genera una tabla de caracteres con el abecedario y el space*/
char[] generarTabla(){
    char caracter = 'A';
    char[] tabla = new char[27];
    int i;
    
    for (i = 0; i < tabla.Length-1; i++, caracter++)
    { // < (length-1) para que la ultima pos quede para cargarle el space
        tabla[i] = caracter;
    }
    tabla[i] = ' ';

    return tabla;
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

/* Devuelve la posicion donde de encuentra c o -1 si no lo encuentra */
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
    int codigo, pos, elem, aux;
    
    for (int i = 0; i < msj.Length; i++)
    {
        pos = buscarPos(tabla, msj[i]); // Busca la pos donde se encuentra el caracter actual
        
        elem = clave.Dequeue(); // Saca elem de la cola
        clave.Enqueue(elem); // Vuelve a encolar elem
        
        aux = pos + elem; // codigo sin cifrar + clave repetida = codigo cifrado
        
        codigo = (aux < 27) ? aux : (aux - 27); // si la suma de arriba > 27, restarle 27
        
        sb.Insert(i, tabla[codigo]);
    }
    return sb; // Queda cargado un string de char modificable
}


/* Devuelve decifrado un mensaje cifrado recibido por parametro */
StringBuilder descifrarMensaje(char[] tabla, Queue<int> clave, StringBuilder msjCifrado){
    int codigo, pos, elem, aux;
    StringBuilder sb = new StringBuilder();
    
    for (int i = 0; i < msjCifrado.Length; i++)
    {
        pos = buscarPos(tabla, msjCifrado[i]); // Busca la pos donde se encuentra el caracter actual

        elem = clave.Dequeue(); // Saca elem de la cola
        clave.Enqueue(elem); // Vuelve a encolar elem
        
        aux = pos - elem; // codigo cifrado - clave repetida = codigo descifrado
        
        codigo = (aux > 0) ? aux : (aux + 27); // si la resta de arriba < 27, sumarle 27

        sb.Insert(i, tabla[codigo]);
    }
    return sb;
}

string mensaje = "HOLA MUNDO";
List<int> clave = new List<int>() {1, 2, 3, 4};
char[] tabla = generarTabla();
Queue<int> cola = generarClaveRepetida(clave);
StringBuilder mensajeCifrado = cifrarMensaje(tabla, cola, mensaje);
StringBuilder mensajeDescifrado = descifrarMensaje(tabla, cola, mensajeCifrado);
