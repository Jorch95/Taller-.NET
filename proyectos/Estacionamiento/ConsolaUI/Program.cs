using Automotores;
using System;
//Console.WriteLine("Hello, World!");

Auto a = new Auto("Renault");
Console.WriteLine(a.getDescripcion());

Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End)
{
Console.Clear();
Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
k = Console.ReadKey(true);
}

