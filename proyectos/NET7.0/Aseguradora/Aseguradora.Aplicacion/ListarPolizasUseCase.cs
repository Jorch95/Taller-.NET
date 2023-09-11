namespace Aseguradora.Aplicacion;
public class ListarPolizasUseCase{
    private readonly IRepositorioPoliza _repoP;
    public ListarPolizasUseCase(IRepositorioPoliza repoP){
        _repoP = repoP;
    }
    public List<Poliza> Ejecutar(){
        return _repoP.ListarPolizas();
    }
}