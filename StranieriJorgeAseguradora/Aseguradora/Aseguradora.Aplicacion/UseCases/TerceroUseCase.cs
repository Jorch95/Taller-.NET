namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;

public abstract class TerceroUseCase{
   protected IRepositorioTercero Repositorio { get; private set; }
   public TerceroUseCase(IRepositorioTercero repositorio){
       this.Repositorio = repositorio;
   }
}