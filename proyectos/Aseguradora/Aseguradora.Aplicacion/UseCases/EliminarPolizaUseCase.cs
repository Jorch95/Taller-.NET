namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class EliminarPolizaUseCase : PolizaUseCase{
    
    public EliminarPolizaUseCase(IRepositorioPoliza repo) : base(repo){
    }
    public void Ejecutar(int id){
        Repositorio.EliminarPoliza(id);
    }
}