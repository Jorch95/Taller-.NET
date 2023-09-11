using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class ListarClientesUseCase : ClienteUseCase
{
   public ListarClientesUseCase(IRepositorioCliente repositorio) : base(repositorio)
   {
   }
   public List<Cliente> Ejecutar()
   {
       return Repositorio.GetClientes();
   }
}
