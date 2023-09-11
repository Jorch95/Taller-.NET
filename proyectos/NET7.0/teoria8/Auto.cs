namespace teoria8;
class Auto:Automotor
{
   public Auto(string marca, int modelo) : base(marca, modelo){
    }
   public override void Imprimir(){
    //Console.Write($"Auto {Tipo} ");
        base.Imprimir();
   }
}