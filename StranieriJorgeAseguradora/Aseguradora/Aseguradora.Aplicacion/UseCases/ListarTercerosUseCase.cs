namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ListarTercerosUseCase : TerceroUseCase
{
   public ListarTercerosUseCase(IRepositorioTercero repositorio) : base(repositorio)
   {
   }
   public List<Tercero> Ejecutar(){
       return Repositorio.ListarTerceros();
   }
}
