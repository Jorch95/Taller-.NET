namespace Aseguradora.Aplicacion;
public class AgregarPolizaUseCase{
    private readonly IRepositorioPoliza _repoP;

    public AgregarPolizaUseCase(IRepositorioPoliza repoP){
        this._repoP = repoP;
    }
 public void Ejecutar(Poliza p) {
    _repoP.AgregarPoliza(p);
 }
}