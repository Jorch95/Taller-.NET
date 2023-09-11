namespace Aseguradora.Aplicacion;
public class Siniestro {
    public int Id {get;set;} = -1;
    public int Poliza {get;set;} = -1;
    public DateTime FechaIngreso {get;set;} = new DateTime();
    public DateTime FechaDeOcurrencia {get;set;} = new DateTime();
    public string DireccionDelHecho {get;set;} = "";
    public string Descripcion {get;set;} = "";
    public Siniestro(int poliza, DateTime fechaIngreso, DateTime fechaDeOcurrencia, string direccionHecho, string desc){
        Poliza = poliza;
        FechaIngreso = fechaIngreso;
        FechaDeOcurrencia = fechaDeOcurrencia;
        DireccionDelHecho = direccionHecho;
        Descripcion = desc;  
    }
    public override string ToString(){
        return ($"Sieniestro {Id}: {Poliza,4} ; {FechaIngreso} {FechaDeOcurrencia} ; {DireccionDelHecho} ; {Descripcion}");
    }
}