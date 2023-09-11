namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
public class RepositorioTercero : IRepositorioTercero{
    private readonly List<Tercero> _listaTerceros = priListarTerceros();

    static private Tercero Clonar(Tercero t)
    {
        return new Tercero(){
            Id = t.Id,
            Nombre = t.Nombre,
            Apellido = t.Apellido,
            Dni = t.Dni,
            Asegurado = t.Asegurado,
            Telefono = t.Telefono,
            SiniestroId = t.SiniestroId
        };
    }
    public void AgregarTercero(Tercero t){
        using ( var db = new AseguradoraContext()){
                db.Add(t); 
                db.SaveChanges(); 
                _listaTerceros.Add(Clonar(t));
            }
        }
    public void EliminarTercero(int id){
            using (var db = new AseguradoraContext()){
                var tBorrar = GetTercero(id);
                _listaTerceros.Remove(tBorrar);
                if (tBorrar != null){
                    db.Remove(tBorrar); //se borra realmente con el db.SaveChanges()
                }
                db.SaveChanges(); //actualiza la base de datos.
            }
    }
    public Tercero? GetTercero(int id){
        using (var db = new AseguradoraContext()){   
        Tercero? t = db.Terceros.Where(t => t.Id == id).SingleOrDefault();
        if (t != null){
            return Clonar(t);
        }
        return null;
        }
    }
    public List<Tercero> ListarTerceros(){
        using (var db = new AseguradoraContext()){
            var terceros = db.Terceros.ToList();
            return terceros;
        }
    }
    private static List<Tercero> priListarTerceros(){
        using (var db = new AseguradoraContext()){
            var terceros = db.Terceros.ToList();
            return terceros;
        }
    }
    public void ModificarTercero(Tercero ter){
        using (var db = new AseguradoraContext()){
            var t = db.Terceros.Where(t => t.Id == ter.Id).SingleOrDefault();
            if (t != null){
                t.Nombre = ter.Nombre;
                t.Apellido = ter.Apellido;
                t.Dni = ter.Dni;
                t.Asegurado = t.Asegurado;
                t.Telefono = t.Telefono;
            }
            db.SaveChanges();
        }
    }
}