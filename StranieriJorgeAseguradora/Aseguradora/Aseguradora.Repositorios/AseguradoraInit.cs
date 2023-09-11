namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Entidades; 
public class AseguradoraInit{
   public static void Inicializar(AseguradoraContext context){
       if (context.Titulares.Count() > 0) // ya fue inicializada
       {
           return;
       }
       context.Add(new Titular() { Nombre = "Juan",Email="juan@gmail.com", Dni=22 });
       context.Add(new Titular() { Nombre = "Ana", Dni=40 });
       context.Add(new Titular() { Nombre = "Laura", Dni=38665792});
       context.SaveChanges();
   }
}