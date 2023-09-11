namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
public class RepositorioPoliza : IRepositorioPoliza{
    private readonly List<Poliza> _listaPolizas = priListarPolizas();

    static private Poliza Clonar(Poliza p)
    {
        return new Poliza(){
            Id = p.Id,
            ValorAsegurado = p.ValorAsegurado,
            Franquicia = p.Franquicia,
            FechaInicioVigencia = p.FechaInicioVigencia,
            FechaFinVigencia = p.FechaFinVigencia,
            Cobertura = p.Cobertura,
            VehiculoId = p.VehiculoId
        };
    }
    public void AgregarPoliza(Poliza p){
        using ( var db = new AseguradoraContext()){
                db.Add(p); 
                db.SaveChanges(); 
                _listaPolizas.Add(Clonar(p));
            }
        }
    public void EliminarPoliza(int id){
            using (var db = new AseguradoraContext()){
                Poliza? pBorrar = GetPoliza(id);
                _listaPolizas.Remove(pBorrar);
                if (pBorrar != null){
                    db.Remove(pBorrar); //se borra realmente con el db.SaveChanges()
                }
                db.SaveChanges(); //actualiza la base de datos.
            }
    }
    public Poliza? GetPoliza(int id){
        using (var db = new AseguradoraContext()){   
        Poliza? p = db.Polizas.Where(p => p.Id == id).SingleOrDefault();
        if (p != null){
            return Clonar(p);
        }
        return null;
        }
    }
    public List<Poliza> ListarPolizas(){
        using (var db = new AseguradoraContext()){
            var polizas = db.Polizas.ToList();
            return polizas;
        }
    }
    private static List<Poliza> priListarPolizas(){
        using (var db = new AseguradoraContext()){
            var polizas = db.Polizas.ToList();
            return polizas;
        }
    }
    public void ModificarPoliza(Poliza pol){
        using (var db = new AseguradoraContext()){
            var p = db.Polizas.Where(p => p.Id == pol.Id).SingleOrDefault();
            if (p != null){
                p.ValorAsegurado = pol.ValorAsegurado; 
                p.Franquicia = pol.Franquicia;
                p.Cobertura = pol.Cobertura;
                p.FechaInicioVigencia = pol.FechaInicioVigencia;
                p.FechaFinVigencia = pol.FechaFinVigencia;
            }
            db.SaveChanges();
        }
    }
}