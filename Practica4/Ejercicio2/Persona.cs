namespace ejercicio2;

class Persona
{
    private String _nombre;
    private int _edad;
    private String _DNI;

    public Persona(){

    }

    public Persona(String nombre, int edad, String DNI){
        this._nombre = nombre;
        this._edad = edad;
        this._DNI = DNI;
    }

    public void setNombre(String nombre){
        this._nombre = nombre;
    }

    public void setEdad(int edad){
        this._edad = edad;
    }
    public void setDNI(String DNI){
        this._DNI = DNI;
    }
    public String getNombre(){
        return this._nombre;
    }

    public int getEdad(){
        return this._edad;
    }
    public String getDNI(){
        return this._DNI;
    }

    public String Imprimir(){
        String st = $"{_nombre}\t{_edad}\t{_DNI}";
        return st;
    }
}
