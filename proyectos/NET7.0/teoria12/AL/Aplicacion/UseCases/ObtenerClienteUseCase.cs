using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ObtenerClienteUseCase : ClienteUseCase
{
   public ObtenerClienteUseCase(IRepositorioCliente repositorio) : base(repositorio)
   {
   }

   public Cliente? Ejecutar(int id)
   {
       return Repositorio.GetCliente(id);
   }
}