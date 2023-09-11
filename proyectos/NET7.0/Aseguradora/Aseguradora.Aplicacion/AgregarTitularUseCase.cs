namespace Aseguradora.Aplicacion;
public class AgregarTitularUseCase{
    private readonly IRepositorioTitular _repoT;
    public AgregarTitularUseCase(IRepositorioTitular repo){
        this._repoT = repo;
    }
    public void Ejecutar(Titular titular){
        _repoT.AgregarTitular(titular);
        
    }
}