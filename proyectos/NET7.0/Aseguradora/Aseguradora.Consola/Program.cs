using Aseguradora.Aplicacion;
using Aseguradora.Repositorios;

//creamos los casos de uso inyectando dependencias
RepositorioTitular repoTitular = new RepositorioTitular();
RepositorioVehiculo repoVehiculo = new RepositorioVehiculo();
RepositorioPoliza repoPoliza = new RepositorioPoliza();
AgregarPolizaUseCase agregarPoliza = new AgregarPolizaUseCase(repoPoliza);
AgregarVehiculoUseCase agregarVehiculo = new AgregarVehiculoUseCase(repoVehiculo);
AgregarTitularUseCase agregarTitular = new AgregarTitularUseCase(repoTitular);
ListarTitularesUseCase listarTitulares = new ListarTitularesUseCase(repoTitular);
ListarPolizasUseCase listarPolizas = new ListarPolizasUseCase(repoPoliza);
ModificarTitularUseCase modificarTitular = new ModificarTitularUseCase(repoTitular);
EliminarTitularUseCase eliminarTitular = new EliminarTitularUseCase(repoTitular,repoVehiculo);
EliminarVehiculoUseCase eliminarVehiculo = new EliminarVehiculoUseCase(repoVehiculo);
ListarTitularesConSusVehiculosUseCase titularesConVehiculos = new ListarTitularesConSusVehiculosUseCase(repoTitular,repoVehiculo);

//Instanciamos un titular
Titular titular = new Titular(33123456, "García", "Juan"){
Direccion = "13 nro. 546",
Telefono = "221-456456",
Email = "joseGarcia@gmail.com",};

Console.WriteLine($"Id del titular recién instanciado: {titular.Id}");
//agregamos el titular utilizando un método local
PersistirTitular(titular);
//el id que corresponde al titular es establecido por el repositorio
Console.WriteLine($"Id del titular una vez persistido: {titular.Id}");

//Se crean polizas de prueba
Poliza p1 = new Poliza(70000,100000,TipoCobertura.TodoRiesgo,new DateTime(1999,1,19),new DateTime(2017,11,20),6);
Poliza p2 = new Poliza(40000,111111,TipoCobertura.ResponsabilidadCivil,new DateTime(2001,1,19),new DateTime(2017,11,20),2);
PersistirPoliza(p1); 
PersistirPoliza(p2);
ListarPolizas();

//Se crean Vehiculos de prueba y se persisten.
Vehiculo v1 = new Vehiculo("AB718JD", "Renault", 2015,4);
Vehiculo v2 = new Vehiculo("AA123AA", "Ford", 2007,4);
Vehiculo v3 = new Vehiculo("BB456BB", "Fiat", 2000,3);
Vehiculo v4 = new Vehiculo("CC789CC", "Chevrolet", 1984,2);
Vehiculo v5 = new Vehiculo("DD000DD", "Peugeot", 1989,2);
Vehiculo v6 = new Vehiculo("EE111EE", "Volks Wagen", 1999,4);
Vehiculo v7 = new Vehiculo("AD437BV", "Chevrolet", 2019,4);
PersistirVehiculo(v1);
PersistirVehiculo(v2);
PersistirVehiculo(v3);
PersistirVehiculo(v4);
PersistirVehiculo(v5);
PersistirVehiculo(v6);
PersistirVehiculo(v7);

//agregamos unos titulares más
PersistirTitular(new Titular(20654987, "Rodriguez", "Ana"));
PersistirTitular(new Titular(31456444, "Alconada", "Fermín"));
PersistirTitular(new Titular(12345654, "Perez", "Cecilia","12314","2211231231","@",v1));

//Se listan los titulares con los vehiculos correspondientes a cada uno.
ListarTitularesConSusVehiculos();

//listamos los titulares utilizando un método local
ListarTitulares();

//no debe ser posible agregar un titular con igual DNI que uno existente
Console.WriteLine("Intentando agregar un titular con DNI 20654987");
titular = new Titular(20654987, "Alvarez", "Alvaro");
PersistirTitular(titular); //este titular no pudo persistirse
//Entonces vamos a modificar el titular existente
Console.WriteLine("Modificando el titular con DNI 20654987");
modificarTitular.Ejecutar(titular);
ListarTitulares();

//Eliminando un titular
Console.WriteLine("Eliminando al titular con id 1");
//Eliminando un vehiculo
Console.WriteLine("Eliminando al vehiculo con id 5");
eliminarTitular.Ejecutar(1);
eliminarVehiculo.Ejecutar(5);

//Se imprimen los titulasres con sus vehiculos correspondientes luego de haber eliminado.
ListarTitularesConSusVehiculos();

//métodos locales
void PersistirTitular(Titular t){
    try{
        agregarTitular.Ejecutar(t);
    }
    catch (Exception e){
        Console.WriteLine(e.Message);
    }
}
void PersistirVehiculo(Vehiculo v){
    try{
        agregarVehiculo.Ejecutar(v);
    }
    catch (Exception e){
        Console.WriteLine(e.Message);
    }
}
void PersistirPoliza(Poliza p){
    try{
        agregarPoliza.Ejecutar(p);
    }
    catch (Exception e){
        Console.WriteLine(e.Message);
    }
}
void ListarTitulares(){
Console.WriteLine("Listando todos los titulares de vehículos");
List<Titular> lista = listarTitulares.Ejecutar() ;
    foreach (Titular t in lista){
    Console.WriteLine(t);
}
}
void ListarTitularesConSusVehiculos(){
    Console.WriteLine("Listando todos los titulares con sus vehiculos");
    List<Titular> titularesV = titularesConVehiculos.Ejecutar();
    foreach (Titular titularAux in titularesV) {
        Console.WriteLine($"Titular {titularAux.Id} con Vehiculo/s: ");
        foreach(Vehiculo v in titularAux.VehiculosAsegurados){
            Console.WriteLine($"    ~ Vehiculo {v.ToString()}");
        }
    }
}
void ListarPolizas(){
    Console.WriteLine("Listando todas las polizas:");
    var polizas = listarPolizas.Ejecutar();
    foreach(Poliza p in polizas){
        Console.WriteLine($"{p.ToString()}");
    }
}
