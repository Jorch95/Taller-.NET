//Solucionar errores de compilación
/* int i = Maximo(100, 55);
Console.WriteLine(i);
string st = Maximo("hola", "mundo");
Console.WriteLine(st);
Console.WriteLine(Maximo ('A','B')); */
using teoria9;
int a = 17;
int b = 23;
Swap<int>(ref a, ref b);
Console.WriteLine($"{a} {b}");
string st1 = "hola";
string st2 = "mundo";
int i = (int)Maximo(100,55);
Console.WriteLine(Maximo<string>("hola", "mundo")); 
Console.WriteLine(Maximo<char>('A','B'));
Swap<string>(ref st1, ref st2);
var lista = new List<object> { "hola", 7, 'A' };
string st = Get<string>(lista, 0);
int num = Get<int>(lista, 1);
char c = Get<char>(lista, 2);
Console.WriteLine($"{st} {num} {c}");
//Ejer
int[] vector1 = new int[] { 1, 2, 3 };
bool[] vector2 = new bool[] { true, true, true };
string[] vector3= new string[] { "uno", "dos", "tres" };
Set<int>(vector1, 110, 2);
Set<bool>(vector2, false, 1);
Set<string>(vector3, "Hola Mundo!", 0);
Imprimir(vector1);
Imprimir(vector2);
Imprimir(vector3);
//Ejer 3)
string[] vector4 = CrearArreglo<string>("uno", "dos");
foreach (string st4 in vector4) Console.Write(st4 + " - ");
Console.WriteLine();
double[] vector5 = CrearArreglo<double>(1, 2.3, 4.1, 6.7);
foreach (double valor in vector5) Console.Write(valor + " - ");
Console.WriteLine();
var stb = new System.Text.StringBuilder();
var d = GetNuevoObjetoDelMismoTipo(stb);
var e = GetNuevoObjetoDelMismoTipo(17);
Console.WriteLine(d.GetType());
Console.WriteLine(e.GetType());

//Ejer 4.
var lista5 = new List<Nodo<int>>();
ListaEnlazada<int> lista6 = new ListaEnlazada<int>();
lista6.AgregarAdelante(3);
lista6.AgregarAdelante(100);
lista6.AgregarAtras(10);
lista6.AgregarAtras(11);
lista6.AgregarAdelante(0);
IEnumerator<int> enumerador = lista6.GetEnumerator();
while (enumerador.MoveNext()){
   Console.Write(enumerador?.Current + " ");
}
Console.WriteLine();

//métodos locales.

T GetNuevoObjetoDelMismoTipo<T>(T obj) where T: new(){
   T obj3 = new T();
   return obj3;
}
T[] CrearArreglo<T>(params T[] parametro ){
   var vector = new T[parametro.Count()];
   for (int i=0; i<parametro.Count();i++){
      vector[i] = parametro[i];
   }
   return vector;
}
void Set<T>(T[] vector, T elem, int i ){
   vector[i] = elem;
}
void Imprimir<T>(T[] vector){
   var e = vector.GetEnumerator();
   while (e.MoveNext()){
      Console.Write($"[{e.Current}]");
   }
   Console.WriteLine();
}
T Get<T> (List<object> lista, int i){
      var elem = (T)lista[i];
   return elem;
}
void Swap<T>(ref T i, ref T j){
    T auxi = i;
    i = j;
    j = auxi;
}

T Maximo<T>(T a, T b) where T : IComparable{
   if (a.CompareTo(b) > 0)
   {
      return a;
   }
   return b;
}