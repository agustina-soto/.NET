namespace Figuras;

public class Rectangulo
{
    private double _base;
    private double _altura;

    public Rectangulo(double base_, double altura){
        _base = base_;
        _altura = altura;
    }

    public double GetArea(){ // AREA DE UN RECTANGULO => base * altura
        return _base*_altura;
    }
}
