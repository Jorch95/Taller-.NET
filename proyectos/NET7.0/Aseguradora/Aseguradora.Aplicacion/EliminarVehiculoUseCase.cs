namespace Aseguradora.Aplicacion;
public class EliminarVehiculoUseCase{
    private readonly IRepositorioVehiculo _repoV;
    public EliminarVehiculoUseCase(IRepositorioVehiculo repoV){
        _repoV = repoV;
    }
    public void Ejecutar(int idV){
        _repoV.EliminarVehiculo(idV);
    }
}