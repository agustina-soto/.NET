namespace ejercicio08;

class Administrativo : Empleado {

    public decimal Premio { get; set; }

    // Oculta las propiedaded originales de la superclase para definir una nueva implementacion de cada una --> desde la clase Empleado se sigue pudiendo acceder a los descriptores de lectura
    new public string? Nombre { get; set; }
    new public int DNI { get; set; }
    new public DateTime FechaIngreso { get; set; }
    new public decimal SalarioBase { get; set; }
    new public decimal Salario { get; set; }


    public Administrativo(string nombre, int dni, DateTime fechaIngreso, decimal salarioBase){
        Nombre = nombre;
        DNI = dni;
        FechaIngreso = fechaIngreso;
        SalarioBase = salarioBase;
        Salario = SalarioBase + Premio;
    }


    // Incrementa el salario base en un 1% por cada año de antigüedad
    public override void AumentarSalario(){
        int antiguedad = DateTime.Now.Year - FechaIngreso.Year;
        Premio = (SalarioBase*1/100)*antiguedad;
        Salario += Premio;
    }


    public override string ToString(){
        return "Administrativo " + $"Nombre: {Nombre}, DNI: {DNI} Antigüedad: {DateTime.Now.Year - FechaIngreso.Year}\nSalario base: {SalarioBase}, Salario: {Salario}\n-------------";
    }
}
