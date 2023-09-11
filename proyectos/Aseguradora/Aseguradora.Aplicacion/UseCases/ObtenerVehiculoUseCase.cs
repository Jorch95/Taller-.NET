namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ObtenerVehiculoUseCase : VehiculoUseCase{
   public ObtenerVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
   { }
    public Vehiculo? Ejecutar(int id){
       return Repositorio.GetVehiculo(id);
   }
}