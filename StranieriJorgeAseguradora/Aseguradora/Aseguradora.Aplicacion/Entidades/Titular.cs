namespace Aseguradora.Aplicacion.Entidades;
public class Titular : Persona{
    public int Id {get;set;}
    //[Requiered]
    public override long? Dni{get;set;} 
    public override string Apellido {get;set;} 
    public override string Nombre{get;set;} 
    public string Direccion{get;set;} 
    public override string Telefono{get;set;}
    public string Email{get;set;}
    public List<Vehiculo> VehiculosAsegurados {get;set;} = new List<Vehiculo>(); 
public Titular(){}
public Titular(Vehiculo vehiculo){
    VehiculosAsegurados.Add(vehiculo);
}
public Titular(long dni, string ape, string nom){
    this.Dni = dni;
    this.Apellido = ape;
    Nombre = nom;
}
public Titular(long dni, string ape, string nom, string tel){
    Apellido = ape;
    Nombre = nom;
    this.Telefono = tel;
}
public Titular(long dni, string ape, string nom, string dire, string tel, string email ){
    this.Dni=dni;
    this.Apellido=ape;
    this.Nombre=nom;
    Direccion=dire;
    Telefono=tel;
    Email=email;
}
public Titular(long dni, string ape, string nom, string dire, string tel, string email, Vehiculo vehiculo){
    this.Dni=dni;
    this.Apellido=ape;
    this.Nombre=nom;
    Direccion=dire;
    Telefono=tel;
    Email=email;
    VehiculosAsegurados.Add(vehiculo);
}
    public override string ToString(){
        return $"{this.Id}: {this.Dni} {this.Apellido}, {this.Nombre}  {this.Direccion}  {this.Telefono} {this.Email}";
    }
    public void AgregarVehiculo(Vehiculo v){
        this.VehiculosAsegurados.Add(v);
    }
}