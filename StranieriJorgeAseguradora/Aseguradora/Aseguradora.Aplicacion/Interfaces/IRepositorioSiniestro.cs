namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public interface IRepositorioSiniestro{
    void AgregarSiniestro( Siniestro s);
    Siniestro? GetSiniestro(int id);
    List<Siniestro> ListarSiniestros();
    void ModificarSiniestro(Siniestro s);
    void EliminarSiniestro(int idE);
}