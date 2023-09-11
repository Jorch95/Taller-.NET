namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class EliminarVehiculoUseCase : VehiculoUseCase{
    
    public EliminarVehiculoUseCase(IRepositorioVehiculo repo) : base(repo){
    }
    public void Ejecutar(int id){
        Repositorio.EliminarVehiculo(id);
    }
}