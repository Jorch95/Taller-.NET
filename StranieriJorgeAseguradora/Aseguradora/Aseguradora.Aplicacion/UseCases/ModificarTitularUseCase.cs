namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class ModificarTitularUseCase : TitularUseCase {

    public ModificarTitularUseCase(IRepositorioTitular repo): base(repo){
    }
    public void Ejecutar(Titular titular){
        Repositorio.ModificarTitular(titular);
    }
}