namespace Figuras;
public class Circulo
{

    private double _radio;

    public Circulo(double radio){
        _radio = radio;
    }

    public double GetArea(){ // AREA DEUN CIRCULO => radio^2 * PI
        return Math.Pow(_radio, 2)*Math.PI;
    }
}
