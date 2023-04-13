namespace ejercicio1;

class Persona
{
    public String nombre;
    public int edad;
    public String DNI;

    public Persona(){

    }

    public Persona(String nombre, int edad, String DNI){
        this.nombre = nombre;
        this.edad = edad;
        this.DNI = DNI;
    }

    public void setNombre(String nombre){
        this.nombre = nombre;
    }

    public void setEdad(int edad){
        this.edad = edad;
    }
    public void setDNI(String DNI){
        this.DNI = DNI;
    }
    public String getNombre(){
        return this.nombre;
    }

    public int getEdad(){
        return this.edad;
    }
    public String getDNI(){
        return this.DNI;
    }

    public String toString(){
        String st = $"Nombre: {nombre} | Edad: {edad} | DNI: {DNI}";
        return st;
    }
}
