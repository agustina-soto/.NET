namespace ejercicio08;

class Administrativo : Empleado {

    public decimal Premio { get; set; }

    public Administrativo(string nombre, int dni, DateTime fechaIngreso, decimal salarioBase){
        _nombre = nombre;
        _DNI = dni;
        _fechaIngreso = fechaIngreso;
        _salarioBase = salarioBase;
        _salario = _salarioBase + Premio;
    }

    // Incrementa el salario base en un 1% por cada año de antigüedad
    public override void AumentarSalario(){ // num * % / 100
        int antiguedad = DateTime.Now.Year - _fechaIngreso.Year;
        Premio = (_salarioBase*1/100)*antiguedad;
    }
}
