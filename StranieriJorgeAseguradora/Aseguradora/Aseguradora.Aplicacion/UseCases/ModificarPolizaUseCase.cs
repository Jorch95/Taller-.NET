namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ModificarPolizaUseCase : PolizaUseCase {

    public ModificarPolizaUseCase(IRepositorioPoliza repo): base(repo){
    }
    public void Ejecutar(Poliza p){
        Repositorio.ModificarPoliza(p);
    }
}