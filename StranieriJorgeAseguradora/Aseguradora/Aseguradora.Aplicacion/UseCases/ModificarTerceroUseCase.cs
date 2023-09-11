namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ModificarTerceroUseCase : TerceroUseCase {

    public ModificarTerceroUseCase(IRepositorioTercero repo): base(repo){
    }
    public void Ejecutar(Tercero t){
        Repositorio.ModificarTercero(t);
    }
}