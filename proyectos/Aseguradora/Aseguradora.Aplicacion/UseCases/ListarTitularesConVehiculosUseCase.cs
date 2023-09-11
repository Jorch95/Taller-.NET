namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ListarTitularesConVehiculosUseCase : TitularUseCase
{
   public ListarTitularesConVehiculosUseCase(IRepositorioTitular repositorio) : base(repositorio)
   {
   }
   public List<Titular> Ejecutar(){
       return Repositorio.ListarTitularesConVehiculos();
   }
}
