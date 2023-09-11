using System.Collections;

namespace teoria9;
public class ListaEnlazada<T> : IEnumerable<T>{
    public Nodo<T?>? Primero {get;private set;} 
    public Nodo<T?>? Ultimo {get;private set;}
    public ListaEnlazada(){
         Primero = Ultimo = null;
    }
    public ListaEnlazada(T? valor){
        Primero = new Nodo<T?>(valor);
        Ultimo = new Nodo<T?>(valor);
    }
    public void AgregarAdelante(T? valor){
        Nodo<T?> nuevo = new Nodo<T?>(valor);
        if (Primero == null){
            Primero = nuevo;
            Ultimo = nuevo;
        }
        else {
            nuevo.Proximo = Primero;
            Primero = nuevo;
        }
    }
    public void AgregarAtras(T? valor){
        var nuevo = new Nodo<T?>(valor);
        if (Ultimo == null){
            Ultimo = nuevo;
            Primero = nuevo;

        }
        else{
            Ultimo.Proximo = nuevo;
            Ultimo = Ultimo.Proximo;
        }
    }

    public IEnumerator<T> GetEnumerator(){
        return this.Primero.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}