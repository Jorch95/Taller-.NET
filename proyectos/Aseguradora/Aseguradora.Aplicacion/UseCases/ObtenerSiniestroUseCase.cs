namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class ObtenerSiniestroUseCase : SiniestroUseCase{
   public ObtenerSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
   { }
    public Siniestro? Ejecutar(int id){
       return Repositorio.GetSiniestro(id);
   }
}