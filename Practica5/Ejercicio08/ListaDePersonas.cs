/* Completarla y agregar dos indizadores de sólo lectura
Un índice entero que permite acceder a las personas de la lista por número de documento. Por
ejemplo p=lista[30456345] devuelve el objeto Persona que tiene DNI=30456345 o null en caso
que no exista en la lista.
Un índice de tipo char que devuelve un List<string> con todos los nombres de las personas de la
lista que comienzan con el carácter pasado como índice.
*/
namespace ejercicio08;
class ListaDePersonas {

    private List<Persona> _listaPersonas = new List<Persona>();
    /*  Deberia hacer una propiedad de lectura para la v.i.??
        public List<Persona>? ListaPersonas { get; }
    */


    public void Agregar(Persona p) => _listaPersonas.Add(p);

    public Persona this [int DNI] {
        get
        {
            foreach (Persona p in _listaPersonas){
                if (p.DNI == DNI) return p;
            }
            return null; // Si llego hasta aca es porque la persona con ese DNI no existe
        }
    }

    public List<string> this [char c] {
        get
        {
            List<string> listaNombres = new List<string>();
            foreach (Persona p in _listaPersonas){
                if (p.Nombre[0] == c) listaNombres.Add(p.Nombre);
            }
            return listaNombres;    
        }
    }

}
