namespace A;
class A
{
  char c;
  static string st;
  
  void metodo1()
  {
    st = "string";
    c = 'A';
  }
  
  static void metodo2()
  {
    new ClaseA().c = 'a'; // ClaseA no existe
    st = "st2";
    c = 'B'; // c es una variable de instancia, no puede ser accedida dentro del metodo estatico
    new A().st = "otro string";
    /* No se puede acceder a una variable estática mediante una instancia de clase.
       Ademas, el acceso a traves del punto se da para metodos y propiedades; st no esta
       definida como propiedad ni como metodo, por lo que aunque no fuese estatica la linea
       seria invailda.
    */
  }
}
