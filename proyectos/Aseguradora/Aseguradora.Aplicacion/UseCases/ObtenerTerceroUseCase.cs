namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ObtenerTerceroUseCase : TerceroUseCase{
   public ObtenerTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
   { }
    public Tercero? Ejecutar(int id){
       return Repositorio.GetTercero(id);
   }
}