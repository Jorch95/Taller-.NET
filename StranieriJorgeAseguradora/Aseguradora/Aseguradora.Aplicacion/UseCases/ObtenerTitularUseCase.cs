namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ObtenerTitularUseCase : TitularUseCase{
   public ObtenerTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
   { }
    public Titular? Ejecutar(int id){
       return Repositorio.GetTitular(id);
   }
}