namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;

public abstract class SiniestroUseCase{
   protected IRepositorioSiniestro Repositorio { get; private set; }
   public SiniestroUseCase(IRepositorioSiniestro repositorio){
       this.Repositorio = repositorio;
   }
}