namespace teoria8;
class Auxiliar
{
    public void Procesar()
    {
       FuncionEntera f;
        f = SumaUno;
        Console.WriteLine(f(10));
        f = SumaDos;
        Console.WriteLine(f(10));
    }
    void Aplicar(int[] v, FuncionEntera f){
   for (int i = 0; i < v.Length; i++){
      v[i] = f(v[i]);
   }
    }
    void Imprimir(int[] v){
    foreach (int i in v){
       Console.Write(i + " ");
    }
   Console.WriteLine();
    }
    int SumaUno(int n) => n + 1;
    int SumaDos(int n) => n + 2;
}
