namespace Teoria6;
class Colectivo:Automotor{
    public int CantPasajeros;
    public Colectivo(string marca, int modelo, int cantPasajeros):base(marca, modelo){
    this.CantPasajeros = cantPasajeros;
    }
     public override int Modelo{
        protected set =>
           base.Modelo = (value < 2015) ? 2015 : value;
    }

}