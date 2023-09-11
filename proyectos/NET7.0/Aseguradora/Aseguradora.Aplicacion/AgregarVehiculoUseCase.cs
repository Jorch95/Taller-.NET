namespace Aseguradora.Aplicacion;
public class AgregarVehiculoUseCase{
    private readonly IRepositorioVehiculo _repoV;
    public AgregarVehiculoUseCase(IRepositorioVehiculo repoV){
        _repoV = repoV;
    }
    public void Ejecutar(Vehiculo v){
        _repoV.AgregarVehiculo(v);
    }
}