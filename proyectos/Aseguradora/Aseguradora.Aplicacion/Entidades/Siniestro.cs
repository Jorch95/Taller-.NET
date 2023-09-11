namespace Aseguradora.Aplicacion.Entidades;
public class Siniestro {
    public int Id {get;set;}
    public int PolizaId {get;set;}
    public DateTime FechaIngreso {get;set;} = new DateTime();
    public DateTime FechaDeOcurrencia {get;set;} = new DateTime();
    public string DireccionDelHecho {get;set;}
    public string Descripcion {get;set;} 
    public Siniestro(){}
    public Siniestro(int poliza){
        PolizaId = poliza;
    }
    public Siniestro(int poliza, DateTime fechaIngreso, DateTime fechaDeOcurrencia, string direccionHecho, string desc){
        PolizaId = poliza;
        FechaIngreso = fechaIngreso;
        FechaDeOcurrencia = fechaDeOcurrencia;
        DireccionDelHecho = direccionHecho;
        Descripcion = desc;  
    }
    
    public override string ToString(){
        return ($"Sieniestro {Id}: {PolizaId,4} ; {FechaIngreso} {FechaDeOcurrencia} ; {DireccionDelHecho} ; {Descripcion}");
    }
}