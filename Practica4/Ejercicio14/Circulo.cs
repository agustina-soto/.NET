namespace Figuras;
public class Circulo
{

    private double _radio;

    public Circulo(double radio){
        _radio = radio;
    }

    // AREA DEUN CIRCULO => radio^2 * PI
    public double GetArea() => Math.Pow(_radio, 2)*Math.PI;

}
