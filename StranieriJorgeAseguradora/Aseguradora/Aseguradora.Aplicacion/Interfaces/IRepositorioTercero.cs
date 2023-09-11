namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public interface IRepositorioTercero{
    void AgregarTercero(Tercero t);
    Tercero? GetTercero(int id);
    List<Tercero> ListarTerceros();
    void ModificarTercero(Tercero t);
    void EliminarTercero(int idE);
}