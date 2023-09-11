namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class EliminarSiniestroUseCase : SiniestroUseCase{
    
    public EliminarSiniestroUseCase(IRepositorioSiniestro repo) : base(repo){
    }
    public void Ejecutar(int id){
        Repositorio.EliminarSiniestro(id);
    }
}