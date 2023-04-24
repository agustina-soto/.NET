using ejercicio08;

Empleado[] empleados = new Empleado[]
{
    new Administrativo("Ana", 20000000, DateTime.Parse("26/4/2018"), 10) {Premio=1000},
    new Vendedor("Diego", 30000000, DateTime.Parse("2/4/2010"), 20) {Comision=2000},
    new Vendedor("Luis", 33333333, DateTime.Parse("30/12/2011"), 30) {Comision=2000}
};

foreach (Empleado e in empleados)
{
    Console.WriteLine(e);
    e.AumentarSalario();
    Console.WriteLine(e);
}
