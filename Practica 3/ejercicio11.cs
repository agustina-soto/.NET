/* 11. Señalar errores de ejecución en el siguiente código */

List<int> a = new List<int>() { 1, 2, 3, 4 }; // declara, crea e inicializa una lista de enteros
a.Remove(5); // Borra de la lista el elemento 5 (no existe asique no hace nada)
a.RemoveAt(4); // Error de ejecucion porque el rango de la lista va de 0 a 3
