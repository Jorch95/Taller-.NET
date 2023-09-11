namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class EliminarTitularUseCase : TitularUseCase{
    
    public EliminarTitularUseCase(IRepositorioTitular repo) : base(repo){
    }
    public void Ejecutar(int id){
        Repositorio.EliminarTitular(id);
    }
}