using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class EliminarClienteUseCase : ClienteUseCase{
   public EliminarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio)
   {
   }
   public void Ejecutar(int id)
   {
       Repositorio.EliminarCliente(id);
   }
}
