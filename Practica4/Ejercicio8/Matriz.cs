namespace ejercicio8;

class Matriz
{
    private double[,] _matriz;

    public Matriz(double[,] matriz){
        this._matriz = matriz;
    }

    public Matriz(int filas, int columnas){
        this._matriz = new double[filas, columnas];
    }

    // Trae la fila y la columna donde tengo que insertar elemento
    public void SetElemento(int fila, int columna, double elemento){
        _matriz[fila, columna] = elemento;
    }

    public double GetElemento(int fila, int columna){
        return _matriz[fila, columna];
    }

    public void imprimir(){
        for (int i = 0; i < _matriz.GetLength(0); i++){
            for (int j = 0; j < _matriz.GetLength(1); j++){
                Console.WriteLine($"- {_matriz[i, j].ToString()} - ");
            }
        }
    }

    public void imprimir(string formatString){
        for (int i = 0; i < _matriz.GetLength(0); i++){ // FILAS
            for (int j = 0; j < _matriz.GetLength(1); j++){ // COLUMNAS
                Console.WriteLine($"{_matriz[i,j].ToString(formatString)}");
            }
        }
    }

    public double[] GetFila(int fila){
        int cantColumnas = _matriz.GetLength(1);
        double [] vector = new double [cantColumnas]; // Instancia un vector con tantos elementos como tengan las filas de la matriz
        for (int i = 0; i < cantColumnas; i++)
        {
            vector[i] = _matriz[fila, i];
        }
        return vector;
    }

    public double[] GetColumna(int columna){
        int cantFilas = _matriz.GetLength(0);
        double [] vector = new double [cantFilas];
        for (int i = 0; i < cantFilas; i++){
            vector[i] = _matriz[i, columna];
        }
        return vector;
    }

    public double[,] GetMatriz(){
        return _matriz;
    }

    // Devuelve un vector con la diagonal principal de la matriz recibida
    double[] GetDiagonalPrincipal(double[,] matriz){
        int cantFilas = _matriz.GetLength(0);
        double [] vector = new double [cantFilas];
        
        for (int i = 0; i < cantFilas; i++){
                vector[i] = _matriz[i, i];
        }
        return vector;
    }

    // Devuelve un vector con la diagonal secundaria de una matriz recibida como parametro
    double[] GetDiagonalSecundaria(double[,] matriz){
        int cantFilas = _matriz.GetLength(0);
        double[] vector = new double[cantFilas];
        int cantColumnas = matriz.GetLength(1) -1; // Variable auxiliar para no hacer 2 for anidados
        for (int i = 0; i < cantFilas; i++){ // Recorre filas
            vector[i] = matriz[i, cantColumnas - i]; // columnas siempre es = 3
                                                    // 0,3
                                                    // 1,2
                                                    // 2,1
        }
        return vector;
    }

    public double[][] getArregloDeArreglo(){
        // Crea el arreglo de arreglos de dimension[filasMatriz][columnasMatriz]
        double [][] arreglo = new double[_matriz.GetLength(0)][]; // La inicializacion es "de a uno", el segundo [] se llena con un for

        for (int i = 0; i < _matriz.GetLength(0); i++) // Recorre las filas de la columna i
        {
            arreglo[i] = new double[_matriz.GetLength(1)]; // En arreglo[i] queda otro arreglo de matriz.GetLength(1) elementos (incluyendo al arreglo donde se lo crea)
            for (int j = 0; j < _matriz.GetLength(1); j++)
            {
                arreglo[i][j] = _matriz[i,j];
            }
        }
        return arreglo;
    }

    // Devuelve si dos matrices pasadas como parametros son del mismo tamaño
    bool compartenTamanio(double[,]matrizA, Matriz matrizB) => (matrizA.GetLength(0) == matrizB.GetMatriz().GetLength(0)) && (matrizA.GetLength(1) == matrizB.GetMatriz().GetLength(1));

    public void sumarle(Matriz m){
        if(compartenTamanio(_matriz, m))
        {
            for (int i = 0; i < _matriz.GetLength(0); i++){
                for (int j = 0; j  < _matriz.GetLength(1); j++){
                    _matriz[i,j] += m.GetElemento(i, j); // Al contenido de matriz[i,j] le suma el contenido de m[i,j]
                }
            }
        }
    }

    public void restarle(Matriz m){
        if(compartenTamanio(_matriz, m))
        {
            for (int i = 0; i < _matriz.GetLength(0); i++){
                for (int j = 0; j  < _matriz.GetLength(1); j++){
                    _matriz[i,j] -= m.GetElemento(i, j); // Al contenido de matriz[i,j] le suma el contenido de m[i,j]
                }
            }
        }
    }

    public void multiplicarPor(Matriz m){
        if(compartenTamanio(_matriz, m))
        {   
            for (int i = 0; i < _matriz.GetLength(0); i++){
                for (int j = 0; j  < _matriz.GetLength(1); j++){
                    _matriz[i,j] *= m.GetElemento(i, j); // Al contenido de matriz[i,j] le suma el contenido de m[i,j]
                }
            }
        }
    }

}
