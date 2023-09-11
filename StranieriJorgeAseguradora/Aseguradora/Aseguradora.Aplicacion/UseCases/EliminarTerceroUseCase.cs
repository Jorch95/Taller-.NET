namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class EliminarTerceroUseCase : TerceroUseCase{
    
    public EliminarTerceroUseCase(IRepositorioTercero repo) : base(repo){
    }
    public void Ejecutar(int id){
        Repositorio.EliminarTercero(id);
    }
}