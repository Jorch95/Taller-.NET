namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;
public class RepositorioPoliza : IRepositorioPoliza{
    private readonly string _nombreArch = "polizas.txt";
    private int id;
    public void AgregarPoliza(Poliza p){
        List<Poliza> polizas = this.ListarPolizas();
        foreach (Poliza polizaAux in polizas) {
            if (polizaAux.VehiculoId == p.VehiculoId ){
                Console.WriteLine("Vehiculo ya asegurado en la base.");
                return;
            }
            id = polizaAux.Id;
        }
        using var sw = new StreamWriter(_nombreArch,true);  
        id += 1;
        p.Id=id;
        sw.WriteLine(p.Id);
        sw.WriteLine(p.ValorAsegurado);
        sw.WriteLine(p.Franquicia);
        sw.WriteLine((int)p.Cobertura);
        sw.WriteLine(p.FechaInicioVigencia.ToShortDateString());
        sw.WriteLine(p.FechaFinVigencia.ToShortDateString());
        sw.WriteLine(p.VehiculoId);
    }
    public List<Poliza> ListarPolizas(){
        var listaP = new List<Poliza>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream){
            var poliza = new Poliza();
            poliza.Id = int.Parse(sr.ReadLine() ?? "-1");
            poliza.ValorAsegurado = int.Parse(sr.ReadLine() ?? "");
            poliza.Franquicia = int.Parse(sr.ReadLine() ?? "");
            poliza.Cobertura = (TipoCobertura)int.Parse(sr.ReadLine() ?? "0");
            poliza.FechaInicioVigencia = (DateTime.Parse(sr.ReadLine() ?? "-1"));
            poliza.FechaFinVigencia = DateTime.Parse(sr.ReadLine() ?? "-1");
            poliza.VehiculoId = int.Parse(sr.ReadLine() ?? "-1");
            listaP.Add(poliza);
        }
        return listaP;
    }
    public void ModificarPoliza(Poliza p){
        List<Poliza> listP = this.ListarPolizas();
        List<Poliza> resulP = new List<Poliza>();
        foreach (Poliza pAux in listP) {
            if (pAux.VehiculoId == p.VehiculoId) {
                pAux.ValorAsegurado = p.ValorAsegurado;
                pAux.Franquicia = p.Franquicia;
                pAux.Cobertura = p.Cobertura;
                pAux.FechaInicioVigencia = p.FechaInicioVigencia;
                pAux.FechaFinVigencia = p.FechaFinVigencia;
            }
            resulP.Add(pAux);
        }
        using var sw = new StreamWriter(_nombreArch,false);
        foreach( Poliza nodo in resulP ){
            sw.WriteLine(nodo.Id);
            sw.WriteLine(nodo.ValorAsegurado);
            sw.WriteLine(nodo.Franquicia);
            sw.WriteLine(nodo.Cobertura);
            sw.WriteLine(nodo.FechaInicioVigencia);
            sw.WriteLine(nodo.FechaFinVigencia);
            sw.WriteLine(nodo.VehiculoId);
        }
    }
    public void EliminarPoliza(int idP){
        List<Poliza> listP = this.ListarPolizas();
        List<Poliza> resulP = new List<Poliza>();
        for (int i = 0;i<listP.Count;i++) {
            if (listP[i].Id == idP) {
                continue;
            }
            if (listP[i].Id>idP){
                listP[i].Id-=1;
            }
            resulP.Add(listP[i]);
        }
        using var sw = new StreamWriter(_nombreArch,false);
        foreach( Poliza nodo in resulP ){
            sw.WriteLine(nodo.Id);
            sw.WriteLine(nodo.ValorAsegurado);
            sw.WriteLine(nodo.Franquicia);
            sw.WriteLine(nodo.Cobertura);
            sw.WriteLine(nodo.FechaInicioVigencia);
            sw.WriteLine(nodo.FechaFinVigencia);
            sw.WriteLine(nodo.VehiculoId);
        }
    }
}