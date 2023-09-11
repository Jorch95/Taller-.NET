namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class AgregarSiniestroUseCase : SiniestroUseCase{
   public AgregarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
   {
   }
   public void Ejecutar(Siniestro s){
       Repositorio.AgregarSiniestro(s);
   }
}