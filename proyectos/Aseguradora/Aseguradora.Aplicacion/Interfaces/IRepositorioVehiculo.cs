namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public interface IRepositorioVehiculo{
    void AgregarVehiculo( Vehiculo vehiculo);
    Vehiculo? GetVehiculo(int id);
    List<Vehiculo> ListarVehiculos();
    void ModificarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int idE);
}