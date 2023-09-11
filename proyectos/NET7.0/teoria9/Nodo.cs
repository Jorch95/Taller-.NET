using System.Collections;

namespace teoria9;
public class Nodo<T> : IEnumerable<T>{
    public T? Valor { get; protected set; } 
    public Nodo<T?>? Proximo { get; set; } = null;
    public Nodo(T? valor) => Valor = valor;

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    public IEnumerator<T?> GetEnumerator(){
        yield return Valor;
        while(Proximo != null) {
            yield return Proximo.Valor;
            Proximo = Proximo.Proximo;
        }
    }
    /*  public IEnumerator<T> GetEnumerator()
     {
         return ((IEnumerable<T>)Proximo).GetEnumerator();
     }

     IEnumerator IEnumerable.GetEnumerator()
     {
         return ((IEnumerable)Proximo).GetEnumerator();
     } */
}