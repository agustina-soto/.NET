namespace ejercicio08;

abstract class Empleado{

    public string? Nombre { get; }
    public int DNI { get; }
    public DateTime FechaIngreso { get; }
    public decimal SalarioBase { get; }
    public decimal Salario{ get; }


    public abstract void AumentarSalario();

    public abstract override string ToString();
}
