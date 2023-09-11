namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ObtenerPolizaUseCase : PolizaUseCase{
   public ObtenerPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
   { }
    public Poliza? Ejecutar(int id){
       return Repositorio.GetPoliza(id);
   }
}