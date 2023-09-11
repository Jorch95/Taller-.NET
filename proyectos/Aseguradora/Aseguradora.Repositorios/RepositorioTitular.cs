namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using Microsoft.EntityFrameworkCore;

public class RepositorioTitular : IRepositorioTitular{
    private readonly List<Titular> _listaTitulares = priListarTitulares();

    static private Titular Clonar(Titular t) //se van a devolver copias de los cliente guardados
    {
        return new Titular(){
            Id = t.Id,
            Nombre = t.Nombre,
            Apellido = t.Apellido,
            Dni = t.Dni,
            Direccion = t.Direccion,
            Telefono = t.Telefono,
            Email = t.Email,

        };
    }
    public void AgregarTitular(Titular titular){
        var titdupl = _listaTitulares.Any(t=> t.Dni == titular.Dni);
        if(titdupl){
            throw new Exception("Dni ya registrado. No se agrega titular");
        }
        else{
            using (var db = new AseguradoraContext()){
            //Agregamos un nuevo titular
            // el Id será establecido por SQLite
            db.Add(titular); // se agregará realmente con el db.SaveChanges()
            db.SaveChanges(); //actualiza la base de datos. SQlite establece el valor de titular.Id
            _listaTitulares.Add(Clonar(titular));
        }
        }
    }
    public void EliminarTitular(int id){
            //borramos de la tabla Alumnos el registro con id
            using (var db = new AseguradoraContext()){
                var tituBorrar = GetTitular(id);
                _listaTitulares.Remove(tituBorrar);
                if (tituBorrar != null){
                    db.Remove(tituBorrar); //se borra realmente con el db.SaveChanges()
                }
                db.SaveChanges(); //actualiza la base de datos.
            }
    }
    public Titular? GetTitular(int id){
        using (var db = new AseguradoraContext()){   
        Titular? t = db.Titulares.Where(t => t.Id == id).SingleOrDefault();
        if (t != null){
            return Clonar(t);
        }
        return null;
        }
    }
    public List<Titular> ListarTitulares(){
        using (var db = new AseguradoraContext()){
            var titulares = db.Titulares.ToList();
            return titulares;
        }
    }
    private static List<Titular> priListarTitulares(){
        using (var db = new AseguradoraContext()){
            var titulares = db.Titulares.ToList();
            return titulares;
        }
    }
    public void ModificarTitular(Titular titular){
        using (var db = new AseguradoraContext()){
            var t = db.Titulares.Where(t => t.Id == titular.Id).SingleOrDefault();
            if (t != null){
                t.Apellido = titular.Apellido;
                t.Nombre = titular.Nombre;   
                t.Dni = titular.Dni;
                t.Direccion = titular.Direccion;
                t.Email = titular.Email;
                t.Telefono = titular.Telefono;
            }
            db.SaveChanges();
        }
    }
    public List<Titular> ListarTitularesConVehiculos(){
        using (var db = new AseguradoraContext()){
            List<Titular> t = db.Titulares.Include(t => t.Vehiculos).ToList();
            return t;
        }          
    } 
}