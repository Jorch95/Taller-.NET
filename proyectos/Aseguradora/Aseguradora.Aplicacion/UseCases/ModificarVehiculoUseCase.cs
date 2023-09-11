namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ModificarVehiculoUseCase : VehiculoUseCase {

    public ModificarVehiculoUseCase(IRepositorioVehiculo repo): base(repo){
    }
    public void Ejecutar(Vehiculo v){
        Repositorio.ModificarVehiculo(v);
    }
}