namespace teoria9;
public class NodoA<T>{
    public T? Valor {get;protected set;}
    public NodoA<T>? Izq {get;protected set;}
    public NodoA<T>? Der {get; protected set;}

    public NodoA(){  }
    public NodoA(T valor){
        Valor = valor;
    }
}