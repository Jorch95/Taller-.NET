namespace Teoria6;
class Auto:Automotor
{
   public TipoAuto Tipo;
   public Auto(string marca, int modelo, TipoAuto tipo) : base(marca, modelo){
        this.Tipo = tipo;
    }
   public override void Imprimir(){
    Console.Write($"Auto {Tipo} ");
        base.Imprimir();
   }
}