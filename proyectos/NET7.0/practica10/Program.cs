
var multiplos = Enumerable.Range(100,101);
multiplos.Where(m => (m%5) == 0).ToList().ForEach(m => Console.Write(m));
Console.WriteLine(); 

//Ejercicio2:
int[] vector = new int[] { 1, 3, 4, 5, 9, 4, 3, 4, 5, 1, 1, 4, 9, 4, 3, 1 };
vector.GroupBy(n => n)
            .Select(n => new {Numero = n.Key, Cantidad = n.Count()})
            .OrderBy(n => n.Cantidad)
            .ToList()
.ForEach(obj => Console.WriteLine(obj));

//Ejercicio3: