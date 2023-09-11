namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class AgregarVehiculoUseCase : VehiculoUseCase{
   public AgregarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
   {
   }
   public void Ejecutar(Vehiculo v){
       //aquí podríamos insertar código de validación de cliente
       Repositorio.AgregarVehiculo(v);
   }
}