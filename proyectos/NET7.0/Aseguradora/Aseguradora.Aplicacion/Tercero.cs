namespace Aseguradora.Aplicacion;
public class Tercero : Persona {
    public int Id {get;set;} = -1;
    public override long Dni {get;set;} = 0;
    public override string Apellido {get;set;} = "";
    public override string Nombre {get;set;} = "";
    public override string Telefono {get;set;} = "0";
    public string Asegurado {get;set;} = "";
    public int SiniestroId {get;set;} = -1;
    public Tercero(long dni, string ape, string nombre, string tel, string aseg, int SId){
        Dni = dni;
        Apellido = ape;
        Nombre = nombre;
        Telefono = tel;
        Asegurado = aseg;
        SiniestroId = SId;
    }
    public override string ToString(){
        return ($"Tercero: {Id}, con DNI: {Dni}; {Nombre} {Apellido} ; Tel: {Telefono} ; {Asegurado} ; con Siniestro: {SiniestroId}");
    }
}