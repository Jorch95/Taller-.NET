namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;
using System;
public class RepositorioTitular : IRepositorioTitular{
    readonly string _nombreArch="titulares.txt";
    private int id = 0;
    public void AgregarTitular(Titular titular){
        List<Titular> titulares = this.ListarTitulares();
        foreach (Titular t in titulares) {
            if (t.Dni == titular.Dni){
                titular.Id=t.Id; //Para que sí ya está, lo devuelva con el id que fue persistido anteriormente.
                throw new Exception("Dni ya en la base.");
            }
            id=t.Id;
        }
        using var sw = new StreamWriter(_nombreArch,true);  
        id += 1;
        titular.Id=id;
        sw.WriteLine(titular.Id);
        sw.WriteLine(titular.Dni);
        sw.WriteLine(titular.Apellido);
        sw.WriteLine(titular.Nombre);
        sw.WriteLine(titular.Direccion);
        sw.WriteLine(titular.Telefono);
        sw.WriteLine(titular.Email);
    }
    public List<Titular> ListarTitulares(){
        var resultado = new List<Titular>();
        using var sr = new StreamReader(_nombreArch);
        while(!sr.EndOfStream){
            var titular = new Titular();
            titular.Id = int.Parse(sr.ReadLine() ?? "-1");
            titular.Dni = long.Parse(sr.ReadLine() ?? "-1");
            titular.Apellido = sr.ReadLine() ?? " ";
            titular.Nombre= sr.ReadLine() ?? " ";
            titular.Direccion = sr.ReadLine() ?? " ";
            titular.Telefono=sr.ReadLine() ?? " ";
            titular.Email = sr.ReadLine() ?? " ";
            resultado.Add(titular);
        }
        return resultado;
    }
    public void ModificarTitular(Titular titular){
        List<Titular> listT = this.ListarTitulares();
        List<Titular> resulT = new List<Titular>();
        foreach (Titular tAux in listT) {
            if (tAux.Dni == titular.Dni) {
                tAux.Nombre = titular.Nombre;
                tAux.Apellido = titular.Apellido;
                tAux.Direccion = titular.Direccion;
                tAux.Telefono = titular.Telefono;
                tAux.Email = titular.Email;
            }
            resulT.Add(tAux);
        }
        using var sw = new StreamWriter(_nombreArch,false);
        foreach( Titular nodo in resulT ){
            sw.WriteLine(nodo.Id);
            sw.WriteLine(nodo.Dni);
            sw.WriteLine(nodo.Nombre);
            sw.WriteLine(nodo.Apellido);
            sw.WriteLine(nodo.Direccion);
            sw.WriteLine(nodo.Telefono);
            sw.WriteLine(nodo.Email);;
        }
    }
    public void EliminarTitular(int idE){
        List<Titular> listT = this.ListarTitulares();
        List<Titular> resulT = new List<Titular>();
        foreach (Titular tituAux in listT) {
            if (tituAux.Id == idE) {
                continue;
            }
            resulT.Add(tituAux);
        }
        int idA = 0;
        using var sw = new StreamWriter(_nombreArch,false);
        foreach( Titular nodo in resulT ){
            idA += 1;
            sw.WriteLine(idA);
            sw.WriteLine(nodo.Dni);
            sw.WriteLine(nodo.Nombre);
            sw.WriteLine(nodo.Apellido);
            sw.WriteLine(nodo.Direccion);
            sw.WriteLine(nodo.Telefono);
            sw.WriteLine(nodo.Email);
        }
    }
}