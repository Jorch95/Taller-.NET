namespace Aseguradora.Aplicacion;
public class EliminarTitularUseCase{
    private readonly IRepositorioTitular _repoT;
    private readonly IRepositorioVehiculo _repoV;
    public EliminarTitularUseCase(IRepositorioTitular repoT, IRepositorioVehiculo repoV){
        this._repoT = repoT;
        this._repoV = repoV;
    }
    public void Ejecutar(int idE){              
        _repoV.EliminarTitularVehiculo(idE);    //Se utilizab dos repositorios en este
        _repoT.EliminarTitular(idE);            //UseCase para eliminar en cascada.
                                                
    }
}