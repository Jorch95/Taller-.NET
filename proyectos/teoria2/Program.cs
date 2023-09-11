using System;
using System.Text;
Console.WriteLine("Hello, World!");
//String? st1 =  null; 
//String? st2 = "Hola"; 
//Console.WriteLine(st1.GetType);
/* int var1=0; 
int var2 = 17;
double var3 = 1.5;
object obj1;
object? obj2 = null;
Console.WriteLine(var1); 
char c1 = 'A';
char c2 = c1;
Console.WriteLine(c1 == c2); */
object o1 = "AZ";
object o2 = o1;
o2 = "ZZ";
Console.WriteLine( o1 == o2);
Console.WriteLine (o1 + " " + o2);
char? a1;
//char? a2;
a1 = (char?)65;
Console.WriteLine(a1.GetType());
Console.WriteLine(a1.HasValue);
Console.WriteLine(a1.Value);
Console.WriteLine(a1);
//Console.WriteLine(a2);
//a2 = 65; //Devuelve null porque puede haber perdida de info.

int sum = 0;
int i = 1;
while (i <= 10){
    sum += i++;
}
Console.WriteLine(sum); 
Console.WriteLine(args == null);
Console.WriteLine(args.GetLength(0));
//Console.WriteLine(args[0]);
int[]? vector;
vector = new int[0];
Console.WriteLine(vector);
//Console.WriteLine(vector.GetValue);
Console.WriteLine(vector.ToString());
//Console.WriteLine(vector.GetValue(0));
Console.WriteLine(vector.GetType());

Console.WriteLine(vector);

//Console.WriteLine("¡Hola {0}!", args[0]);

char? c;
char? c2;
string? st;
//c = "";     //No se puede convertir implicitamentente de string a char.
c = ' ';     //Literal de caracter vacio.
c = null;//No se puede convertir NULL en char porque es un tipo de valor que no acepta valores null.
c2 = null;
c = c2;
c2 = (65 as char?); //El resultado da siempre NULL porque usando el método 'as' puede haber pérdida de info.
st = "";
st = null;
st = 65.ToString();  //No se puede convertir implicitamente el tipo char a string.
//st = (string)65; //No se puede convertir el tipo int en string.
st = 47.89.ToString();

StringBuilder tw = new StringBuilder("Tweet");
string tw2 = "Tweet2";
Console.WriteLine(tw2);


Console.WriteLine("Enter..");