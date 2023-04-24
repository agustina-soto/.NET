namespace ejercicio08;

abstract class Empleado{

    protected string _nombre;
    protected int _DNI;
    protected DateTime _fechaIngreso;
    protected decimal _salarioBase;
    protected decimal _salario;

    public string Nombre { get; }
    public int DNI { get; }
    public DateTime FechaDeIngreso { get; }
    public decimal SalarioBase { get; }
    public decimal Salario{ get; } // Salario base más la comisión o el premio según corresponda.


    public abstract void AumentarSalario();

}
