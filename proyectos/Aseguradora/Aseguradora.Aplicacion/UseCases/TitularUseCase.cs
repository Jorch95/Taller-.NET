namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;

public abstract class TitularUseCase{
   protected IRepositorioTitular Repositorio { get; private set; }
   public TitularUseCase(IRepositorioTitular repositorio){
       this.Repositorio = repositorio;
   }
}