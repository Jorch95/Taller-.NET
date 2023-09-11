namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public interface IRepositorioPoliza{
    void AgregarPoliza( Poliza p);
    #nullable enable
    Poliza? GetPoliza(int id);
    #nullable disable
    List<Poliza> ListarPolizas();
    void ModificarPoliza(Poliza p);
    void EliminarPoliza(int idE);
}