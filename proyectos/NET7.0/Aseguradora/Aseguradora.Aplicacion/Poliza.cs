namespace Aseguradora.Aplicacion;
public class Poliza{
    public int Id {get;set;} = -1;
    public int ValorAsegurado {get;set;} = 0;
    public int Franquicia {get;set;} = 0;
    public TipoCobertura Cobertura {get;set;} =  TipoCobertura.ResponsabilidadCivil;
    public DateTime FechaInicioVigencia {get;set;} = new DateTime(1900,1,1);
    public DateTime FechaFinVigencia {get;set;} = new DateTime(1900,1,1);
    public int VehiculoId {get;set;} = -1;
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