namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public interface IRepositorioTitular{
    void AgregarTitular( Titular titular);
    Titular? GetTitular(int id);
    List<Titular> ListarTitulares();
    void ModificarTitular(Titular titular);
    void EliminarTitular(int idE);
    List<Titular> ListarTitularesConVehiculos();
}