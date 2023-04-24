namespace ejercicio08;

class Vendedor : Empleado {

    public decimal Comision { get; set; }

    public Vendedor(string nombre, int dni, DateTime fechaIngreso, decimal salarioBase) {
        _nombre = nombre;
        _DNI = dni;
        _fechaIngreso = fechaIngreso;
        _salarioBase = salarioBase;
        _salario = _salarioBase + Comision;
    }

    // Incrementa el salario base en un 5% si su antigüedad es inferior a 10 años o en un 10% en caso contrario.
    public override void AumentarSalario(){
        int antiguedad = DateTime.Now.Year - _fechaIngreso.Year;
        Comision = (antiguedad < 10) ? (_salarioBase*5/100) : (_salarioBase*10/100);
    }

}
