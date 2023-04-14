namespace ejercicio6;

class Ecuacion2
{
    private double _a;
    private double _b;
    private double _c;


    public Ecuacion2(double a, double b, double c){
        this._a = a;
        this._b = b;
        this._c = c;
    }

    public double get_a(){
        return this._a;
    }

    public double get_b(){
        return this._b;
    }

    public double get_c(){
        return this._c;
    }

    /* Devuelve el valor del discriminante. Formula: (b^2)-4*a*c */
    public double GetDiscriminante() => (Math.Pow(this._b, 2)) - 4 * this._a * this._c;


    /* Devuelve 0, 1 ó 2 dependiendo de la cantidad de raíces reales que posee la ecuación. Si el discriminante es negativo no tiene raíces reales,
    si el discriminante es cero tiene una única raíz, si el discriminante es mayor que cero posee 2 raíces reales. */
    public int GetCantidadDeRaices(){
        switch (this.GetDiscriminante())
        {
            case < 0 : return 0; // Discriminante menor a 0 
            case > 0 : return 2; // Discriminante mayor a 0
            default  : return 1; // Discriminante igual a 0
        }
    }

    /* Imprime la o las posibles raíces reales de la ecuación. En caso de no poseer soluciones reales debe imprimir una leyenda que así lo especifique */
    public void ImprimirRaices(){

        if (this.GetCantidadDeRaices() != 0)
        {

            double raiz = ( (-this._b) + Math.Sqrt( this.GetDiscriminante() ) ) / (2 * this._a);
            switch (this.GetCantidadDeRaices())
            {
                case 1  : 
                            Console.WriteLine($"Tiene una sola raiz: {raiz}");
                            break;

                case 2  :   double raiz2 = ( (-this._b) - Math.Sqrt( this.GetDiscriminante() ) ) / (2 * this._a);
                            Console.WriteLine($"Tiene dos raices: {raiz} y {raiz2}");
                            break;

                default :   Console.WriteLine("ERROR");
                            break;
            }
        }
        else Console.WriteLine("No tiene raices");
    }


}
