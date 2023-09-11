using Teoria6;
/* {
Auto a = new Auto("Ford", 2000, TipoAuto.Deportivo);
Colectivo c = new Colectivo("Mercedes", 2010, 20);
a.Imprimir();
c.Imprimir();
Console.WriteLine(a.Marca + " " + a.Modelo);
Console.WriteLine(c.Marca + " " + c.Modelo);
} */
{
A[] vector = new A[] { new A(3), new B(5), new C(15), new D(41) };
foreach (A a in vector){
    a.Imprimir();
}
}
{
A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector){
    if (a.GetType() == typeof(B) ) { 
        a.Imprimir();
    }
    if (a is B){
        a.Imprimir();
    }
}
}
{
Taxi t = new Taxi(3,"");
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
}
class Auto{
public string Marca { get; private set; } = "Ford";
public Auto(string marca) => this.Marca = marca;
}
class Taxi : Auto{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros, string marca) : base(marca){
        this.Pasajeros = pasajeros; 
    }
}


