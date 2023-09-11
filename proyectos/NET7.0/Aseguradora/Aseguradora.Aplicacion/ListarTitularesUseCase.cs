namespace Aseguradora.Aplicacion;
public class ListarTitularesUseCase{
    private readonly IRepositorioTitular _repoT;
    public ListarTitularesUseCase( IRepositorioTitular repo){
        this._repoT = repo;
    }
    public List<Titular> Ejecutar(){
        var listaT = this._repoT.ListarTitulares();
        return listaT;
        
    }
}