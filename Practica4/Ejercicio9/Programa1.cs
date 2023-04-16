Foo f = new Foo();
f.Imprimir();
class Foo
{
    string? _bar; // string? es lo mismo que string solo, porque los string aceptan valores nulos
    public void Imprimir()
    {
        Console.WriteLine(_bar.Length); /* Da error por excepcion no manejada. Como no se inicializo
                                        manualmente elvalor de _bar se hizo por defecto. Los string
                                        se inicializan con null, por lo que en esta linea se esta
                                        intentando acceder a la propiedad desde un objeto null => INVALIDO
                                                                                */
    }
}
