using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
namespace AL.Aplicacion.UseCases;
public class ModificarClienteUseCase : ClienteUseCase{
   public ModificarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio)
   {      
   }

   public void Ejecutar(Cliente cliente)
   {
       Repositorio.ModificarCliente(cliente);
   }
}