namespace Aseguradora.Aplicacion;
public class Vehiculo{
      public int Id {get;set;} = -1;
      public string Dominio {get;set;} = "";
      public string Marca {get;set;} = "";
      public int AñoFab {get;set;} = 1932;
      public int TitularId {get;set;} = -1;
   public Vehiculo(){ } 
   public Vehiculo(string dominio, string marca, int añoFabricacion, int titularId){
      Dominio = dominio;
      Marca = marca;
      AñoFab = añoFabricacion;
      TitularId = titularId;
   }
   public override string ToString(){
        return $"{this.Id}: {Dominio,4} ; {Marca} ; {AñoFab} ; IdTitular: {TitularId} ";
    }
}