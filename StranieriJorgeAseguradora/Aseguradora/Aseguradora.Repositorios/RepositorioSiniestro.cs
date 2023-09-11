namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
public class RepositorioSiniestro : IRepositorioSiniestro{
    private readonly List<Siniestro> _listaSiniestros = priListarSiniestros();

    static private Siniestro Clonar(Siniestro s)
    {
        return new Siniestro(){
            Id = s.Id,
            PolizaId = s.PolizaId,
            FechaIngreso = s.FechaIngreso,
            FechaDeOcurrencia = s.FechaDeOcurrencia,
            DireccionDelHecho = s.DireccionDelHecho,
            Descripcion = s.Descripcion,
        };
    }
    public void AgregarSiniestro(Siniestro s){
        using ( var db = new AseguradoraContext()){
            var polizas = db.Polizas.Where(p=> p.Id == s.PolizaId).Single(); 
            if(polizas.FechaFinVigencia <= s.FechaDeOcurrencia){
                throw new Exception("Poliza caducada. No se puede agregar siniestro.");
            }
            else{
                db.Add(s); 
                db.SaveChanges(); 
                _listaSiniestros.Add(Clonar(s));
            }
        }
    }
    public void EliminarSiniestro(int id){
            using (var db = new AseguradoraContext()){
                var sBorrar = GetSiniestro(id);
                _listaSiniestros.Remove(sBorrar);
                if (sBorrar != null){
                    db.Remove(sBorrar); //se borra realmente con el db.SaveChanges()
                }
                db.SaveChanges(); //actualiza la base de datos.
            }
    }
    public Siniestro? GetSiniestro(int id){
        using (var db = new AseguradoraContext()){   
        Siniestro? s = db.Siniestros.Where(s => s.Id == id).SingleOrDefault();
        if (s != null){
            return Clonar(s);
        }
        return null;
        }
    }
    public List<Siniestro> ListarSiniestros(){
        using (var db = new AseguradoraContext()){
            var siniestros = db.Siniestros.ToList();
            return siniestros;
        }
    }
    private static List<Siniestro> priListarSiniestros(){
        using (var db = new AseguradoraContext()){
            var siniestros = db.Siniestros.ToList();
            return siniestros;
        }
    }
    public void ModificarSiniestro(Siniestro sin){
        using (var db = new AseguradoraContext()){
            var s = db.Siniestros.Where(s => s.Id == sin.Id).SingleOrDefault();
            if (s != null){
                s.PolizaId = sin.PolizaId; 
                s.FechaIngreso = sin.FechaIngreso;
                s.FechaDeOcurrencia = sin.FechaDeOcurrencia;
                s.DireccionDelHecho = sin.DireccionDelHecho;
                s.Descripcion = sin.Descripcion;
            }
            db.SaveChanges();
        }
    }
}