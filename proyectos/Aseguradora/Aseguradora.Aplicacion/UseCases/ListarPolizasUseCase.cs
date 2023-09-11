namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ListarPolizasUseCase : PolizaUseCase
{
   public ListarPolizasUseCase(IRepositorioPoliza repositorio) : base(repositorio)
   {
   }
   public List<Poliza> Ejecutar(){
       return Repositorio.ListarPolizas();
   }
}
