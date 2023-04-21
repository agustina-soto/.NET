using ejercicio02;

/*
--- TENDRIA QUE DEVOLVER ESTO ---
Se creó la cuenta Id=1
Se creó la cuenta Id=2
Se depositó 50 en la cuenta 1 (Saldo=50)
1
2
Se extrajo 30 de la cuenta 1 (Saldo=20)

---------------------------------------
ME DEVUELVE ESTO:

Se creo la cuenta Id = 1
Se creo la cuenta Id = 2
Se deposito 50 en la cuenta 1 (Saldo = 50)
2
1
Operación denegada - Saldo insuficiente: 0 < 30

NO ENTIENDO POR QUE ME DEBERIA DEVOLVER 2 Y DESPUES QUE SE EXTRAJO CORRECTAMENTE, SI SE ELIMINO EL ELEMENTO DE
LA LISTA QUE TENIA SALDO 50, POR QUE DEBERIA PODER RESTARLE?? ENTIENDO QUE LA CUENTA SIGUE EXISTIENDO COMO
INSTANCIA Y QUE TIENE SUS DATOS INTACTOS, PERO EN LA LISTA YA NO ESTA PORQUE SE HIZO EL REMOVE..... :(
*/

new Cuenta();
new Cuenta();
List<Cuenta> cuentas = Cuenta.GetCuentas();
// se recuperó la lista de cuentas creadas
cuentas[0].Depositar(50);
// se depositó 50 en la primera cuenta de la lista devuelta
cuentas.RemoveAt(0);
Console.WriteLine(cuentas.Count); // TIENE QUE DEVOLVER 1 PORQUE TENIA 2 CUENTAS Y ELIMINE 1
// se borró un elemento de la lista devuelta
// pero la clase Cuenta sigue manteniendo todos
// los datos "La cuenta id: 1 tiene 50 de saldo"
cuentas = Cuenta.GetCuentas();
Console.WriteLine(cuentas.Count); // TIENE QUE DEVOLVER 1 DE NUEVO.......
// se recupera nuevamente la lista de cuentas
cuentas[0].Extraer(30); // TIENE QUE DEVOLVER OPERACION DENEGADA, PORQUE LA CUENTA QUE QUEDO NO TIENE SALDO...
//se extrajo 30 de la cuenta id: 1 que tenía 50 de saldo
