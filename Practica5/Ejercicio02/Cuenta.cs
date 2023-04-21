namespace ejercicio02;
using System.Collections;

class Cuenta{
    /* SOBRE LA INSTANCIA */
    private int Id {get; set;} // Id unico de la instancia
    private double Saldo {get; set;} // Saldo disponible de la instancia

    /* SOBRE LA CLASE */
    private static int CuentasCreadas = 0; // Cantidad de cuentas creadas
    private static int CantDepositos = 0; // Cantidad de depositos realizados
    private static int CantExtracciones = 0; // Cantidad de extracciones realizadas
    private static double MontoDepositado = 0; // Monto total de depositos realizados
    private static double MontoExtraido = 0; // Monto total de extracciones realizadas
    private static int ExtraccionesInvalidas = 0; // Total extracciones invalidas (falta de fondos)
    private static List<Cuenta> ListaCuentas = new List<Cuenta>();

    public Cuenta(){
        this.Id = ++Cuenta.CuentasCreadas; // Asigna Id a la instancia
        Cuenta.ListaCuentas.Add(this); // Agrega la nueva cuenta a la lista de cuentas
        Console.WriteLine($"Se creo la cuenta Id = {this.Id}");
    }

    public void ActualizarListaSaldo(){
        int indice = this.Id;
        Cuenta.ListaCuentas[--indice].Saldo = this.Saldo;
    }

    public Cuenta Depositar(double monto){
        this.Saldo += monto;
        Cuenta.CantDepositos++;
        Cuenta.MontoDepositado += monto;
        ActualizarListaSaldo();
        Console.WriteLine($"Se deposito {monto} en la cuenta {this.Id} (Saldo = {this.Saldo})");
        return this;
    }

    public Cuenta Extraer(double monto){
        if (this.Saldo >= monto)
        {
            this.Saldo -= monto;
            Cuenta.CantExtracciones++;
            Cuenta.MontoExtraido += monto;
            ActualizarListaSaldo();
            Console.WriteLine($"Se extrajo {monto} de la cuenta {this.Id} (Saldo = {this.Saldo})");
        }
        else
        {
            Cuenta.ExtraccionesInvalidas++;
            Console.WriteLine($"Operación denegada - Saldo insuficiente: {this.Saldo} < {monto}");
        }
        return this;
    }

    public static void ImprimirDetalle(){
        //Console.WriteLine($"CUENTAS CREADAS: {Cuenta.CuentasCreadas}\nDEPOSITOS:\t {Cuenta.CantDepositos}\t- Total depositado: \t{Cuenta.MontoDepositado}\nEXTRACCIONES:\t {Cuenta.CantExtracciones}\t- Total extraido: \t{Cuenta.MontoExtraido}\n\t\t\t- Saldo \t\t{Cuenta.MontoDepositado-Cuenta.MontoExtraido}\n* Se denegaron {Cuenta.ExtraccionesInvalidas} extracciones por falta de fondos");
        Console.WriteLine($"CUENTAS CREADAS: {Cuenta.CuentasCreadas}");
        Console.WriteLine($"DEPOSITOS:       {Cuenta.CantDepositos}     - Total depositado: {Cuenta.MontoDepositado}");
        Console.WriteLine($"EXTRACCIONES:    {Cuenta.CantExtracciones}     - Total extraido:   {Cuenta.MontoExtraido}");
        Console.WriteLine($"                       - Saldo             {Cuenta.MontoDepositado - Cuenta.MontoExtraido}");
        Console.WriteLine($"Se denegaron {Cuenta.ExtraccionesInvalidas} extracciones por falta de fondos");
    }

    public static List<Cuenta> GetCuentas() => Cuenta.ListaCuentas;


    /*
    public static List<Cuenta> GetCuentas(){
        List<Cuenta> lista = new List<Cuenta>();
        foreach (Cuenta c in Cuenta.ListaCuentas){
            lista.Add(c);
        }
        return Cuenta.ListaCuentas;
    }
    */
}
