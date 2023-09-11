
using teoria8;

Auxiliar aux = new Auxiliar();
aux.Procesar();

Pyme miPyme = new Pyme(new Empleado("Juan"),
                      new Empleado("Adriana"),
                      new Empleado("Diego"));
foreach (Empleado e in miPyme){
   e.Imprimir();
}
