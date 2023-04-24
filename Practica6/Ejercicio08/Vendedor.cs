namespace ejercicio08;

class Vendedor : Empleado {

    public decimal Comision { get; set; }

    // Oculta las propiedaded originales de la superclase para definir una nueva implementacion de cada una --> desde la clase Empleado se sigue pudiendo acceder a los descriptores de lectura
    new public string? Nombre { get; set; }
    new public int DNI { get; set; }
    new public DateTime FechaIngreso { get; set; }
    new public decimal SalarioBase { get; set; }
    new public decimal Salario { get; set; }


    public Vendedor(string nombre, int dni, DateTime fechaIngreso, decimal salarioBase) {
        Nombre = nombre;
        DNI = dni;
        FechaIngreso = fechaIngreso;
        SalarioBase = salarioBase;
        Salario = SalarioBase + Comision;
    }


    // Incrementa el salario base en un 5% si su antigüedad es inferior a 10 años o en un 10% en caso contrario.
    public override void AumentarSalario(){
        int antiguedad = DateTime.Now.Year - FechaIngreso.Year;
        Comision = (antiguedad < 10) ? (SalarioBase*5/100) : (SalarioBase*10/100);
        Salario += Comision;
    }


    public override string ToString(){
        return "Vendedor " + $"Nombre: {Nombre}, DNI: {DNI} Antigüedad: {DateTime.Now.Year - FechaIngreso.Year}\nSalario base: {SalarioBase}, Salario: {Salario}\n-------------";
    }
}
