namespace Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class AgregarTitularUseCase : TitularUseCase{
   public AgregarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
   {
   }
   public void Ejecutar(Titular titular){
       //aquí podríamos insertar código de validación de cliente
       Repositorio.AgregarTitular(titular);
   }
}