//Clase matriz de la Práctica 4.
namespace Teoria4;

class Matriz4 {
    private double[,] _M;
    private int _filas;
    private int _columnas;
    public int Length {
        get => _M.Length;
    }

public Matriz4( int filas, int columnas){
    _M = new double[filas,columnas];
    _filas = filas;
    _columnas = columnas;

}
public Matriz4(double [,] matriz){
    _M = matriz;
}
public void SetElemento(int fila, int columna, double elemento){
    _M[fila,columna] = elemento;
}
public double GetElemento(int fila, int columna) => _M[fila,columna];
public void imprimir() {
    Console.WriteLine("Se imprime la matriz entera:");
    for (int i=0;i<_M.GetLength(0);i++){
        for (int j=0; j<_M.GetLength(1);j++){
            Console.Write($" {_M[i,j]} ");
        }
        Console.WriteLine(" ");
    }
}
public void imprimir(string formatString){
}
public double[] GetFila(int fila) {
    int dim = _M.GetLength(0); Console.WriteLine($"Dimension de fila: {dim}");
    double[] row = new double[dim]; 
    for (int i=0;i<dim-1;i++){
         row[i] = _M[fila,i]; 
    }
    return row;
} 
public double[] getColumna(int columna){
    int dim = _M.GetLength(1);Console.WriteLine($"Dimension de columna: {_M.GetLength(1)}");
    double[] column = new double[dim];
    for (int i=0;i<_M.GetLength(1)-1;i++){
        column[i] = _M[i,columna];
    }
    return column;
}
public double[] GetDiagonalPrincipal(){
    double [] diagP = new double[(_M.GetLength(0))];
    if (_M.GetLength(0) != _M.GetLength(1)){
        throw new ArgumentException("La matriz no es cuadrada");
    }
    else {
        for(int i=0;i<_M.GetLength(0);i++){
            for(int j=0;j<_M.GetLength(1);j++){
                if(i==j){
                    diagP[i] = _M[i,j];
                }
            }
        }
    }
    return diagP;
}
public double[] GetDiagonalSecundaria(){
    double [] diagS = new double[(_M.GetLength(0))];
    if (_M.GetLength(0) != _M.GetLength(1)){
        throw new ArgumentException("La matriz no es cuadrada");
    }
    else {
        for(int i=0;i<_M.GetLength(0);i++){
            for(int j=0;j<_M.GetLength(1);j++){
                if(i+j == _M.GetLength(0)-1){
                    diagS[i] = _M[i,j];
                }
            }
        }
    }
    return diagS;
}
public double [][] getArregloDeArreglo(){
    double[][] nuevo = new double[_M.GetLength(0)][];
    Console.WriteLine($"Elem nuevo: {nuevo.Length}");
    for (int i=0;i<_M.GetLength(0);i++){
            nuevo[i] = new double [_M.GetLength(1)];
            Console.WriteLine($"{nuevo[i].Length}");
    }
    return nuevo;
}
public void sumarle(Matriz4 m){
    if (_M.GetLength(0) != m._M.GetLength(0) || (_M.GetLength(1) != m._M.GetLength(1))){
        Console.WriteLine($"Las matrices no son del mismo tamaño");
    }
    else {
        for (int i=0;i<_M.GetLength(0);i++){
            for(int j=0;j<_M.GetLength(1);j++){
                _M[i,j] += m._M[i,j];
            }
        }
    }
}
public void restarle(Matriz4 m){
 if (_M.GetLength(0) != m._M.GetLength(0) || (_M.GetLength(1) != m._M.GetLength(1))){
        Console.WriteLine($"Las matrices no son del mismo tamaño");
    }
    else {
        for (int i=0;i<_M.GetLength(0);i++){
            for(int j=0;j<_M.GetLength(1);j++){
                _M[i,j] -= m._M[i,j];
            }
        }
    }
}
public void multiplicarPor(Matriz4 m){
 if (_M.GetLength(1) != m._M.GetLength(0)){
        Console.WriteLine($"Las matrices no son del tamaño adecuado para su multiplicacion");
    }
    else {
        double[,] mult = new double[_M.GetLength(0),m._M.GetLength(1)]; 
        for (int i=0;i<_M.GetLength(0);i++){
            for(int j=0;j<m._M.GetLength(1);j++){
                for(int k=0;k<_M.GetLength(1);k++){
                    mult[i,j] = _M[i,k]*m._M[k,j] + mult[i,j];
                }
                Console.Write($"{mult[i,j]}");
            }
            Console.WriteLine(" ");
        }
        _M = new double[_M.GetLength(0),m._M.GetLength(1)];
        Array.Copy(mult,_M,mult.Length); 
    }
    
}

    
}