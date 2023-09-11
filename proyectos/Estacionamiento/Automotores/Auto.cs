namespace Automotores;

public class Auto {

string _marca;
int _modelo;

public Auto(string marca, int modelo) {
    _marca = marca;
    _modelo = modelo;
}
public Auto() {
    _marca = "Fiat";
    _modelo = DateTime.Now.Year;
}

public Auto(string marca) : this(marca, DateTime.Now.Year){}

public String getDescripcion () => $"Auto {_marca} {_modelo}";
};

