namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;
using System;
public class RepositorioVehiculo : IRepositorioVehiculo {
    private readonly string _nombreArch = "vehiculos.txt";
    private int id;
    //No se puede agregar vehiculo con titular no existente.
    public void AgregarVehiculo(Vehiculo vehiculo){
        List<Vehiculo> vehiculos = this.ListarVehiculos();
        foreach (Vehiculo vehiculoAux in vehiculos) {
            if (vehiculoAux.Dominio == vehiculo.Dominio ){
                throw new Exception("Dominio ya en la base");
            }
            id = vehiculoAux.Id;
        }
        using var sw = new StreamWriter(_nombreArch,true);  
        id += 1;
        vehiculo.Id=id;
        sw.WriteLine(vehiculo.Id);
        sw.WriteLine(vehiculo.Dominio);
        sw.WriteLine(vehiculo.Marca);
        sw.WriteLine(vehiculo.AñoFab);
        sw.WriteLine(vehiculo.TitularId);
    } 
    public void EliminarVehiculo(int idV){
         List<Vehiculo> listV = this.ListarVehiculos();
        List<Vehiculo> resulV = new List<Vehiculo>();
        foreach (Vehiculo vAux in listV) {
            if (vAux.Id == idV){
                continue;
            }
            resulV.Add(vAux);
        }
        int idA = 0;
        using var sw = new StreamWriter(_nombreArch,false);
        foreach(Vehiculo nodo in resulV ){
            idA += 1;
            sw.WriteLine(idA);
            sw.WriteLine(nodo.Dominio);
            sw.WriteLine(nodo.Marca);
            sw.WriteLine(nodo.AñoFab);
            sw.WriteLine(nodo.TitularId);
        }
    }
    public List<Vehiculo> ListarVehiculos(){
        var listaV = new List<Vehiculo>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream){
            var vehiculo = new Vehiculo();
            vehiculo.Id = int.Parse(sr.ReadLine() ?? "-1");
            vehiculo.Dominio = sr.ReadLine() ?? "";
            vehiculo.Marca = sr.ReadLine() ?? "";
            vehiculo.AñoFab = int.Parse(sr.ReadLine() ?? "1900");
            vehiculo.TitularId = int.Parse(sr.ReadLine() ?? "-1");
            listaV.Add(vehiculo);
        }
        return listaV;
    }
    public void ModificarVehiculo(Vehiculo V) {
        List<Vehiculo> listV = this.ListarVehiculos();
        List<Vehiculo> resulV = new List<Vehiculo>();
        foreach (Vehiculo vAux in listV) {
            if (vAux.Dominio == V.Dominio) {
                vAux.Marca = V.Marca;
                vAux.AñoFab = V.AñoFab;
                vAux.TitularId = V.TitularId;
            }
            resulV.Add(vAux);
        }
        using var sw = new StreamWriter(_nombreArch,false);
        foreach( Vehiculo nodo in resulV ){
            sw.WriteLine(nodo.Id);
            sw.WriteLine(nodo.Dominio);
            sw.WriteLine(nodo.Marca);
            sw.WriteLine(nodo.AñoFab);
            sw.WriteLine(nodo.TitularId);
        }
    }
    //Cuando se elimina un titular, se eliminan los vehiculos asociados a ese titular.
    public void EliminarTitularVehiculo(int idTV){
        List<Vehiculo> listV = this.ListarVehiculos();
        List<Vehiculo> resulV = new List<Vehiculo>();
        for (int i = 0;i<listV.Count;i++) {
            if (listV[i].TitularId == idTV) {
                continue;
            }
            if (listV[i].TitularId>idTV){ // Se resta 1 en el id, para que no haya  
                listV[i].TitularId-=1;    // un id vacio en el medio.
            }
            resulV.Add(listV[i]);
        }
        using var sw = new StreamWriter(_nombreArch,false);
        foreach( Vehiculo nodo in resulV ){
            sw.WriteLine(nodo.Id);
            sw.WriteLine(nodo.Dominio);
            sw.WriteLine(nodo.Marca);
            sw.WriteLine(nodo.AñoFab);
            sw.WriteLine(nodo.TitularId);
        }
    }
}