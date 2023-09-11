namespace Aseguradora.Aplicacion;
public class ModificarTitularUseCase{
    private readonly IRepositorioTitular _repoT;
    public ModificarTitularUseCase(IRepositorioTitular repo){
        this._repoT = repo;
    }
    public void Ejecutar(Titular titular){
        this._repoT.ModificarTitular(titular);
        }
    }
