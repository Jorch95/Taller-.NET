namespace Aseguradora.Aplicacion;
public interface IRepositorioVehiculo{
    void AgregarVehiculo(Vehiculo v);
    void ModificarVehiculo(Vehiculo v);
    List<Vehiculo> ListarVehiculos();
    void EliminarVehiculo(int IdV);
    void EliminarTitularVehiculo(int idV);
}