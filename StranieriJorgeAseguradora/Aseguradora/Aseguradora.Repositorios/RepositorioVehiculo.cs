namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
public class RepositorioVehiculo : IRepositorioVehiculo{
    private readonly List<Vehiculo> _listaVehiculos = priListarVehiculos();

    static private Vehiculo Clonar(Vehiculo v) //se van a devolver copias de los cliente guardados
    {
        return new Vehiculo(){
            Id = v.Id,
            Dominio = v.Dominio,
            Marca = v.Marca,
            AñoFab = v.AñoFab,
            TitularId = v.TitularId,
        };
    }
    public void AgregarVehiculo(Vehiculo vehiculo){
        using ( var db = new AseguradoraContext()){
            var vduplicado = db.Vehiculos.Any(v=> v.Dominio == vehiculo.Dominio);
            if(vduplicado){
                throw new Exception("Dominio ya registrado. No se agrega vehiculo.");
            }
            else{
                //Agregamos un nuevo vehiculo
                // el Id será establecido por SQLite
                db.Add(vehiculo); // se agregará realmente con el db.SaveChanges()
                db.SaveChanges(); //actualiza la base de datos. SQlite establece el valor de titular.Id
                _listaVehiculos.Add(Clonar(vehiculo));
            }
        }
    }
    public void EliminarVehiculo(int id){
            //borramos de la tabla Alumnos el registro con id
            using (var db = new AseguradoraContext()){
                var vBorrar = GetVehiculo(id);
                _listaVehiculos.Remove(vBorrar);
                if (vBorrar != null){
                    db.Remove(vBorrar); //se borra realmente con el db.SaveChanges()
                }
                db.SaveChanges(); //actualiza la base de datos.
            }
    }
    public Vehiculo? GetVehiculo(int id){
        using (var db = new AseguradoraContext()){   
        Vehiculo? v = db.Vehiculos.Where(v => v.Id == id).SingleOrDefault();
        if (v != null){
            return Clonar(v);
        }
        return null;
        }
    }
    public List<Vehiculo> ListarVehiculos(){
        using (var db = new AseguradoraContext()){
            var vehiculos = db.Vehiculos.ToList();
            return vehiculos;
        }
    }
    private static List<Vehiculo> priListarVehiculos(){
        using (var db = new AseguradoraContext()){
            var vehiculos = db.Vehiculos.ToList();
            return vehiculos;
        }
    }
    public void ModificarVehiculo(Vehiculo vehiculo){
        using (var db = new AseguradoraContext()){
            var v = db.Vehiculos.Where(v => v.Id == vehiculo.Id).SingleOrDefault();
            if (v != null){
                v.Dominio = vehiculo.Dominio; 
                v.AñoFab = vehiculo.AñoFab;
                v.Marca = vehiculo.Marca;
                v.TitularId = vehiculo.TitularId;
            }
            db.SaveChanges();
        }
    }
}