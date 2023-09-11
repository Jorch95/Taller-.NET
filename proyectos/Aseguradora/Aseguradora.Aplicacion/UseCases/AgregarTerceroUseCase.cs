namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class AgregarTerceroUseCase : TerceroUseCase{
   public AgregarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
   {
   }
   public void Ejecutar(Tercero t){
       Repositorio.AgregarTercero(t);
   }
}