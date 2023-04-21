namespace ejercicio01V2;
using System.Text;
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
    private static StringBuilder? Detalle = new StringBuilder(); // Detalle y movimientos de la cuenta

    public Cuenta(){
        this.Id = ++Cuenta.CuentasCreadas;
        Imprimir($"Se creo la cuenta Id = {Cuenta.CuentasCreadas}");
    }

    public Cuenta Depositar(double monto){
        this.Saldo += monto;
        Cuenta.CantDepositos++;
        Cuenta.MontoDepositado += monto;
        Imprimir($"Se deposito {monto} en la cuenta {this.Id} (Saldo = {this.Saldo})");
        return this;
    }
    
    public Cuenta Extraer(double monto){
        if (this.Saldo >= monto)
        {
            this.Saldo -= monto;
            Cuenta.CantExtracciones++;
            Cuenta.MontoExtraido += monto;
            Imprimir($"Se extrajo {monto} de la cuenta {this.Id} (Saldo = {this.Saldo})");
        }
        else
        {
            Cuenta.ExtraccionesInvalidas++;
            Imprimir($"Operación denegada - Saldo insuficiente --> {monto} > {this.Saldo}");
        }
        return this;
    }

    public void Imprimir(String param) => Cuenta.Detalle?.Append($"\n{param}");
    
    public static void ImprimirDetalle(){
        Cuenta.Detalle?.Append($"\n\nCUENTAS CREADAS: {Cuenta.CuentasCreadas}\nDEPOSITOS:\t {Cuenta.CantDepositos}\t- Total depositado: \t{Cuenta.MontoDepositado}\nEXTRACCIONES:\t {Cuenta.CantExtracciones}\t- Total extraido: \t{Cuenta.MontoExtraido}\n\t\t\t- Saldo \t\t{Cuenta.MontoDepositado-Cuenta.MontoExtraido}\n* Se denegaron {Cuenta.ExtraccionesInvalidas} extracciones por falta de fondos");
        Console.WriteLine(Cuenta.Detalle);
    }

}
