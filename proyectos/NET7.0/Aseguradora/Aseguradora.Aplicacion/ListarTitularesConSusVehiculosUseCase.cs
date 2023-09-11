namespace Aseguradora.Aplicacion;
public class ListarTitularesConSusVehiculosUseCase {
    private readonly IRepositorioTitular _repoT;
    private readonly IRepositorioVehiculo _repoV;
    public ListarTitularesConSusVehiculosUseCase(IRepositorioTitular repoT, IRepositorioVehiculo repoV){
        _repoT = repoT;
        _repoV = repoV;
    }
    public List<Titular> Ejecutar() {
        List<Titular> titulares = this._repoT.ListarTitulares();
        List<Vehiculo> vehiculos = this._repoV.ListarVehiculos();
        List<Titular> resultado = new List<Titular>();
        foreach(Titular t in titulares){
            foreach(Vehiculo v in vehiculos){
                if(t.Id == v.TitularId){
                    t.AgregarVehiculo(v);
                }
            }
            resultado.Add(t);
        }
        return resultado;
    }
}