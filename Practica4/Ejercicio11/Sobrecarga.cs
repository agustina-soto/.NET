object o = 5;
Sobrecarga s = new Sobrecarga();
s.Procesar(o, o); // dynamic d1: 5 dynamic d2:5
s.Procesar((dynamic)o, o); // entero: 5 objeto:5
s.Procesar((dynamic)o, (dynamic)o); // entero: 5 objeto:5
s.Procesar(o, (dynamic)o); // dynamic d1: 5 dynamic d2:5
s.Procesar(5, 5); // entero: 5 objeto:5
class Sobrecarga
{
    public void Procesar(int i, object o)
    {
        Console.WriteLine($"entero: {i} objeto:{o}");
    }
    public void Procesar(dynamic d1, dynamic d2)
    {
        Console.WriteLine($"dynamic d1: {d1} dynamic d2:{d2}");
    }
}
