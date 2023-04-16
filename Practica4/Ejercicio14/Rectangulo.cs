namespace Figuras;

public class Rectangulo
{
    private double _base;
    private double _altura;

    public Rectangulo(double base_, double altura){
        _base = base_;
        _altura = altura;
    }

    // AREA DE UN RECTANGULO => base * altura
    public double GetArea() => _base*_altura;

}
