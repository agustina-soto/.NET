namespace ejercicio03;
using System.Collections;

class Cuenta{
    /* SOBRE LA INSTANCIA */
    private int _Id {get; set;} // Id unico de la instancia
    private double _Saldo {get; set;} // Saldo disponible de la instancia

    /* SOBRE LA CLASE */
    private static int s_CuentasCreadas = 0; // Cantidad de cuentas creadas
    private static int s_CantDepositos = 0; // Cantidad de depositos realizados
    private static int s_CantExtracciones = 0; // Cantidad de extracciones realizadas
    private static double s_MontoDepositado = 0; // Monto total de depositos realizados
    private static double s_MontoExtraido = 0; // Monto total de extracciones realizadas
    private static int s_ExtraccionesInvalidas = 0; // Total extracciones invalidas (falta de fondos)
    private static List<Cuenta> s_ListaCuentas = new List<Cuenta>();

    public Cuenta(){
        this._Id = ++Cuenta.s_CuentasCreadas; // Asigna Id a la instancia
        Cuenta.s_ListaCuentas.Add(this); // Agrega la nueva cuenta a la lista de cuentas
        Console.WriteLine($"Se creo la cuenta Id = {this._Id}");
    }

    public void ActualizarListaSaldo(){
        int indice = this._Id;
        Cuenta.s_ListaCuentas[--indice]._Saldo = this._Saldo;
    }

    public Cuenta Depositar(double monto){
        this._Saldo += monto;
        Cuenta.s_CantDepositos++;
        Cuenta.s_MontoDepositado += monto;
        ActualizarListaSaldo();
        Console.WriteLine($"Se deposito {monto} en la cuenta {this._Id} (Saldo = {this._Saldo})");
        return this;
    }

    public Cuenta Extraer(double monto){
        if (this._Saldo >= monto)
        {
            this._Saldo -= monto;
            Cuenta.s_CantExtracciones++;
            Cuenta.s_MontoExtraido += monto;
            ActualizarListaSaldo();
            Console.WriteLine($"Se extrajo {monto} de la cuenta {this._Id} (Saldo = {this._Saldo})");
        }
        else
        {
            Cuenta.s_ExtraccionesInvalidas++;
            Console.WriteLine($"Operación denegada - Saldo insuficiente: {this._Saldo} < {monto}");
        }
        return this;
    }

    public static void ImprimirDetalle(){
        //Console.WriteLine($"CUENTAS CREADAS: {Cuenta.CuentasCreadas}\nDEPOSITOS:\t {Cuenta.CantDepositos}\t- Total depositado: \t{Cuenta.MontoDepositado}\nEXTRACCIONES:\t {Cuenta.CantExtracciones}\t- Total extraido: \t{Cuenta.MontoExtraido}\n\t\t\t- Saldo \t\t{Cuenta.MontoDepositado-Cuenta.MontoExtraido}\n* Se denegaron {Cuenta.ExtraccionesInvalidas} extracciones por falta de fondos");
        Console.WriteLine($"CUENTAS CREADAS: {Cuenta.s_CuentasCreadas}");
        Console.WriteLine($"DEPOSITOS:       {Cuenta.s_CantDepositos}     - Total depositado: {Cuenta.s_MontoDepositado}");
        Console.WriteLine($"EXTRACCIONES:    {Cuenta.s_CantExtracciones}     - Total extraido:   {Cuenta.s_MontoExtraido}");
        Console.WriteLine($"                       - Saldo             {Cuenta.s_MontoDepositado - Cuenta.s_MontoExtraido}");
        Console.WriteLine($"Se denegaron {Cuenta.s_ExtraccionesInvalidas} extracciones por falta de fondos");
    }

    public static List<Cuenta> GetCuentas() => Cuenta.s_ListaCuentas; // ESTO PEDIA LA CONSIGNA? NO ENTIENDO SINO...

}
