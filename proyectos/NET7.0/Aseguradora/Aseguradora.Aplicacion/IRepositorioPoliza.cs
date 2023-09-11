namespace Aseguradora.Aplicacion;
public interface IRepositorioPoliza{
    void AgregarPoliza(Poliza p);
    List<Poliza> ListarPolizas();
    void ModificarPoliza(Poliza p);
    void EliminarPoliza(int idP);
}