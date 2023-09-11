namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ListarVehiculosUseCase : VehiculoUseCase
{
   public ListarVehiculosUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
   {
   }
   public List<Vehiculo> Ejecutar(){
       return Repositorio.ListarVehiculos();
   }
}
