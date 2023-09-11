namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;

public abstract class VehiculoUseCase{
   protected IRepositorioVehiculo Repositorio { get; private set; }
   public VehiculoUseCase(IRepositorioVehiculo repositorio){
       this.Repositorio = repositorio;
   }
}