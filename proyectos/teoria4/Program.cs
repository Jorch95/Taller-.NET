using Teoria4;
using System;
//Console.WriteLine("Hello, World!");
Auto a;
a = new Auto("Nissan",2017);
Console.WriteLine(a.getDescripcion());
Auto b = new Auto("Ford",2015);
Console.WriteLine(b.getDescripcion());
a = new Auto();
Console.WriteLine(a.getDescripcion());
b = new Auto("Chevy");
Console.WriteLine(b.getDescripcion());

Coleccion2 c2 = new Coleccion2();
c2.Agregar("Hola mundo");
c2.Agregar("Hola mundo2");
c2.Agregar("Hola mundo3");
/* c2.Agregar(200);
c2.Agregar(b);
c2.Agregar(b.getDescripcion()); */
c2.Imprimir();

Cuenta cuenta1 = new Cuenta();
cuenta1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
Cuenta cuenta2 = new Cuenta();
cuenta2.Depositar(200).Depositar(800);

new Cuenta().Depositar(20).Extraer(20);

cuenta2.Extraer(1000).Extraer(1);
Console.WriteLine("\nDETALLE");
Cuenta.ImprimirDetalle();

new Cuenta();
new Cuenta();
new Cuenta();
List<Cuenta> cuentas = Cuenta.Cuentas; 
// se recuperó la lista de cuentas creadas
cuentas[4].Depositar(50);
// se depositó 50 en la primera cuenta de la lista devuelta
cuentas.RemoveAt(3);
Console.WriteLine(cuentas.Count);
cuentas[3].Depositar(50);
// se borró un elemento de la lista devuelta
// pero la clase Cuenta sigue manteniendo todos
// los datos "La cuenta id: 1 tiene 50 de saldo"
cuentas = Cuenta.Cuentas;
Console.WriteLine(cuentas.Count);
// se recupera nuevamente la lista de cuentas
cuentas[4].Extraer(30);
//se extrajo 30 de la cuenta id: 1 que tenía 50 de saldo
/* Cuenta cuenta = new Cuenta();
cuenta.Depositar(2000);
cuenta2 = new Cuenta();
cuenta2.Depositar(1000);
cuenta1.Depositar(1000);
Cuenta.ImprimirResumen();
 */
 Matriz4 matriz = new Matriz4(2,3);
 Matriz4 matriz2 = new Matriz4(3,2);
 matriz2.SetElemento(0,0,3);
 matriz2.SetElemento(0,1,2);
 matriz2.SetElemento(1,0,1);
 matriz2.SetElemento(1,1,6);
 matriz2.SetElemento(2,0,1);
 matriz2.SetElemento(2,1,2);
 matriz.SetElemento(0,0,2);
 matriz.SetElemento(0,1,10);
 matriz.SetElemento(0,2,5);
 matriz.SetElemento(1,0,4);
 matriz.SetElemento(1,1,3);
 matriz.SetElemento(1,2,1);
 Console.WriteLine($"La cantidad de elementos son: {matriz.Length}");
 double[] columna1 = matriz.getColumna(0);
 double[] fila0 = matriz.GetFila(0);
 double[] fila1 = matriz.GetFila(1);
 for(int i=0;i<columna1.Length;i++) { Console.WriteLine($"{columna1[i]}");}
 double [][] arregloDeArreglo = matriz.getArregloDeArreglo();
 int dim = 0;
 for(int i=0;i<arregloDeArreglo.Length;i++){
     dim += arregloDeArreglo[i].Length;
 }
 Console.WriteLine($"La cantidad de elementos en la matriz son: {matriz.Length}");
 Console.WriteLine($"La cantidad de elementos en arreglo de arreglo son: {dim}");
 double[] diagP,diagS = new double[2];

 try{
   diagP = matriz2.GetDiagonalSecundaria();
 }
 catch (ArgumentException e){
   Console.WriteLine($"Dentro de catch: {e.Message}");
 }
 /* diagS = matriz.GetDiagonalSecundaria();
 foreach(double d in diagP){
    Console.WriteLine($"{d}");
 } */
 foreach(double s in diagS){
    Console.WriteLine($"{s}");
 }
 matriz2.imprimir();
 matriz.imprimir();
 matriz2.multiplicarPor(matriz);
 matriz2.imprimir();
 

