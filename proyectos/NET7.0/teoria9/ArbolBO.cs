namespace teoria9;
public class ArbolBO<T> where T: IComparable<T> {
    public NodoA<T>? Hoja {get; protected set;} 
    public int CantNodos {get; protected set;} = 0;
    public ArbolBO(){}
    public void Insertar(T valor){
        var nuevo = new NodoA<T>(valor);
        CantNodos+=1;
    }
    public List<T> Inorden(){
        var listaO = new List<T>();

        return listaO;
    }
    public NodoA<T> recorrer(){
        var ultimo = new NodoA<T>();
        return ultimo;
    }
}