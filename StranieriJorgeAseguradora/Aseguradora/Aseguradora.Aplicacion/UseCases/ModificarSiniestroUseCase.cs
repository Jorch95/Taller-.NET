namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ModificarSiniestroUseCase : SiniestroUseCase {

    public ModificarSiniestroUseCase(IRepositorioSiniestro repo): base(repo){
    }
    public void Ejecutar(Siniestro s){
        Repositorio.ModificarSiniestro(s);
    }
}