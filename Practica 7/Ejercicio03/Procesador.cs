namespace tp7;

static class Procesador
{
    public static void Alquilar(IAlquilable x, Persona p) => x.SeAlquilaA(p);
    public static void Devolver(IAlquilable x, Persona p) => x.DevueltoPor(p);
    public static void Vender(IVendible x, Persona p) => x.SeVendeA(p);
    public static void Atender(IAtendible x) => x.SeAtiendeA();
    public static void Lavar(ILavable x) => x.Lavando();
    public static void Secar(ILavable x) => x.Secando();
    public static void Reciclar(IReciblable x) => x.Reciclando();

}
