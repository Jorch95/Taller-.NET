namespace Aseguradora.Aplicacion.Entidades;
public class Poliza{
    public int Id {get;set;}
    public int? ValorAsegurado {get;set;} 
    public int? Franquicia {get;set;} 
    public TipoCobertura Cobertura {get;set;} 
    public DateTime FechaInicioVigencia {get;set;} 
    public DateTime FechaFinVigencia {get;set;} 
    public int VehiculoId {get;set;}
    public Poliza(){

    }
    public Poliza(int valor, int franq, TipoCobertura cobertura, DateTime FI, DateTime FF, int vId){
        ValorAsegurado = valor;
        Franquicia = franq;
        Cobertura = cobertura;
        FechaInicioVigencia = FI;
        FechaFinVigencia = FF;
        VehiculoId = vId;
    }
    public override string ToString(){
        return $"Poliza:{Id,-2}; Pertenece al vehiculo: {VehiculoId,-2} ; {ValorAsegurado,-2} ; {Franquicia,-2} ; {Cobertura,-2} ; {FechaInicioVigencia.ToShortDateString(),-2} ; {FechaFinVigencia.ToShortDateString(),-2}";
    }
}