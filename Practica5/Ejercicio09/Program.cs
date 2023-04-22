// ¿Cuál es el error en el siguiente programa?

Auto a = new Auto();
a.Marca = "Ford";
Console.WriteLine(a.Marca);
class Auto
{
    private string marca;
    public string Marca
    {
        set
        {
            Marca = value;
        }
        get
        {
            return marca;
        }
    }
}

/*
    El error esta en la linea 11 (Marca = value), porque no setea la variable de instancia "marca" sino
    la propiedad "Marca". Como dice la nota de la consigna: utilizar la convención de prefijar a los campos
    privados con guión bajo hace más difícil cometer este tipo de errores.
*/
