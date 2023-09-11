namespace Teoria4;
class Cuenta{
        private static int _id;
        private int _uid;
        int _monto;
        private static int _cdep;
        private static int _cext;
        private static int _cden;
        private static int _dep_total;
        private static int _ext_total;
        private static List<Cuenta> _cuentas = new List<Cuenta>();
        public static List<Cuenta> Cuentas{
            get => new List<Cuenta>(_cuentas);
            }
        //public string? Id {get;} = Guid.NewGuid().ToString(); 
        public static void ImprimirResumen() => Console.WriteLine($"Total = {_dep_total}");
        public static int Total{
            get => _dep_total;
            set => _dep_total = value;
        }
    public Cuenta(){
        _id += 1;
        _uid = _id;
        _cuentas.Add(this);
        Console.WriteLine($"Se creo la cuenta ID={_uid}");
    }
    public Cuenta Depositar(int monto){
        _cdep += 1;
        _monto += monto;
        _dep_total += monto;
        Console.WriteLine($"Se deposito {monto} en la cuenta: {_uid} (Saldo ={_monto})");
        return this;
    }
    public void Imprimir() => Console.WriteLine(_dep_total);
    public Cuenta Extraer(int monto){
        if ((_monto-monto)>=0) {
            _monto -= monto;
            _ext_total += monto;
            _cext += 1;
            Console.WriteLine($"Se extrajo {monto} de la cuenta {_uid} (Saldo {_monto})");
        }
        else {
            _cden += 1;
            Console.WriteLine("Operacion denegada - Saldo insuficiente");
        }
        return this;
    }
    public static List<Cuenta> GetCuentas(){
        List<Cuenta> cuentas = new List<Cuenta>(_cuentas); 
        return cuentas;
        
    }
    public static void ImprimirDetalle(){
        Console.WriteLine($"CUENTAS CREADAS: {_id,3}");
        Console.WriteLine($"DEPOSITOS: {_cdep,9}  - Total depositado: {_dep_total}");
        Console.WriteLine($"EXTRACCIONES: {_cext,6}  - Total extraido: {_ext_total}");
        Console.WriteLine($"                      - Saldo {_dep_total - _ext_total}");
        Console.WriteLine($" * Se denegaron {_cden} extracciones por falta de fondos");
    }
}