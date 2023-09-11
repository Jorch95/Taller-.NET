namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class AgregarPolizaUseCase : PolizaUseCase{
   public AgregarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
   {
   }
   public void Ejecutar(Poliza p){
       Repositorio.AgregarPoliza(p);
   }
}